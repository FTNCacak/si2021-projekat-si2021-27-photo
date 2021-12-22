using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormaProdavac : Form
    {
        private readonly ProizvodBusiness proizvodBusiness;
        public FormaProdavac()
        {
            this.proizvodBusiness = new ProizvodBusiness();
            InitializeComponent();
        }

        private void FormaProdavac_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            List<Proizvod> listaProizvoda = this.proizvodBusiness.GetAllProducts();
            dataGridView_Proizvod.DataSource = listaProizvoda;
            dataGridView_Proizvod.Columns["sifra_proizvoda"].Visible = false;
        }
    }
}
