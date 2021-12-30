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
    public class PorucivanjeBusiness : IPorucivanjeBusiness
    {
        private readonly PorucivanjeRepository porucivanjeRepository;
        public PorucivanjeBusiness()
        {
            this.porucivanjeRepository = new PorucivanjeRepository();
        }

        public List<Porucivanje> GetAllOrders()
        {
            return this.porucivanjeRepository.GetAllOrders();
        }

        public bool InsertOrder(Porucivanje p)
        {
            if (this.porucivanjeRepository.InsertOrder(p) > 0)
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
