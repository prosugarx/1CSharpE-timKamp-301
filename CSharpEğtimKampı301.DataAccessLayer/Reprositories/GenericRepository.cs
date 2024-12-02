using CSharpEğtimKampı301.DataAccessLayer.Abstarct;
using CSharpEğtimKampı301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğtimKampı301.DataAccessLayer.Reprositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CampContext context = new CampContext();
        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object= context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T Get(int id)
        {

            return _object.Find(id);
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public void Insert(T entity)
        {
            var addedEntity=context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity=context.Entry(entity);    
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
