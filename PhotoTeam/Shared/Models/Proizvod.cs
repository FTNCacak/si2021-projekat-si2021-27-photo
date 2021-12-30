using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Proizvod
    {
        public int sifra_proizvoda { get; set; }
        public string naziv { get; set; }
        public string marka { get; set; }
        public decimal cena { get; set; }
        public int garancija { get; set; }
    }
}
