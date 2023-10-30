using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kargovetakip
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == "ADMİN" && textBox2.Text == "1234")
            {

                PersonelKayıt fr = new PersonelKayıt();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız !!!");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
          Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
