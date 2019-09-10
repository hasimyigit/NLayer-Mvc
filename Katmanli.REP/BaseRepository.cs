using Katmanli.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.REP
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        NorthwindEntities db = NorthwindEntities.nv; // NorthwindEntities tipindeli db değişkenimin içinde öncden Dalda newlediğimi gönderiyorm.
        public T Bul(int id)
        {
            return Set().Find(id);
        }

        public T Bul(string id)
        {
            return Set().Find(id); ;
        }

        public void Ekle(T entity)
        {
            // Set().Add(entity);
            db.Entry(entity).State = EntityState.Added;
        }

        public IQueryable<T> GenelListe()
        {
            return Set().AsQueryable();
        }

        public void Guncel()
        {
            db.SaveChanges();
        }

        public List<T> Liste()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Sil(T entity)
        {
           // Set().Remove(entity);
            db.Entry(entity).State = EntityState.Deleted;
        }


    }
}
