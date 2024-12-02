using CSharpEğtimKampı301.DataAccessLayer.Abstarct;
using CSharpEğtimKampı301.DataAccessLayer.Reprositories;
using CSharpEğtimKampı301.EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğtimKampı301.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Custumer>, ICustumerDal
    {
    }
}
