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

        public int StaffId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }

        public DateTime Date { get; set; }

        public Gender GenderValues { get; set; }

        public int? SubdivisionId { get; set; }

        public virtual ICollection<Order> Order { get; set; }

        public virtual Subdivision Subdivision { get; set; }
        public virtual ICollection<Subdivision> Subdivision1 { get; set; }


    }

    public enum Gender
    {

        [EnumMember(Value = "М")]
        Мужской, // database uses 'M' instead of 'Male'

        [EnumMember(Value = "Ж")]
        Женский // database uses 'F' instead of 'Female'
    }
}
