using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppWemer.Models
{
    public class AgeCalculartor
    {
        [Required(ErrorMessage ="Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your birthday.")]
        public DateTime? Birthday { get; set; }
        public int? AgeThisYear() 
        {
            DateTime Birth = Convert.ToDateTime(Birthday);
            int age = (new DateTime(DateTime.Now.Subtract(Birth).Ticks).Year)- 1;
            return age;
        }
       
    }
}
