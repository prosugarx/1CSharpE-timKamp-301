using CSharpEgtimKampı301.BussinesLayer.Abstract;
using CSharpEğtimKampı301.DataAccessLayer.Abstarct;
using CSharpEğtimKampı301.EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgtimKampı301.BussinesLayer.Concrate
{
    public class CustumerManager : ICustumerService
    {
        public readonly ICustumerDal _custumerDal;// _ alt tire koymamızın sebebi
                                                  // ctrl . yapıp generete concrete gibi bir şeye basınca
                                                  // başında this getirir
                                                  // ve biz her şeyi thisle çağırak torunda kalırız.

        public CustumerManager(ICustumerDal custumerDal)
        {
            _custumerDal = custumerDal;
        }

        public void TDelete(Custumer entity)
        {
            _custumerDal.Delete(entity);
        }

        public Custumer TGet(int id)
        {
            return _custumerDal.Get(id);
        }

        public List<Custumer> TGetAll()
        {
            return _custumerDal.GetAll();
        }

        public void TInsert(Custumer entity)
        {//validasyon şartları yazıyor categorymanegerden farkı
            if (entity.CustumerName != "" 
                && entity.CustumerName.Length > 3 
                && entity.CustumerName.Length < 30
                && entity.CustumerDistract != null 
                && entity.CustumersSurname != "")
            {
                _custumerDal.Insert(entity);
            }
            else
            { 
                // hata mesajı ver
            }
        }

        public void TUpdate(Custumer entity)
        {
            if (entity.CustumerId != 0 && entity.CustumerDistract.Length >= 3)
            {
                _custumerDal.Update(entity);
            }
            else
            {
                // hata uyarısı
            }
        }
    }
}
