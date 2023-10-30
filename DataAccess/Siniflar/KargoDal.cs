using DataAccess.SoyutSiniflar;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Siniflar
{
    public class KargoDal:EfEntityRepositoryBase<Kargo, KargoTakipOtomasyonuContext>,IKargoDal
    
    {

    }
}
