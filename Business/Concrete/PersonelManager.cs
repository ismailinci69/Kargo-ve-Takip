using Business.Abstract;
using DataAccess.Siniflar;
using DataAccess.SoyutSiniflar;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void Add(Personel personel)
        {
            _personelDal.Add(personel);
        }

        public void Delete(Personel personel)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Personel personel)
        {
            throw new NotImplementedException();
        }
    }
}












//using Business.Abstract;
//using DataAccess.SoyutSiniflar;
//using Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace Business.Concrete
//{
//    public class PersonelManager : IPersonelService
//    {


//        IPersonelDal _personelDal;
//        public PersonelManager(IPersonelDal personelDal)
//        {
//            _personelDal = personelDal;
//        }

//        public void Add(Personel personel)
//        {
//            _personelDal.Add(personel);
//        }

//        public void Delete(Personel personel)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Musteri> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Personel personel)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
