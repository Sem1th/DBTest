using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunW
{
   public  class Subdivision
    {

        [Key]
        public int SubdivisionId { get; set; }
        public string NameSubdivision { get; set; }
        
        public int? StaffId { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }

        public virtual Staff Staff1 { get; set; }





    }
}

