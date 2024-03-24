
namespace AutoBackup
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblProgress = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnSelOrigem = new System.Windows.Forms.Button();
            this.btnSelBackup = new System.Windows.Forms.Button();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.chbBackupAutomatico = new System.Windows.Forms.CheckBox();
            this.btnBackupAgora = new System.Windows.Forms.Button();
            this.chbMostrarCmd = new System.Windows.Forms.CheckBox();
            this.lblTextLogo = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 180);
            this.pBar.Maximum = 10;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(365, 23);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(44, 164);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(24, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "0/0";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 5;
            this.hScrollBar1.Location = new System.Drawing.Point(13, 160);
            this.hScrollBar1.Maximum = 600;
            this.hScrollBar1.Minimum = 5;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(28, 17);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btnSelOrigem
            // 
            this.btnSelOrigem.Location = new System.Drawing.Point(211, 151);
            this.btnSelOrigem.Name = "btnSelOrigem";
            this.btnSelOrigem.Size = new System.Drawing.Size(166, 23);
            this.btnSelOrigem.TabIndex = 4;
            this.btnSelOrigem.Text = "Selecionar pasta de origem";
            this.btnSelOrigem.UseVisualStyleBackColor = true;
            this.btnSelOrigem.Click += new System.EventHandler(this.btnSelOrigem_Click);
            // 
            // btnSelBackup
            // 
            this.btnSelBackup.Location = new System.Drawing.Point(211, 89);
            this.btnSelBackup.Name = "btnSelBackup";
            this.btnSelBackup.Size = new System.Drawing.Size(166, 23);
            this.btnSelBackup.TabIndex = 5;
            this.btnSelBackup.Text = "Selecionar pasta para backup";
            this.btnSelBackup.UseVisualStyleBackColor = true;
            this.btnSelBackup.Click += new System.EventHandler(this.btnSelBackup_Click);
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(208, 135);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(16, 13);
            this.lblOrigem.TabIndex = 6;
            this.lblOrigem.Text = "---";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(208, 73);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(16, 13);
            this.lblBackup.TabIndex = 7;
            this.lblBackup.Text = "---";
            // 
            // chbBackupAutomatico
            // 
            this.chbBackupAutomatico.AutoSize = true;
            this.chbBackupAutomatico.Location = new System.Drawing.Point(13, 144);
            this.chbBackupAutomatico.Name = "chbBackupAutomatico";
            this.chbBackupAutomatico.Size = new System.Drawing.Size(119, 17);
            this.chbBackupAutomatico.TabIndex = 8;
            this.chbBackupAutomatico.Text = "Backup Automatico";
            this.chbBackupAutomatico.UseVisualStyleBackColor = true;
            this.chbBackupAutomatico.CheckedChanged += new System.EventHandler(this.chbBackupAutomatico_CheckedChanged);
            // 
            // btnBackupAgora
            // 
            this.btnBackupAgora.Location = new System.Drawing.Point(12, 89);
            this.btnBackupAgora.Name = "btnBackupAgora";
            this.btnBackupAgora.Size = new System.Drawing.Size(176, 23);
            this.btnBackupAgora.TabIndex = 9;
            this.btnBackupAgora.Text = "Backup agora";
            this.btnBackupAgora.UseVisualStyleBackColor = true;
            this.btnBackupAgora.Click += new System.EventHandler(this.btnBackupAgora_Click);
            // 
            // chbMostrarCmd
            // 
            this.chbMostrarCmd.AutoSize = true;
            this.chbMostrarCmd.Checked = true;
            this.chbMostrarCmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMostrarCmd.Location = new System.Drawing.Point(12, 119);
            this.chbMostrarCmd.Name = "chbMostrarCmd";
            this.chbMostrarCmd.Size = new System.Drawing.Size(88, 17);
            this.chbMostrarCmd.TabIndex = 10;
            this.chbMostrarCmd.Text = "Mostrar CMD";
            this.chbMostrarCmd.UseVisualStyleBackColor = true;
            this.chbMostrarCmd.CheckedChanged += new System.EventHandler(this.chbMostrarCmd_CheckedChanged);
            // 
            // lblTextLogo
            // 
            this.lblTextLogo.AutoSize = true;
            this.lblTextLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblTextLogo.Location = new System.Drawing.Point(99, 9);
            this.lblTextLogo.Name = "lblTextLogo";
            this.lblTextLogo.Size = new System.Drawing.Size(242, 47);
            this.lblTextLogo.TabIndex = 11;
            this.lblTextLogo.Text = "AutoBackup";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(104, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By Renan Andrade (Github)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTextLogo);
            this.Controls.Add(this.chbMostrarCmd);
            this.Controls.Add(this.btnBackupAgora);
            this.Controls.Add(this.chbBackupAutomatico);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.btnSelBackup);
            this.Controls.Add(this.btnSelOrigem);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoBackup by Renan Andrade";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnSelOrigem;
        private System.Windows.Forms.Button btnSelBackup;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.CheckBox chbBackupAutomatico;
        private System.Windows.Forms.Button btnBackupAgora;
        private System.Windows.Forms.CheckBox chbMostrarCmd;
        private System.Windows.Forms.Label lblTextLogo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

