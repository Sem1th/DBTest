using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunW
{
   public  class Subdivision
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Ссылка на сотрудников
    
      // public Staff Staff { get; set; }
        public virtual List<Staff> Staffs { get; set; }



       
    }
}

