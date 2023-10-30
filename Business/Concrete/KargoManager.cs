using Business.Abstract;
using DataAccess.Siniflar;
using DataAccess.SoyutSiniflar;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class KargoManager : IKargoService
    {
        private static IKargoDal _kargoDal;
//yapıcı metot ile özel bir IKargoDal nesnesi sağlanırsa,
//statik değişken olarak tanımlanmış _kargoDal değişkeni
//bu nesneyle başlatılacaktır.Eğer hiçbir parametre verilmezse,
//_kargoDal değişkeni varsayılan olarak KargoDal sınıfının bir örneğiyle başlatılacaktır.
        static KargoManager()
        {
            _kargoDal = new KargoDal(); 
        }

  

        public void Add(Kargo kargo)
        {
            _kargoDal.Add(kargo);
        }

        public Kargo Arama(string text)
        {
            return _kargoDal.Get(p => p.Takipno.ToLower().Contains(text.ToLower()));
        }
      public KargoManager()
        {
         
        }
        public void Delete(Kargo kargo)
        {
            try
            {
                _kargoDal.Delete(kargo);
            }
            catch
            {
                throw new Exception("Silme işlemi gerçekleşemedi");
            }
        }

        public List<Kargo> GetAll()
        {
            return _kargoDal.GetAll();
        }



        //Method overloading
        public List<Kargo> GetKargoByTakipno(string Takipno)
        {
            return _kargoDal.GetAll(p => p.Takipno.ToLower().Contains(Takipno.ToLower()));
        }

        public void Update(Kargo kargo)
        {
            _kargoDal.Update(kargo);
        }
    }
}
