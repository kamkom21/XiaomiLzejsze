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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.android.browser";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.miui.player";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.xiaomi.midrop";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.google.android.youtube";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.google.android.videos";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.google.android.apps.tachyon";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.miui.weather2";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.mi.android.globalFileexplorer";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.miui.videoplayer";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.mipay.wallet.id";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
            Process diag1 = new Process();
            diag1.StartInfo.FileName = "adb.exe";
            diag1.StartInfo.UseShellExecute = false;
            diag1.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.mipay.wallet.in";
            diag1.StartInfo.RedirectStandardOutput = true;
            diag1.Start();
            textBox1.Text = diag1.StandardOutput.ReadToEnd();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.miui.notes";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process diag = new Process();
            diag.StartInfo.FileName = "adb.exe";
            diag.StartInfo.UseShellExecute = false;
            diag.StartInfo.Arguments = "shell pm uninstall -k --user 0 com.google.android.music";
            diag.StartInfo.RedirectStandardOutput = true;
            diag.Start();
            textBox1.Text = diag.StandardOutput.ReadToEnd();
        }
    }
}
