using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KupacBusiness : IKupacBusiness
    {
        private readonly KupacRepository kupacRepository;
        public KupacBusiness()
        {
            this.kupacRepository = new KupacRepository();
        }

        public List<Proizvod> GetAllProducts()
        {
            return this.kupacRepository.GetAllProducts();
        }
    }
}
