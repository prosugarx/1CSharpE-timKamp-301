using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğtimKampı301.EntityLayer.concreate
{
    public class category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public bool categoryStatus { get; set; }
        public List<category> categories { get; set; }
        




    }
}
