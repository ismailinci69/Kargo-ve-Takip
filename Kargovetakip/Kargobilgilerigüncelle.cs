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
    public partial class Kargobilgilerigüncelle : Form
    {
        public Kargobilgilerigüncelle()
        {
            InitializeComponent();
            _IKargoService = InstanceFactory.GetInstance<IKargoService>();
            _IMusteriService = InstanceFactory.GetInstance<IMusteriService>();
        }
        IKargoService _IKargoService;
        IMusteriService _IMusteriService;
        private void button2_Click(object sender, EventArgs e)
        {
           PersonelArayüz fr = new PersonelArayüz();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _IKargoService.Update(new Kargo
                {
                    AlıcıAdSoyad = textBox4.Text,
                    AlıcıAdres = textBox5.Text,
                    AlıcıTelNo = maskedTextBox2.Text,
                    Durum = comboBox1.Text,
                });

                MessageBox.Show("kayıt başarı ile yapıldı");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
     
        }




        private void Kargobilgilerigüncelle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox7.Text))
            {

            }
            else
            {
                Kargo kargo = _IKargoService.Arama(textBox7.Text);
                textBox4.Text = kargo.AlıcıAdSoyad;
                textBox5.Text = kargo.AlıcıAdres;
                maskedTextBox2.Text = kargo.AlıcıTelNo;
                comboBox1.Text = kargo.Durum;
                dateTimePicker1.Text = kargo.Kabultarihi.ToString();
            }
        }
    }
}
