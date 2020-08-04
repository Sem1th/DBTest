using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunW
{
   public  class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }

         public string Employer { get; set; }


        // Ссылка на сотрудника
        
       public Staff Staff { get; set; }

     


        //   public int? StaffId { get; set; }
        //  public virtual Staff Staff { get; set; }
    }
}
