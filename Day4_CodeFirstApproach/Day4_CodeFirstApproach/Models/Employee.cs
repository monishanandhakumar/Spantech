using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day4_CodeFirstApproach.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string Ename { get; set; }
        public decimal Salary { get; set; }

        public string Designation { get; set; }
    }
}
