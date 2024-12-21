using CSharpEğtimKampı301.DataAccessLayer.Abstarct;
using CSharpEğtimKampı301.DataAccessLayer.Context;
using CSharpEğtimKampı301.DataAccessLayer.Reprositories;
using CSharpEğtimKampı301.EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğtimKampı301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
           var context = new CampContext();
            var values = context.Products.Select(x => new
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.category.categoryName

            }).ToList();
            return values.Cast<object>().ToList(); ;
        }

        //List<Product> IProductDal.GetProductsWithCategory()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
