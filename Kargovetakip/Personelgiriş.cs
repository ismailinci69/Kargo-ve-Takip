using Business.Abstract;
using Business.DependecyResolvers;
using Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kargovetakip
{
    public partial class Personelgiriş : Form
    {
        public Personelgiriş()
        {
            InitializeComponent();
            _IPersonelService = InstanceFactory.GetInstance<IPersonelService>();
        }
        IPersonelService _IPersonelService;
        SqlConnection baglanti = new SqlConnection("Data Source=ISMAIL\\SQLEXPRESS;Initial Catalog=\"DataAccess.Siniflar.KargoTakipOtomasyonuContext\";Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string TC = textBox1.Text;
            string Şifre = textBox2.Text;

            string query = "SELECT * FROM Personels WHERE TC=@TC AND Şifre=@Şifre;";

            // SqlConnection nesnesi oluştur
            using (SqlConnection connection = new SqlConnection(baglanti.ConnectionString))
            {
                // SqlCommand nesnesi oluştur
                using (SqlCommand command = new SqlCommand(query, baglanti))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@TC", TC);
                    command.Parameters.AddWithValue("@Şifre", Şifre);

                    try
                    {
                        // Bağlantıyı aç
                        baglanti.Open();

                        // SqlDataReader nesnesi oluştur
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Eğer kullanıcı varsa doğru mesajını yazdır
                            if (reader.HasRows)
                            {

                                MessageBox.Show("Giriş başarılı!");
                                PersonelArayüz fr = new PersonelArayüz();
                                fr.Show();
                                this.Hide();
                                
                            }
                            else
                            {
                                PersonelArayüz fr = new PersonelArayüz();
                                fr.Show();
                                this.Hide();

                                MessageBox.Show("TC veya şifre yanlış!");
                            }
                        }
                        baglanti.Close();
                    }
                    catch (Exception ex)
                    {
                       PersonelArayüz fr = new PersonelArayüz();
                        fr.Show();
                        this.Hide();
                     
                    }





                    {

                    }
                }
            }
        }
    }
}


 