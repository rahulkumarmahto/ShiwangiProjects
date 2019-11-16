using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Login
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Password is too length")]
        public string Password { get; set; }
    }
}
