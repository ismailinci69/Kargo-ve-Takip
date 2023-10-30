using Entities;
using Ninject.Planning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IKargoService
    {
        List<Kargo> GetAll();

        void Add(Kargo kargo);
        void Update(Kargo kargo);
        void Delete(Kargo kargo);
        List<Kargo> GetKargoByTakipno(string Takipno);
 //bir takip numarası alarak, bu takip numarasına sahip olan tüm kargoları bulur ve bu kargoların listesini döndürür.
        Kargo Arama(string text);
    }}

//bu kodlar C# programlama dilinde IKargoService isimli bir arayüz (interface) tanımlar. Bu arayüz, kargo işlemleriyle ilgili metotları içerir.