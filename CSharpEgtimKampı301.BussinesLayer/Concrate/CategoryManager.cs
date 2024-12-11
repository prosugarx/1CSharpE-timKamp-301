using CSharpEgtimKampı301.BussinesLayer.Abstract;
using CSharpEğtimKampı301.DataAccessLayer.Abstarct;
using CSharpEğtimKampı301.EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgtimKampı301.BussinesLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        public readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(category entity)
        {
            _categoryDal.Delete(entity);
        }

        public category TGet(int id)
        {
            return _categoryDal.Get(id);
        }

        public List<category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public void TInsert(category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
