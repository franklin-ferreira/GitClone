using MetroFramework;
using MetroFramework.Forms;
using SDK.Extensions.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitClone
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> repositories = new List<string>();
        private string localDownload = string.Empty;
        (bool step1, bool step2, bool step3) progress = (false, false, false);
        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                repositories.AddRange(File.ReadAllLines(openFileDialog1.FileName));
                repositories.RemoveAll(x => string.IsNullOrEmpty(x));

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
                    btnIniciar.Text = "Cancelar donwload";

                metroProgressSpinner1.Spinning = true;
                try
                {
                    listBox1.Items.Clear();
                    await Task.Factory.StartNew(async () =>
                    {
                        startProcess = true;
                        if (metroToggle1.Checked)
                        {
                            Parallel.ForEach(repositories, async repos =>
                            {
                                await Extension.RunCommandInWindowsPropmptAsync($"cd {localDownload} && git clone {repos}").ContinueWith(_ =>
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
                                            await Extension.RunCommandInWindowsPropmptAsync($"start {localDownload}");
                                            metroProgressSpinner1.Spinning = false;
                                            btnIniciar.Text = "Iniciar donwload";
                                            startProcess = false;
                                        }
                                    }));
                                });
                            });
                        }
                        else
                        {
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
                                            await Extension.RunCommandInWindowsPropmptAsync($"start {localDownload}");
                                            metroProgressSpinner1.Spinning = false;
                                            btnIniciar.Text = "Iniciar donwload";
                                            startProcess = false;
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
                    btnIniciar.Text = "Iniciar donwload";
                    startProcess = false;
                }
            }
            else
            {
                MessageBox.Show("Siga os passos acima.");
            }
        }
    }
}
