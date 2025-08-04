using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    internal interface ICustomerService : Abstract.IGenericService<ICustomerService>
    {
        string customerName { get; }
        object CustomerName { get; }
    }
}
