using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
                ListBoxProizvodiWeb.Items.Add(string.Format("{0} - {1} - {2} | cena:{3}", p.sifra_proizvoda,p.naziv, p.marka, p.cena));
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
                    ListBox_Korpa.Items.Add(p.sifra_proizvoda+"-"+p.naziv);
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
            if (TextBoxSifraProizvoda.Text == "" || TextBox_Ime.Text == "" || TextBox_Prezime.Text == "" || TextBox_Email.Text == "" || TextBox_Adresa.Text == "" || TextBox_BrTelefona.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Morate popuniti sva polja!');", true);
            }

            //Proveriti da li je ime tacno uneto (prvo slovo veliko, ostala mala)

            if (!Regex.Match(TextBox_Ime.Text, @"^[A-Z][a-z]*$").Success)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Ime nije pravilno uneto!');", true);
            }

            //Proveriti da li je ime tacno uneto (prvo slovo veliko, ostala mala)

            if (!Regex.Match(TextBox_Prezime.Text, "^[A-Z][a-z]*$").Success)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Prezime nije pravilno uneto!');", true);
            }

            //Proveriti da li je email tacno unet
            if (!Regex.Match(TextBox_Email.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$").Success)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Email nije pravilno unet!');", true);
            }
            //Proveriti da li je adresa pravilno uneta(bar jedna ili dve reci,bar jedan razmak,bar jedna cifra)
            if (!Regex.Match(TextBox_Adresa.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z])+\s[0-9]+$").Success)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Adresa nije pravilno uneta!');", true);
            }

            //Proveriti da li je broj telefona pravilno unet(bar jedna ili dve reci,bar jedan razmak,bar jedna cifra)
            if (!Regex.Match(TextBox_BrTelefona.Text, @"^[0][6]\d{1}/[1-9]\d{2,3}-\d{3,4}$").Success)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Broj nije pravilno unet!');", true);
            }

            if (ListBox_Korpa.Items.Count ==0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Morate dodati neki proizvod u korpu!');", true);
            }

            Kupac k = new Kupac();
            k.ime = TextBox_Ime.Text;
            k.prezime = TextBox_Prezime.Text;
            k.email = TextBox_Email.Text;
            k.adresa = TextBox_Adresa.Text;
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