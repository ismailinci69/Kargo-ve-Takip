using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface  IMusteriService
    {
        List<Musteri> GetAll();

        void Add(Musteri musteri);
        void Update(Musteri musteri);
        void Delete(Musteri musteri);

    }
}
