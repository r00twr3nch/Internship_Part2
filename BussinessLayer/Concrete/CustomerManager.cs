using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;


namespace BussinessLayer.Concrete
{
    public class CustomerManager : ICustomerDal
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public string customerName => throw new NotImplementedException();

        public object CustomerName => throw new NotImplementedException();

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();   
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void Insert(Customer entity)
        {
            _customerDal.Insert(entity);
        }


        public void Update(Customer entity)
        {
          _customerDal.Update(entity);
        }
    }
}
