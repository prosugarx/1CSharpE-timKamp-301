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
    public class ProductManager : IProductService
    {
        public readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGet(int id)
        {
            return _productDal.Get(id);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
