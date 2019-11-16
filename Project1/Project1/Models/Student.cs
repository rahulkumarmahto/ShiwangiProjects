using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    [Table(name: "Student")]
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Name is too long(max 30 chars).")]
        public string Name { get; set; }
        [Required]
        [Range(10, 50, ErrorMessage = "Age should be in between 10 and 50.")]
        public int Age { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email address is not correct")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
