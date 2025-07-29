using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    internal class CustomerManager : ICustomerService
    {
        public string customerName => throw new NotImplementedException();

        public object CustomerName => throw new NotImplementedException();

        public void Delete(ICustomerService entity)
        {
            throw new NotImplementedException();
        }

        public List<ICustomerService> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICustomerService GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ICustomerService entity)
        {
        }

        public void Update(ICustomerService entity)
        {
            throw new NotImplementedException();
        }
    }
}
