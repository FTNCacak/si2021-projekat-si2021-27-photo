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
        private readonly PorucivanjeBusiness porucivanjeBusiness;
        public FormaProdavac()
        {
            this.proizvodBusiness = new ProizvodBusiness();
            this.porucivanjeBusiness = new PorucivanjeBusiness();
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
          
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            Proizvod p = new Proizvod();
            p.naziv = textBox_Naziv.Text;
            p.marka = textBox_Marka.Text;
            p.cena = Convert.ToDecimal(textBox_Cena.Text);
            p.garancija = Convert.ToInt32(textBox_Garancija.Text);

            if (this.proizvodBusiness.InsertProduct(p))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste uneli podatke! ", MessageBoxIcon.Information.ToString());
                textBox_Naziv.Clear();
                textBox_Marka.Clear();
                textBox_Cena.Clear();
                textBox_Garancija.Clear();
            }
            else
            {
                MessageBox.Show("Neuspesan unos podataka!", MessageBoxIcon.Error.ToString());
            }
        }

        int ID; //globalna promenljiva za citanje id-a svakog reda
        private void dataGridView_Proizvod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView_Proizvod.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox_Naziv.Text = dataGridView_Proizvod.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_Marka.Text = dataGridView_Proizvod.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_Cena.Text = dataGridView_Proizvod.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox_Garancija.Text = dataGridView_Proizvod.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button_Izmeni_Click(object sender, EventArgs e)
        {
            Proizvod p = new Proizvod();
            p.naziv = textBox_Naziv.Text;
            p.marka = textBox_Marka.Text;
            p.cena = Convert.ToDecimal(textBox_Cena.Text);
            p.garancija = Convert.ToInt32(textBox_Garancija.Text);

            p.sifra_proizvoda = ID;

            if (this.proizvodBusiness.UpdateProduct(p))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste izmenili podatke! ", MessageBoxIcon.Information.ToString());
                textBox_Naziv.Clear();
                textBox_Marka.Clear();
                textBox_Cena.Clear();
                textBox_Garancija.Clear();
            }
            else
            {
                MessageBox.Show("Neuspesna izmena podataka!", MessageBoxIcon.Error.ToString());
            }
        }

        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            Proizvod p = new Proizvod();
            p.naziv = textBox_Naziv.Text;
            p.marka = textBox_Marka.Text;
            p.cena = Convert.ToDecimal(textBox_Cena.Text);
            p.garancija = Convert.ToInt32(textBox_Garancija.Text);

            p.sifra_proizvoda = ID;

            if (this.proizvodBusiness.DeleteProduct(p))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste obrisali podatak! ", MessageBoxIcon.Information.ToString());
                textBox_Naziv.Clear();
                textBox_Marka.Clear();
                textBox_Cena.Clear();
                textBox_Garancija.Clear();
            }
            else
            {
                MessageBox.Show("Niste obrisali podatak!", MessageBoxIcon.Error.ToString());
            }
        }

        private void button_Osvezi_Click(object sender, EventArgs e)
        {
            List<Porucivanje> listaPorucenihProizvoda = this.porucivanjeBusiness.GetAllOrders();
            dataGridView_PoruceniProizvodi.DataSource = listaPorucenihProizvoda;
            dataGridView_PoruceniProizvodi.Columns["id_porucivanja"].Visible = false;
        }
    }
}
