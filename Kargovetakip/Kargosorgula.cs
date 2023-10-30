using Business.Abstract;
using Business.DependecyResolvers;
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
    public partial class Kargosorgula : Form
    {
        public Kargosorgula()
        {

            InitializeComponent();
            _IKargoService = InstanceFactory.GetInstance<IKargoService>();
        }
        IKargoService _IKargoService;

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }

        private void Kargosorgula_Load(object sender, EventArgs e)
        {
            LoadKargo();
 
        }
        private void LoadKargo()
        {
            dgwkargo.DataSource = _IKargoService.GetAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
               LoadKargo();
            }
            else
            {
                dgwkargo.DataSource = _IKargoService.GetKargoByTakipno(textBox1.Text);
            }
        }

        private void dgwkargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
