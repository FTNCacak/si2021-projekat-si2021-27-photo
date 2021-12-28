using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IPorucivanjeRepository
    {
        List<Porucivanje> GetAllOrders();
        int InsertOrder(Porucivanje p);

    }
}
