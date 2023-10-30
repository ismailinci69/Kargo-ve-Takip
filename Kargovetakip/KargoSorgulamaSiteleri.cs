using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargovetakip
{
    public partial class KargoSorgulamaSiteleri : Form
    {
        public KargoSorgulamaSiteleri()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://gonderitakip.ptt.gov.tr/";
            Process.Start(url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://kargotakip.araskargo.com.tr/Tracking.aspx";
            Process.Start(url);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.mngkargo.com.tr/gonderitakip";
            Process.Start(url);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://suratkargo.com.tr/KargoTakip/";
            Process.Start(url);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.yurticikargo.com/";
            Process.Start(url);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
