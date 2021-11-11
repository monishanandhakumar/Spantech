using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiDay2_ThreeTireArchitecture.Models
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TotalMarks { get; set; }
    }
}
