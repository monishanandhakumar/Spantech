using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4_CodeFirstApproach.Models
{
    public class EmpoyeeDbContext:DbContext
    {
        public EmpoyeeDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
