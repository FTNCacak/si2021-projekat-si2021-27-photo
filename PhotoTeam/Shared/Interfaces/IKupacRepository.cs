using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IKupacRepository
    {
        List<Proizvod> GetAllProducts();

        int InsertCustomer(Kupac k);
    }
}
