﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public int CategoryId { get; set; }
        public virtual category Category { get; set; }
        public List<Order> Orders { get; set; }
    



    }
}
