using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ClientSystem.Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Name is Requiered")]
        public String Name { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Requiered")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "RFC is Requiered")]
        public String RFC { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        [Required(ErrorMessage = "Postal Code is Requiered")]
        public String  PostalCode { get; set; }
    }
}
