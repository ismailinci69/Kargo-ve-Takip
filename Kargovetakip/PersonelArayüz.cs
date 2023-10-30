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
    public partial class PersonelArayüz : Form
    {
        public PersonelArayüz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Kargobilgilerigüncelle fr = new Kargobilgilerigüncelle();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Kargobilgigir fr = new Kargobilgigir();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
