using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day3_EFCore_DBFirst.ViewModel
{
    public class CustomerVM
    {
        [Key]
        public string CustomerId { get; set; } //Customer
        public string CompanyName { get; set; }//Customer

        public int OrderId { get; set; } //Order

        public DateTime? OrderDate { get; set; } //Order
    }
}
