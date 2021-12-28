using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Kupac
    {
        public int id_kupca { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }
        public string broj_telefona { get; set; }
    }
}
