namespace GitClone
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mtTotal = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.btnSelecionarLocaldownload = new MetroFramework.Controls.MetroLink();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.mtProgress = new MetroFramework.Controls.MetroTile();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnIniciarDownloadRepos = new MetroFramework.Controls.MetroLink();
            this.btnSelecionarArquivo = new MetroFramework.Controls.MetroLink();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.painelNotificacao = new MetroFramework.Controls.MetroPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.btnUpdate = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblGitStatus = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.listBox1);
            this.metroPanel1.Controls.Add(this.mtTotal);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel1.Size = new System.Drawing.Size(210, 354);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 248);
            this.listBox1.TabIndex = 5;
            // 
            // mtTotal
            // 
            this.mtTotal.ActiveControl = null;
            this.mtTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtTotal.Enabled = false;
            this.mtTotal.Location = new System.Drawing.Point(5, 305);
            this.mtTotal.Name = "mtTotal";
            this.mtTotal.Size = new System.Drawing.Size(198, 42);
            this.mtTotal.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtTotal.TabIndex = 4;
            this.mtTotal.Text = "Total 0";
            this.mtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtTotal.TileImage = ((System.Drawing.Image)(resources.GetObject("mtTotal.TileImage")));
            this.mtTotal.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtTotal.UseSelectable = true;
            this.mtTotal.UseStyleColors = true;
            this.mtTotal.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(5, 5);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(198, 52);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Repositórios";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.pictureBox3);
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.metroTile7);
            this.metroPanel2.Controls.Add(this.btnSelecionarLocaldownload);
            this.metroPanel2.Controls.Add(this.metroTile6);
            this.metroPanel2.Controls.Add(this.metroTile4);
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Controls.Add(this.btnIniciarDownloadRepos);
            this.metroPanel2.Controls.Add(this.btnSelecionarArquivo);
            this.metroPanel2.Controls.Add(this.metroTile2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(230, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.metroPanel2.Size = new System.Drawing.Size(311, 354);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GitClone.Properties.Resources.error_48px;
            this.pictureBox3.Location = new System.Drawing.Point(260, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GitClone.Properties.Resources.error_48px;
            this.pictureBox2.Location = new System.Drawing.Point(260, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GitClone.Properties.Resources.error_48px;
            this.pictureBox1.Location = new System.Drawing.Point(260, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Enabled = false;
            this.metroTile7.Location = new System.Drawing.Point(8, 225);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(296, 41);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile7.TabIndex = 12;
            this.metroTile7.Text = "Passo 3";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile7.UseSelectable = true;
            // 
            // btnSelecionarLocaldownload
            // 
            this.btnSelecionarLocaldownload.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarLocaldownload.Image")));
            this.btnSelecionarLocaldownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarLocaldownload.ImageSize = 24;
            this.btnSelecionarLocaldownload.Location = new System.Drawing.Point(8, 191);
            this.btnSelecionarLocaldownload.Name = "btnSelecionarLocaldownload";
            this.btnSelecionarLocaldownload.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSelecionarLocaldownload.NoFocusImage")));
            this.btnSelecionarLocaldownload.Size = new System.Drawing.Size(246, 28);
            this.btnSelecionarLocaldownload.TabIndex = 11;
            this.btnSelecionarLocaldownload.Text = "Selecionar local de download";
            this.toolTip1.SetToolTip(this.btnSelecionarLocaldownload, "Local onde ficará os repositórios baixados.");
            this.btnSelecionarLocaldownload.UseSelectable = true;
            this.btnSelecionarLocaldownload.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Enabled = false;
            this.metroTile6.Location = new System.Drawing.Point(8, 144);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(296, 41);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile6.TabIndex = 10;
            this.metroTile6.Text = "Passo 2";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile6.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Enabled = false;
            this.metroTile4.Location = new System.Drawing.Point(8, 63);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(296, 41);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile4.TabIndex = 9;
            this.metroTile4.Text = "Passo 1";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile4.UseSelectable = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.mtProgress);
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(5, 305);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(299, 42);
            this.metroPanel3.TabIndex = 8;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // mtProgress
            // 
            this.mtProgress.ActiveControl = null;
            this.mtProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtProgress.Enabled = false;
            this.mtProgress.Location = new System.Drawing.Point(43, 0);
            this.mtProgress.Name = "mtProgress";
            this.mtProgress.Size = new System.Drawing.Size(256, 42);
            this.mtProgress.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtProgress.TabIndex = 9;
            this.mtProgress.Text = "0 / 0";
            this.mtProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtProgress.TileImage = ((System.Drawing.Image)(resources.GetObject("mtProgress.TileImage")));
            this.mtProgress.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtProgress.UseSelectable = true;
            this.mtProgress.UseStyleColors = true;
            this.mtProgress.UseTileImage = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroProgressSpinner1);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(43, 42);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.metroProgressSpinner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(43, 42);
            this.metroProgressSpinner1.Spinning = false;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressSpinner1.TabIndex = 2;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner1.UseCustomBackColor = true;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.UseStyleColors = true;
            // 
            // btnIniciarDownloadRepos
            // 
            this.btnIniciarDownloadRepos.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarDownloadRepos.Image")));
            this.btnIniciarDownloadRepos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarDownloadRepos.ImageSize = 24;
            this.btnIniciarDownloadRepos.Location = new System.Drawing.Point(8, 272);
            this.btnIniciarDownloadRepos.Name = "btnIniciarDownloadRepos";
            this.btnIniciarDownloadRepos.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarDownloadRepos.NoFocusImage")));
            this.btnIniciarDownloadRepos.Size = new System.Drawing.Size(246, 26);
            this.btnIniciarDownloadRepos.TabIndex = 6;
            this.btnIniciarDownloadRepos.Text = "      Iniciar download dos repositórios";
            this.toolTip1.SetToolTip(this.btnIniciarDownloadRepos, "Iniciar download.");
            this.btnIniciarDownloadRepos.UseSelectable = true;
            this.btnIniciarDownloadRepos.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarArquivo.Image")));
            this.btnSelecionarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarArquivo.ImageSize = 24;
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(8, 110);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSelecionarArquivo.NoFocusImage")));
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(246, 28);
            this.btnSelecionarArquivo.TabIndex = 4;
            this.btnSelecionarArquivo.Text = "Selecionar arquivo";
            this.toolTip1.SetToolTip(this.btnSelecionarArquivo, "Selecione o arquivo txt contendo os links de repositórios para realizar o downloa" +
        "d.\r\n Cada link deve estar em uma única linha deste arquivo.\r\n         ** O arqui" +
        "vo deve conter apenas link **\r\n");
            this.btnSelecionarArquivo.UseSelectable = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile2.Enabled = false;
            this.metroTile2.Location = new System.Drawing.Point(5, 5);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(299, 52);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Opções";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            // 
            // painelNotificacao
            // 
            this.painelNotificacao.HorizontalScrollbarBarColor = true;
            this.painelNotificacao.HorizontalScrollbarHighlightOnWheel = false;
            this.painelNotificacao.HorizontalScrollbarSize = 10;
            this.painelNotificacao.Location = new System.Drawing.Point(416, 28);
            this.painelNotificacao.Name = "painelNotificacao";
            this.painelNotificacao.Size = new System.Drawing.Size(125, 29);
            this.painelNotificacao.TabIndex = 2;
            this.painelNotificacao.VerticalScrollbarBarColor = true;
            this.painelNotificacao.VerticalScrollbarHighlightOnWheel = false;
            this.painelNotificacao.VerticalScrollbarSize = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(117, 414);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 17;
            this.metroToggle1.Text = "Off";
            this.toolTip1.SetToolTip(this.metroToggle1, "Use se voce tiver muitos repositórios para baixar,\r\nEssa opção usa bastante recur" +
        "so do computador.");
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageSize = 18;
            this.btnUpdate.Location = new System.Drawing.Point(230, 416);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.NoFocusImage")));
            this.btnUpdate.Size = new System.Drawing.Size(141, 15);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Baixar atualização Git";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnUpdate, "Iniciar download.");
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.ImageSize = 15;
            this.metroLink1.Location = new System.Drawing.Point(523, 416);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.NoFocusImage")));
            this.metroLink1.Size = new System.Drawing.Size(18, 15);
            this.metroLink1.TabIndex = 19;
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.metroLink1, "Verificar se tem atualização para Git.");
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // lblGitStatus
            // 
            this.lblGitStatus.AutoSize = true;
            this.lblGitStatus.Location = new System.Drawing.Point(3, 418);
            this.lblGitStatus.Name = "lblGitStatus";
            this.lblGitStatus.Size = new System.Drawing.Size(35, 13);
            this.lblGitStatus.TabIndex = 18;
            this.lblGitStatus.Text = "label1";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(377, 418);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(134, 13);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroProgressBar1.TabIndex = 20;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 434);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblGitStatus);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.painelNotificacao);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(561, 434);
            this.MinimumSize = new System.Drawing.Size(561, 434);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Git download";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile mtTotal;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink btnIniciarDownloadRepos;
        private MetroFramework.Controls.MetroLink btnSelecionarArquivo;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroPanel painelNotificacao;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile mtProgress;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroLink btnSelecionarLocaldownload;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblGitStatus;
        private MetroFramework.Controls.MetroLink btnUpdate;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}

