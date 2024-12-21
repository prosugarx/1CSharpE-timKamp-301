using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğtimKampı301.EntityLayer.concreate
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductDescription { get; set; }

        public int categoryId { get; set; }
        public virtual category category { get; set; }
        public List<Order> Orders { get; set; }
        
       // [NotMapped]
        //public string CategoryName { get; set; };


    }
}
