using Business.Abstract;
using DataAccess.SoyutSiniflar;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        private IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public void Add(Musteri musteri)
        {
            //ValidationTool.Validate(new ProductValidator(), product);
            _musteriDal.Add(musteri);
        }

        public void Delete(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAll()
        {
            return _musteriDal.GetAll();
        }

        public void Update(Musteri musteri)
        {
            _musteriDal.Update(musteri);
        }

        // Örnek method overriding
        public override string ToString()
        {
            return "Bu, MusteriManager sınıfının ToString metodu tarafından oluşturulan bir metindir.";
        }
    }
}




//using Business.Abstract;
//using DataAccess.SoyutSiniflar;
//using Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Business.Concrete
//{
//    public class MusteriManager : IMusteriService
//    {

//       IMusteriDal _MusteriDal;
//        public MusteriManager(IMusteriDal musteriDal)
//        {
//            _MusteriDal = musteriDal;
//        }



//        public void Add(Musteri musteri)
//        {

//            //ValidationTool.Validate(new ProductValidator(), product);
//            _MusteriDal .Add(musteri);
//        }

//        public void Delete(Musteri musteri)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Musteri> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Musteri musteri)
//        {
//            _MusteriDal.Update(musteri);
//        }
//    }
//}
