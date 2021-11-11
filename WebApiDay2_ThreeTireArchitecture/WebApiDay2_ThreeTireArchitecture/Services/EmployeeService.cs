using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDay2_ThreeTireArchitecture.Models;

namespace WebApiDay2_ThreeTireArchitecture.Services
{
    public class EmployeeService:IEmployeeRepository
    {
        public readonly SampleContext db;

        public EmployeeService(SampleContext context)
        {
            db = context;
        }

        public string GetEmployeeById(int id)
        {
            var emp = db.Employees.Where(e => e.EmpId == id).Select(n => n.Name).FirstOrDefault();
            return emp;
        }


        //Async way to increase cpu performance 
        public async Task<string> GetEmployeeByIdA(int id)
        {
            dynamic emp = await db.Employees.Where(e => e.EmpId == id).Select(n => n.Name).FirstOrDefaultAsync();
            return emp;
        }

    }
}
