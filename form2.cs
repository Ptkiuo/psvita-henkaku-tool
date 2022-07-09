using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSVita_henkaku_変革_ツール
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            label2.Text = progressBar1.Value+"%";
            button1.Enabled = false;
            button2.Visible = true;
            label1.Text = "ドライバのインストールが終了したら\n完了ボタンをクリックしてください";
            System.Diagnostics.Process p =
    System.Diagnostics.Process.Start("361hen\\Qcma\\qcma.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 30;
            label2.Text = progressBar1.Value + "%";
            button1.Visible = false;
            button2.Visible = false;
            label1.Text = "PSVitaとpcをusb接続してください\n接続したら導入ボタンをクリックしてください";
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            label2.Text = progressBar1.Value + "%";
            scsse.Visible = true;
            button3.Enabled = false;
            System.Diagnostics.Process.Start("361hen\\FinalHE.exe");
            label1.Text = "起動したアプリに従ってインストールしてください\n完了したら完了ボタンを押してください";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            label2.Text = progressBar1.Value + "%";
            scsse.Enabled = false;
            button3.Visible = false;
            
            label1.Text = "導入が完了しました！";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;


        }
    }
}
