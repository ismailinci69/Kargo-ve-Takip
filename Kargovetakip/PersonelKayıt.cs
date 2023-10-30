using Business.Abstract;
using Business.DependecyResolvers;
using Entities;
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
    public partial class PersonelKayıt : Form
    {
        public PersonelKayıt()
        {
            InitializeComponent();

            _IPersonelService = InstanceFactory.GetInstance<IPersonelService>();
        }
        IPersonelService _IPersonelService;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _IPersonelService.Add(new Personel
                {
       
                    AdSoyad = textBox1.Text,
                   TC = textBox2.Text,
                  Gmail    = textBox3.Text,
                    TelNo = textBox4.Text,
                    Şifre = textBox5.Text,
                });
                MessageBox.Show("kayıt başarı ile yapıldı");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin fr = new Admin();
            fr.Show();
            this.Hide();
        }

        private void PersonelKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
