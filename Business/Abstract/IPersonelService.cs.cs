using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonelService
    {


        List<Musteri> GetAll();

        void Add(Personel personel);
        void Update(Personel personel);
        void Delete(Personel personel);
       
    }
}
