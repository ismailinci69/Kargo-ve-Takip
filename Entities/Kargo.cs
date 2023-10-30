using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
 public  class Kargo:IEntity
    {
        public int Id { get; set; }
        public string Takipno { get; set; }
        public string AlıcıAdSoyad { get; set; }

        public string AlıcıTelNo { get; set; }

        public string AlıcıAdres { get; set; }

        public DateTime Kabultarihi { get; set; }
        public string Durum { get; set; }

    }
}
