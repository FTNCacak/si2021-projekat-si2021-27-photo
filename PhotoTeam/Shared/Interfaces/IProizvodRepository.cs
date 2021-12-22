using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IProizvodRepository
    {
        List<Proizvod> GetAllProducts();
        int InsertProduct(Proizvod p);
        int UpdateProduct(Proizvod p);
        int DeleteProduct(Proizvod p);
    }
}
