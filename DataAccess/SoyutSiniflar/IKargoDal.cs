using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SoyutSiniflar
{
    public interface IKargoDal : IEntityRepository<Kargo>
    {
        //bu arayüzü uygulayan bir sınıf veritabanı işlemleri yapabilir ve Kargo nesnelerinin verilerini yönetebilir.

    }
}
