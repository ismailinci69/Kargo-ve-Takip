using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SoyutSiniflar
{
        public interface IEntityRepository<T> where T : class, IEntity, new()
        {
            List<T> GetAll(Expression<Func<T, bool>> filter = null);
            T Get(Expression<Func<T, bool>> filter);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        //Bu arayüz, veritabanı işlemlerinde kullanılan standart metodları tanımlar ve programcılara
        //veritabanı işlemlerini yapmak için bir şablon sunar. Bu sayede,
        //veritabanına erişmek için her seferinde özelleştirilmiş bir sınıf yazmak yerine,
        //uygulama boyunca yeniden kullanılabilen bir kod tabanı sağlar.
    }
}

