using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TestFunW
{
    
    public class Staff
    {
     //   public Staff()
      //  {
      //      Order = new HashSet<Order>();
       //     Subdivision1 = new HashSet<Subdivision>();
      //  }

        public int StaffId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        // [Column(TypeName = "Date")]
       // [DataType(DataType.Time)]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd-MM-yyyy hh:mm:ss}")]
        public DateTime Date { get; set; }
  
       // public enum Gender { get; set; }
        public Gender GenderValues { get; set; }


        // public int? SubdivisionId { get; set; }
        // public virtual Subdivision Subdivision { get; set; }

        // Ссылка на отдел
        // public int SubdivisionId { get; set; }

        // public Subdivision Subdivision { get; set; }
       // [Required]
        public int? SubdivisionId { get; set; }

        public virtual ICollection<Order> Order { get; set; }

        public virtual Subdivision Subdivision { get; set; }
        public virtual ICollection<Subdivision> Subdivision1 { get; set; }


    }

    public enum Gender
    {
        [EnumMember(Value = "N")]
        None, // database uses 'M' instead of 'Male'

        [EnumMember(Value = "М")]
        Мужской, // database uses 'M' instead of 'Male'

        [EnumMember(Value = "Ж")]
        Женский // database uses 'F' instead of 'Female'
    }
}
