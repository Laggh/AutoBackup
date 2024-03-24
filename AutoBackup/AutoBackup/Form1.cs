using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AutoBackup
{
    public partial class Form1 : Form
    {
        string originFolder;
        string backupFolder;
        bool autoBackup;
        bool mostrarCmd = true;
        void executeCmd(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.CreateNoWindow = !mostrarCmd;
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.UseShellExecute = false;

            process.Start();
            process.WaitForExit();
            process.Close();

        }
        void copyInto(string origin,string backup)
        {
            pBar.Value = 0;
            if (!Directory.Exists(origin))
            {
                MessageBox.Show("Diretorio de origem não existe", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(backup))
            {
                MessageBox.Show("Diretorio para origem não existe", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strCmdText;
            strCmdText = "xcopy /s /e /y " + origin + " " + backup;
            // System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            executeCmd(strCmdText);

        }
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string folder = folderBrowserDialog1.SelectedPath;
            MessageBox.Show(folder);
            string strCmdText;
            strCmdText = "/C xcopy /s /e D:\\PW2 D:\\PW3";
            Process.Start("CMD.exe", strCmdText);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!autoBackup){ return; }

            pBar.PerformStep();
            lblProgress.Text =  pBar.Value.ToString() + "/" + pBar.Maximum.ToString();

            if (pBar.Value >= pBar.Maximum)
            {
                copyInto(originFolder, backupFolder);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pBar.Maximum = hScrollBar1.Value;
            lblProgress.Text = pBar.Value.ToString() + "/" + pBar.Maximum.ToString();
        }

        private void btnSelOrigem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            originFolder = folderBrowserDialog1.SelectedPath;
            lblOrigem.Text = originFolder;
        }

        private void btnSelBackup_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            backupFolder = folderBrowserDialog1.SelectedPath;
            lblBackup.Text = backupFolder;
        }

        private void chbBackupAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            autoBackup = chbBackupAutomatico.Checked;
        }
        private void chbMostrarCmd_CheckedChanged(object sender, EventArgs e)
        {
            mostrarCmd = chbMostrarCmd.Checked;
        }
        private void btnBackupAgora_Click(object sender, EventArgs e)
        {
            copyInto(originFolder, backupFolder);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            executeCmd("start https://github.com/Laggh");
        }
    }
}
