using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsumeWebApiProject.Models
{
    public class Employee
    {
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(35, ErrorMessage = "Name not be exceed")]
        [RegularExpression("[A-Za-z]*", ErrorMessage = "Invalid Name ")]
        public string name { get; set; }
        [Required]
        public string gender { get; set; }

        [Required]
        [Range(18, 55, ErrorMessage = "Please Enter age between 18 and 55")]
        public int age { get; set; }
        [Required]
        public string designation { get; set; }
        [Required]
        public int salary { get; set; }
    }
}