using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UyeCv
    {
        [Key]
        public int CvID { get; set; }
        public int UyeID { get; set; }
        public string CvDosya { get; set; }
    }
}
