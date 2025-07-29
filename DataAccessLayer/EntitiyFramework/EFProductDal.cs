using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using DataAccessLayer.Abstract;


namespace DataAccessLayer.EntitiyFramework
{
    internal class EFProductDal: GenericRepository<EntityLayer.Concrete.Product>, DataAccessLayer.Abstract.IProductDal
    {
    }
}
