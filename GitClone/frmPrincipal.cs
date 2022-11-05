using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;
using SDK.Extensions.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ucControls;

namespace GitClone
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Setup();
        }
        List<string> repositories = new List<string>();
        private string localDownload = string.Empty;
        (bool step1, bool step2, bool step3) progress = (false, false, false);
        private async void metroLink1_Click(object sender, System.EventArgs e)
        {
            if (!await VerifyVersionGitForWindows())
                return;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                repositories.AddRange(File.ReadAllLines(openFileDialog1.FileName));
                repositories.RemoveAll(x => string.IsNullOrEmpty(x));
                ucNotificacao.AddNotificacao($"Arquivo selecionado: {openFileDialog1.SafeFileName}");
            }
            validAllProgress();

        }

        public void validAllProgress()
        {
            ValidStep1();
            ValidStep2();
            ValidStep3();
        }


        private void metroLink3_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                localDownload = folderBrowserDialog1.SelectedPath;
                ucNotificacao.AddNotificacao($"Local download: {localDownload}");
            }
            validAllProgress();

        }
        public void SetProgress()
        {
            mtProgress.Text = $@"{listBox1.Items.Count} / {repositories.Count()}";
        }

        private void ValidStep1()
        {
            if (repositories.Any())
            {
                SetProgress();
                pictureBox1.Image = Properties.Resources.ok_48px;
                progress.step1 = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.error_48px;
                progress.step1 = false;
            }
        }
        private void ValidStep2()
        {
            if (Directory.Exists(localDownload))
            {
                pictureBox2.Image = Properties.Resources.ok_48px;
                progress.step2 = true;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.error_48px;
                progress.step2 = false;
            }
        }
        private void ValidStep3()
        {
            if (progress.step1 && progress.step2)
            {
                progress.step3 = true;
                pictureBox3.Image = Properties.Resources.ok_48px;
            }
            else
            {
                progress.step3 = false;
                pictureBox3.Image = Properties.Resources.error_48px;
            }
        }
        public async Task<bool> VerifyVersionGitForWindows()
        {
            var result = Extension.VerifyRegisterKey("GitForWindows");
            lblGitStatus.Text = $"GIT:. CurrentVersion: {result.CurrentVersion}";

            if (string.IsNullOrEmpty(result.InstallPath))
            {
                try
                {
                    btnSelecionarLocaldownload.Enabled = false;
                    btnSelecionarArquivo.Enabled = false;
                    btnSelecionarLocaldownload.Enabled = false;

                    await downloadGetForWindows();

                    btnSelecionarLocaldownload.Enabled = true;
                    btnSelecionarArquivo.Enabled = true;
                    btnSelecionarLocaldownload.Enabled = true;
                }
                catch (Exception)
                {
                    btnSelecionarLocaldownload.Enabled = true;
                    btnSelecionarArquivo.Enabled = true;
                    btnSelecionarLocaldownload.Enabled = true;
                }

                return false;
            }

            return true;
        }
        ucNotificacao ucNotificacao;
        public void Setup()
        {
            var val = Extension.VerifyRegisterKey("GitForWindows");
            lblGitStatus.Text = $"GIT:. CurrentVersion: {val.CurrentVersion}";
            string link, version, wasPublished;
            GetLinkAndVersion(out link, out version, out wasPublished);
            bool isUpdateDisponivel = false;
            if (val.CurrentVersion != version)
            {
                isUpdateDisponivel = true;
                btnUpdate.Visible = true;
                toolTip1.SetToolTip(btnUpdate, $"Iniciar download Git-{version}");

            }
            if (ucNotificacao == null)
            {
                ucNotificacao = new ucNotificacao();
                painelNotificacao.Controls.Clear();
                painelNotificacao.Controls.Add(ucNotificacao);
                if (isUpdateDisponivel)
                {
                    ucNotificacao.timerInterval = 60000;
                    ucNotificacao.AddNotificacao($"Nova versão do Git-{version} está disponível.");
                }
            }
        }

        public async Task downloadGetForWindows()
        {
            try
            {
                string link, version, wasPublished;
                GetLinkAndVersion(out link, out version, out wasPublished);
                if (!string.IsNullOrEmpty(link))
                {
                    await downloadGiForWindowsLastVersion(link, version);
                }
                else
                {
                    if (MessageBox.Show($"Deseja executar o download manualmente ?", $"Erro Baixar Git for Windows") == DialogResult.Yes)
                        await Extension.RunCommandInWindowsPropmptAsync($"start https://gitforwindows.org/");
                }



            }
            catch (Exception ex)
            {
                if (MessageBox.Show($"{ex.Message}", $"Erro Baixar Git for Windows") == DialogResult.Yes)
                    await Extension.RunCommandInWindowsPropmptAsync($"start https://gitforwindows.org/");
            }
        }

        private static void GetLinkAndVersion(out string link, out string version, out string wasPublished)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://gitforwindows.org/");
            var response = request.GetResponseAsync().Result;
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var contentSplit = content.StringForArrayChar();
            link = contentSplit.Where(x => x.Contains("href=\"https://github.com/git-for-windows/git/releases/tag/"))
                                                .FirstOrDefault()
                                                .ToString().Replace("<div class=\"version\"><a href=\"","");
            version = string.Empty;
            wasPublished = string.Empty;
            if (!string.IsNullOrEmpty(link))
            {
                var title = link.Substring(link.IndexOf("title=")).Replace("title=\"", "");
                wasPublished = title.Remove(title.IndexOf("\">"));
                

                int operationSystem = Environment.Is64BitOperatingSystem ? 64 : 32;
                link = link.Trim().Replace("tag", "download").Replace("href=\"", "");
                version = link.Remove(0, link.IndexOf("download/"));
                version = version.Remove(version.IndexOf("windows") - 1).Replace("download/v", "");
                link = $"{link.Remove(link.Length - 1)}/Git-{version}-{operationSystem}-bit.exe";

            }
        }

        private static async Task downloadGiForWindowsLastVersion(string link, string version)
        {
            using (var client = new HttpClient())
            using (var result = await client.GetAsync(link))
            {
                var fileByte = result.IsSuccessStatusCode ? await result.Content.ReadAsByteArrayAsync() : null;

                if (fileByte == null)
                    throw new Exception("Deseja executar o download manualmente ?");

                if (fileByte != null && fileByte.Any())
                {
                    var downloadsPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", string.Empty).ToString();
                    var filePath = $@"{downloadsPath}\Git-{version}.exe";
                    await Extension.CreateFileIfFileNotExistAsync(filePath, filePath, Convert.ToBase64String(fileByte));
                    if (File.Exists(filePath))
                    {
                        await Extension.RunCommandInWindowsPropmptAsync($"start {filePath}");
                    }
                    else
                    {
                        if (MessageBox.Show($"Deseja executar o download manualmente ?", $"Erro Baixar Git-{version}") == DialogResult.Yes)
                        {
                            await Extension.RunCommandInWindowsPropmptAsync($"start {link}");
                        }
                    }
                }
            }
        }

        volatile bool startProcess = false;
        private async void metroLink2_Click(object sender, System.EventArgs e)
        {
            CancellationTokenSource token = new CancellationTokenSource();
            if (startProcess)
                token.Cancel();

            if (progress.step1 && progress.step2 && progress.step3)
            {

                var taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

                if (!startProcess)
                    btnSelecionarLocaldownload.Text = "Cancelar download";

                metroProgressSpinner1.Spinning = true;
                try
                {
                    listBox1.Items.Clear();

                    await Task.Factory.StartNew(async () =>
                    {
                        startProcess = true;

                        Invoke(new MethodInvoker(() =>
                        {
                            ucNotificacao.AddNotificacao("Iniciando download");
                            metroPanel2.Enabled = false;
                            metroToggle1.Enabled = false;

                        }));

                        if (metroToggle1.Checked)
                        {
                            bool isCompleted = false;
                            Invoke(new MethodInvoker(() =>
                            {
                                metroToggle1.Checked = false;
                            }));
                            Parallel.ForEach(repositories, async repos =>
                            {
                                await Extension.RunCommandInWindowsPropmptAsync($"cd {localDownload} && git clone {repos}").ContinueWith(_ =>
                                {
                                    var dir = Directory.GetDirectories(localDownload);
                                    Invoke(new MethodInvoker(() =>
                                    {
                                        listBox1.Items.Clear();
                                        listBox1.Items.AddRange(dir.Select(x => Path.GetFileName(x)).ToArray());
                                        listBox1.Refresh();
                                        mtTotal.Text = $"Baixando {listBox1.Items.Count.ToString()} ..";
                                        SetProgress();
                                    }));
                                });
                                
                            });
                            Invoke(new MethodInvoker(async () =>
                            {
                                if (listBox1.Items.Count == repositories.Count)
                                {
                                    mtTotal.Text = $"Total {listBox1.Items.Count.ToString()} ..";
                                    if (!isCompleted)
                                    {
                                        await Extension.RunCommandInWindowsPropmptAsync($"start {localDownload}");
                                        ucNotificacao.AddNotificacao("Repositórios baixados.");
                                    }
                                    isCompleted = true;

                                    metroProgressSpinner1.Spinning = false;
                                    btnSelecionarLocaldownload.Text = "Iniciar download";
                                    startProcess = false;

                                    metroPanel2.Enabled = true;
                                    metroToggle1.Enabled = true;

                                }
                            }));
                        }
                        else
                        {
                            bool isCompleted = false;
                            Invoke(new MethodInvoker(() =>
                            {
                                metroToggle1.Checked = false;
                            }));
                            foreach (var item in repositories)
                            {
                                await Extension.RunCommandInWindowsPropmptAsync($"cd {localDownload} && git clone {item}")
                                .ContinueWith(_ =>
                                {
                                    var dir = Directory.GetDirectories(localDownload);
                                    Invoke(new MethodInvoker(async () =>
                                    {
                                        listBox1.Items.Clear();
                                        listBox1.Items.AddRange(dir.Select(x => Path.GetFileName(x)).ToArray());
                                        listBox1.Refresh();
                                        mtTotal.Text = $"Baixando {listBox1.Items.Count.ToString()} ..";

                                        SetProgress();
                                        if (listBox1.Items.Count == repositories.Count)
                                        {
                                            mtTotal.Text = $"Total {listBox1.Items.Count.ToString()} ..";
                                            if (!isCompleted)
                                            {
                                                await Extension.RunCommandInWindowsPropmptAsync($"start {localDownload}");
                                                ucNotificacao.AddNotificacao("Repositórios baixados.");
                                            }
                                            isCompleted = true;
                                            metroProgressSpinner1.Spinning = false;
                                            btnSelecionarLocaldownload.Text = "Iniciar download";
                                            startProcess = false;

                                            metroPanel2.Enabled = true;
                                            metroToggle1.Enabled = true;


                                        }
                                    }));
                                });
                            }
                        }

                    }, token.Token, TaskCreationOptions.None, TaskScheduler.Current);
                }
                catch (System.Exception ex)
                {
                    if (token.IsCancellationRequested)
                    {
                        MessageBox.Show("Operação cancelada.");
                    }
                    else
                    {
                        MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    btnSelecionarLocaldownload.Text = "Iniciar download";
                    startProcess = false;
                    metroPanel2.Enabled = true;
                    metroToggle1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Siga os passos acima.");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await downloadGetForWindows();
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            var val = Extension.VerifyRegisterKey("GitForWindows");
            lblGitStatus.Text = $"GIT:. CurrentVersion: {val.CurrentVersion}";
            string link, version, wasPublished;
            GetLinkAndVersion(out link, out version, out wasPublished);
            if (val.CurrentVersion != version)
            {
                btnUpdate.Visible = true;
                toolTip1.SetToolTip(btnUpdate, $"Iniciar download Git-{version}");
                ucNotificacao.AddNotificacao($"Nova versão do Git-{version} está disponível");
                btnUpdate.Enabled = true;
            }
            else
            {
                ucNotificacao.timerInterval = 60000;
                ucNotificacao.AddNotificacao($"Você já está com a ultima versão do Git Bash\n{wasPublished}");
                btnUpdate.Enabled = false;
            }
        }
    }
}
