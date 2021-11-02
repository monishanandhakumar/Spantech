using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day2_Helpers.Models
{
    public class Register
    {
        [Required(ErrorMessage ="Please Enter your Name ")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Password and Confirm password does not match")]
        public string ConfirmPassword { get; set; }
        public float Salary { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        public string Address { get; set; }


    }
}
