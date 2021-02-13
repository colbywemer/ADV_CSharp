using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WemerMultiPageWebAppDb.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage ="Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter a phone number.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Please enter an adress.")]
        public string Adress { get; set; }
        public string Note { get; set; }
       
    }
}
