using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.REP
{
    interface IBaseRepository<T> where T: class,new()
    {
        DbSet<T> Set();
        void Ekle(T entity);
        void Sil(T entity);
        void Guncel();
        T Bul(int Id);
        T Bul(string Id);
        List<T> Liste();
        IQueryable<T> GenelListe();
    }
}
