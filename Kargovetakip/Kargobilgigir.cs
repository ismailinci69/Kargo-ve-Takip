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
    public partial class Kargobilgigir : Form
    {
        public Kargobilgigir()
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
                _IMusteriService.Add(new Musteri
                {
                     AdSoyad= textBox1.Text,
                     TC = textBox2.Text,
                     TelNo= maskedTextBox1.Text
       
                } );

                _IKargoService.Add(new Kargo
                {
                    AlıcıAdSoyad = textBox4.Text,
                    AlıcıAdres = textBox5.Text,
                   AlıcıTelNo = maskedTextBox2.Text,
                   Durum=comboBox1.Text,
                   Kabultarihi=Convert.ToDateTime(dateTimePicker1.Text),
                   Takipno=textBox7.Text,
                   
                });

MessageBox.Show("kayıt başarı ile yapıldı");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void Kargobilgigir_Load(object sender, EventArgs e)
        {

        }
    }
}
