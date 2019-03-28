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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.miui.msa.global";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
            Process diag2 = new Process();
            diag2.StartInfo.FileName = "adb.exe";
            diag2.StartInfo.UseShellExecute = false;
            diag2.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.xiaomi.discover";
            diag2.StartInfo.RedirectStandardOutput = true;
            diag2.Start();
            textBox1.Text = diag2.StandardOutput.ReadToEnd();
            Process diag3 = new Process();
            diag3.StartInfo.FileName = "adb.exe";
            diag3.StartInfo.UseShellExecute = false;
            diag3.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.miui.analytics";
            diag3.StartInfo.RedirectStandardOutput = true;
            diag3.Start();
            textBox1.Text = diag3.StandardOutput.ReadToEnd();
        }

    }
}
