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
    public class ProizvodBusiness : IProizvodBusiness 
    {
        private readonly ProizvodRepository proizvodRepository;
        public ProizvodBusiness()
        {
            this.proizvodRepository = new ProizvodRepository();
        }

        public List<Proizvod> GetAllProducts()
        {
            return this.proizvodRepository.GetAllProducts();
        }

        public bool InsertProduct(Proizvod p)
        {
            if (this.proizvodRepository.InsertProduct(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(Proizvod p)
        {
            if (this.proizvodRepository.UpdateProduct(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(Proizvod p)
        {
            if (this.proizvodRepository.DeleteProduct(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
