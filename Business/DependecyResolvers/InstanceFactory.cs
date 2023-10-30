using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolvers
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();


//başka bir sınıfta "var kargoManager = new KargoManager(new KargoDal());" yerine "var kargoManager = InstanceFactory.GetInstance<IKargoService>();" kullanılabilir.
// Bu şekilde bir bağımlılık oluşturmadan, doğrudan ilgili arayüze erişim sağlanır.
        }
    }
}
