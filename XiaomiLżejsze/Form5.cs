using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace XiaomiLżejsze
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments  = "devices";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1F9ZTSUsLatxusPe0WsIAqDHhyIVNKstY/view?usp=sharing");
        }
    }
}
