using System;
using System.Collections.Generic;

#nullable disable

namespace Day3_EFCore_DBFirst.Models
{
    public partial class ProductsPrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
