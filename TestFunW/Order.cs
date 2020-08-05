using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunW
{

   public  class Order
    {
        public int OrderId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }


        [Required]
        public int? StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
