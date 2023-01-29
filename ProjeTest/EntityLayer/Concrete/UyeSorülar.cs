using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UyeSorülar
    {
        [Key]
        public int SorularID { get; set; }
        public int UyeID { get; set; }
        public string UyeMail { get; set; }
        public string SoruBir { get; set; }
        public string Soruİki { get; set; }
        public string SoruUc { get; set; }
        public string SoruDort { get; set; }
        public string SoruBes { get; set; }
        public string SoruAlti { get; set; }
        public string SoruYedi { get; set; }
        public string SoruSekiz { get; set; }
        public string SoruDokuz { get; set; }
        public string SoruOn { get; set; }
    }
}
