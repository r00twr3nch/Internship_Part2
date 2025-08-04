using DataAccessLayer.Repositories;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepository, ICategoryDal
    {
        // ICategoryDal'ın gerektirdiği üyeleri burada implemente edin
        private readonly ICategoryDal _categoryDal;
        public EFCategoryDal(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Insert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
