using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPhoto
{
    public partial class WebKupac : System.Web.UI.Page
    {
        private readonly ProizvodBusiness proizvodBusiness;
        private readonly KupacBusiness kupacBusiness;
        private readonly PorucivanjeBusiness porucivanjeBusiness;


        public WebKupac()
        {
            this.proizvodBusiness = new ProizvodBusiness();
            this.kupacBusiness = new KupacBusiness();
            this.porucivanjeBusiness = new PorucivanjeBusiness();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        
        protected void RefreshData()
        {
            List<Proizvod> listaProizvoda = this.proizvodBusiness.GetAllProducts();
            ListBoxProizvodiWeb.Items.Clear();
            foreach (Proizvod p in listaProizvoda)
            {
                ListBoxProizvodiWeb.Items.Add(string.Format("{0} - {1} - {2} {3}", p.sifra_proizvoda,p.naziv, p.marka, p.cena));
            }
        }
   
        protected void ListBoxProizvodiWeb_SelectedIndexChanged(object sender, EventArgs e)
        {

       }

        protected void ButtonDodaj_Click(object sender, EventArgs e)
        {
            List<Proizvod> listaProizvoda = this.proizvodBusiness.GetAllProducts();
            bool tacno = false;
            foreach(Proizvod p in listaProizvoda)
            {
                if (p.sifra_proizvoda.ToString()==TextBoxSifraProizvoda.Text)
                {
                    ListBox_Korpa.Items.Add(p.sifra_proizvoda+"-"+p.naziv+"|");
                    tacno = true;
                }
                   
            }
            string greska = "Proizvod sa tom sifrom ne postoji!";
            if (tacno == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + greska + "');", true);
            }
        }

        protected void Button_Ocisti_Click(object sender, EventArgs e)
        {
            ListBox_Korpa.Items.Clear();
        }

        protected void Button_Poruci_Click(object sender, EventArgs e)
        {
            Kupac k = new Kupac();
            k.ime = TextBox_Ime.Text;
            k.prezime = TextBox_Prezime.Text;
            k.email = TextBox_Email.Text;
            k.broj_telefona = TextBox_BrTelefona.Text;


            // kada se poruce proizvodi, upisujemo podatke u tabelu PORUCIVANJA

            Porucivanje p = new Porucivanje();

            p.sifraP = Convert.ToInt32(TextBoxSifraProizvoda.Text);
            foreach(Proizvod pr in proizvodBusiness.GetAllProducts())
            {
                if(pr.sifra_proizvoda==p.sifraP)
                {
                    p.naziv_proizvoda = pr.naziv;
                }
            }


            if (this.kupacBusiness.InsertCustomer(k) && this.porucivanjeBusiness.InsertOrder(p))
            {
                string poruka = "Uspešno ste poručili proizvod!";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + poruka + "');", true);
            }
            else
            {
                string porukaNeuspeh = "Nespešno poručivanje! Pokušajte ponovo!";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + porukaNeuspeh + "');", true);
            }



        }
    }
}