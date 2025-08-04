﻿using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BussinessLayer.Concrete
{
    public class OrderManager : IOrderService

    {
        public readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Delete(Order entity)
        {
            _orderDal.Delete(entity);       
        }


        public List<Order> GetAll()
        {
           return _orderDal.GetAll();
        }

        public Order GetById(int id)
        {
          return _orderDal.GetById(id);
        }

        public void Insert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void Update(Order entity)
        {
           _orderDal.Update(entity);
        }
    }
}
