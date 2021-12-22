using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IProizvodBusiness
    {
        List<Proizvod> GetAllProducts();
        bool InsertProduct(Proizvod p);
        bool UpdateProduct(Proizvod p);
        bool DeleteProduct(Proizvod p);
    }
}
