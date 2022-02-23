using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._22_2BackgroundWorkerile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSay1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            if (btnSay1.Text == "Başla")
                btnSay1.Text = "Durdur";
            else
                btnSay1.Text = "Başla";
        }

        private void btnSay2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
            if (btnSay2.Text == "Başla")
                btnSay2.Text = "Durdur";
            else
                btnSay2.Text = "Başla";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (btnSay1.Text == "Durdur")
            {
                int sayi = Convert.ToInt32(tbSayi1.Text);
                tbSayi1.Text = Convert.ToString(sayi + 1);
                Thread.Sleep(1000);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (btnSay2.Text == "Durdur")
            {
                int sayi = Convert.ToInt32(tbSayi2.Text);
                tbSayi2.Text = Convert.ToString(sayi + 1);
                Thread.Sleep(1000);
            }
        }
    }
}
