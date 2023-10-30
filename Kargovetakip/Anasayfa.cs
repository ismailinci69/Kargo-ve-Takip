
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kargovetakip
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kargosorgula fr = new Kargosorgula();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin fr = new Admin();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          Personelgiriş fr = new Personelgiriş();
            fr.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
         KargoSorgulamaSiteleri fr = new KargoSorgulamaSiteleri();
            fr.Show();
            this.Hide();
        }
    }
}
