using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestFunW
{
    public class Staff
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        // [Column(TypeName = "Date")]
       // [DataType(DataType.Time)]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd-MM-yyyy hh:mm:ss}")]
        public string Date { get; set; }
  
        public string Gender { get; set; }


        // public int? SubdivisionId { get; set; }
        // public virtual Subdivision Subdivision { get; set; }

        // Ссылка на отдел
       
        public Subdivision Subdivision { get; set; }
      


    }
}
