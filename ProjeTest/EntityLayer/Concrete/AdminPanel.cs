using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AdminPanel
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminMail { get; set; }
        public string Password { get; set; }
    }
}
