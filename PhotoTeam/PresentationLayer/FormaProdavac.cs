using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (textBox_Naziv.Text == "" || textBox_Marka.Text == "" || textBox_Cena.Text == "" || textBox_Garancija.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Naziv.Focus();
                return;
            }

             // Proveriti da li je naziv tacno unet (tačno jedna ili dve reci)

            if (!Regex.Match(textBox_Naziv.Text,@"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Naziv nije pravilno unet!", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proveriti da li je marka tacno uneta(pocetno slovo malo ili veliko ostala mala ili velika
            // i moze sadrzati razmak i cifre)
           if (!Regex.Match(textBox_Marka.Text, @"^([a-zA-Z][a-zA-Z]*)+\s*\d*").Success)
           {
                MessageBox.Show("Marka nije pravilno uneta!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
            // Proveriti da li je cena tacno uneta(mora sadzati cifre, tacka nije obavezna)
            if (!Regex.Match(textBox_Cena.Text, @"\d$[.]*").Success)
            {
                MessageBox.Show("Cena nije pravilno uneta!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Proveriti da li je garancija tacno uneta(mora sadzati samo cifre, bez drugih karaktera,samo cele brojeve)
            if (!Regex.Match(textBox_Garancija.Text, "^[0-9]+$").Success)
            {
                MessageBox.Show("Garancija nije pravilno uneta!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proizvod p = new Proizvod();
            p.naziv = textBox_Naziv.Text;
            p.marka = textBox_Marka.Text;
            p.cena = Convert.ToDecimal(textBox_Cena.Text);
            p.garancija = Convert.ToInt32(textBox_Garancija.Text);

           

            if (this.proizvodBusiness.InsertProduct(p))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste uneli podatke! ","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox_Naziv.Clear();
                textBox_Marka.Clear();
                textBox_Cena.Clear();
                textBox_Garancija.Clear();
            }
            else
            {
                MessageBox.Show("Neuspesan unos podataka!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (textBox_Naziv.Text == "" || textBox_Marka.Text == "" || textBox_Cena.Text == "" || textBox_Garancija.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Naziv.Focus();
                return;
            }

            // Proveriti da li je naziv tacno unet (tačno jedna ili dve reci)

            if (!Regex.Match(textBox_Naziv.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Naziv nije pravilno unet!", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proveriti da li je marka tacno uneta(pocetno slovo malo ili veliko ostala mala ili velika
            // i moze sadrzati razmak i cifre)
            if (!Regex.Match(textBox_Marka.Text, @"^([a-zA-Z][a-zA-Z]*)+\s*\d*").Success)
            {
                MessageBox.Show("Marka nije pravilno uneta!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Proveriti da li je cena tacno uneta(mora sadzati cifre, tacka nije obavezna)
            if (!Regex.Match(textBox_Cena.Text, @"\d$[.]*").Success)
            {
                MessageBox.Show("Cena nije pravilno uneta!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Proveriti da li je garancija tacno uneta(mora sadzati samo cifre, bez drugih karaktera,samo cele brojeve)
            if (!Regex.Match(textBox_Garancija.Text, "^[0-9]+$").Success)
            {
                MessageBox.Show("Garancija nije pravilno uneta!", "Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proizvod p = new Proizvod();
            p.naziv = textBox_Naziv.Text;
            p.marka = textBox_Marka.Text;
            p.cena = Convert.ToDecimal(textBox_Cena.Text);
            p.garancija = Convert.ToInt32(textBox_Garancija.Text);

            p.sifra_proizvoda = ID;

            if (this.proizvodBusiness.UpdateProduct(p))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste izmenili podatke! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Naziv.Clear();
                textBox_Marka.Clear();
                textBox_Cena.Clear();
                textBox_Garancija.Clear();
            }
            else
            {
                MessageBox.Show("Neuspesna izmena podataka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            if (textBox_Naziv.Text == "" || textBox_Marka.Text == "" || textBox_Cena.Text == "" || textBox_Garancija.Text == "")
            {
                MessageBox.Show("Morate kliknuti na proizvod koji zelite da obrisete da bi se popunila sva polja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proizvod p = new Proizvod();
            p.naziv = textBox_Naziv.Text;
            p.marka = textBox_Marka.Text;
            p.cena = Convert.ToDecimal(textBox_Cena.Text);
            p.garancija = Convert.ToInt32(textBox_Garancija.Text);

            p.sifra_proizvoda = ID;

            if (this.proizvodBusiness.DeleteProduct(p))
            {
                RefreshData();
                MessageBox.Show("Uspesno ste obrisali podatak! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_Naziv.Clear();
                textBox_Marka.Clear();
                textBox_Cena.Clear();
                textBox_Garancija.Clear();
            }
            else
            {
                MessageBox.Show("Niste obrisali podatak!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
