using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KayitSistemi
    {
        [Key]
        public int UyeID { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public int UyeTelefon { get; set; }
        public string UyeMail { get; set; }
        public string Sifre { get; set; }
        public DateTime UyeDogümTarihi { get; set; }
    }
}
