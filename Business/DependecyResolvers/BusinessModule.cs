using Business.Abstract;
using Business.Concrete;
using DataAccess.Siniflar;
using DataAccess.SoyutSiniflar;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolvers
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IKargoService>().To<KargoManager>();
            Bind<IKargoDal>().To<KargoDal>();

            Bind<IMusteriService>().To<MusteriManager>();
            Bind<IMusteriDal>().To<MusteriDal>();

            Bind<IPersonelService>().To<PersonelManager>();
            Bind<IPersonelDal>().To<PersonelDal>();

//kodun daha test edilebilir, bakımı daha kolay ve yeniden kullanılabilir olmasını sağlar.
        }
    }
}
