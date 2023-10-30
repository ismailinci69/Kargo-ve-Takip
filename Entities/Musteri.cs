using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Musteri : IEntity
    {
        public int MusteriID { get; set; }
        public string AdSoyad { get; set; }
        public string TC { get; set; }
        public string TelNo { get; set; }
    }
}
