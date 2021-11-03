using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day3_EFCore_DBFirst.Models
{
    public class CustOrdersOrders
    {
        [Key]
       public int OrderID { get; set; } 
	public Nullable<System.DateTime> OrderDate { get; set; }
	public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
