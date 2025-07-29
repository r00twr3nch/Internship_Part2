using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;


namespace DataAccessLayer.EntitiyFramework
{
    internal class EFOrderDal: GenericRepository<EntityLayer.Concrete.Order>, DataAccessLayer.Abstract.IOrderDal
    {

    }
}
