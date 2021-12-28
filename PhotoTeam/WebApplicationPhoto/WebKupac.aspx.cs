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

        public WebKupac()
        {
            this.proizvodBusiness = new ProizvodBusiness();
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
                    ListBox_Korpa.Items.Add(p.sifra_proizvoda+" - "+p.naziv);
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
    }
}