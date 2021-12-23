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
    }
}