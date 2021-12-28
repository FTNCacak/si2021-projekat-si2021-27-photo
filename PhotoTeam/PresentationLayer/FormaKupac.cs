using BusinessLayer;
using Shared.Models;
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

namespace PresentationLayer
{
    public partial class FormaKupac : Form
    {
        private readonly KupacBusiness kupacBusiness;
        public FormaKupac()
        {
            this.kupacBusiness = new KupacBusiness();
            InitializeComponent();
        }

        private void FormaKupac_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            List<Proizvod> listaProizvoda = this.kupacBusiness.GetAllProducts();
            dataGridView_ListaDostupnihProizvoda.DataSource = listaProizvoda;
            dataGridView_ListaDostupnihProizvoda.Columns["sifra_proizvoda"].Visible = false;
        }

        private void button_Kupovina_Click(object sender, EventArgs e)
        {
            string URL = "https://localhost:44395/";
            System.Diagnostics.Process.Start(URL);
        }

        private void button_Izadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
