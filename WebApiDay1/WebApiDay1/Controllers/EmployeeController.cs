using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDay1.Models;

namespace WebApiDay1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
       

        private readonly SampleContext db;

        public EmployeeController(SampleContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
          List<Employee> emp = db.Employees.ToList();

            if(emp.Count>0)
            {
                return Ok(emp);
            }
            else
            {
                return NotFound("No data found !!!");
            }
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            if(emp!= null)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return Ok("Record Added !!!");

            }
            else
            {
                return Ok("No record Added!!!");
            }
            
        }

        [HttpPut("{id}")]
        public IActionResult EditEmployee(int id,[FromBody]Employee emp)
        {
            try
            {
                var edata = db.Employees.FirstOrDefault(e => e.EmpId == id);
                if(edata==null)
                {
                    return BadRequest("Employee Data not found !!!");
                }
                else
                {
                    edata.Name = emp.Name;
                    edata.City = emp.City;
                    edata.Age = emp.Age;
                    edata.Gender = emp.Gender;
                    edata.Mobile = emp.Mobile;
                    edata.Salary = emp.Salary;
                    edata.Password = emp.Password;
                    edata.Deptid = emp.Deptid;
                    db.SaveChanges();
                    return Ok("Record Edited!!!");
                }
            }
            catch(Exception e)
            {
                return Ok(e);
            }
            

        }

        //Tax Calculation

        [HttpGet("{id}")]
        public IActionResult GetTax(int? id )
        {
            try
            {
                var edata = db.Employees.FirstOrDefault(e => e.EmpId == id);
                if (edata == null)
                {
                    return BadRequest("Employee not available!!!");
                }
                else
                {
                    float tax = 0;
                    dynamic salary = db.Employees.Find(id).Salary;
                    if(salary>0)
                    {
                        if((salary*12)>300000)
                        {
                            tax = (salary * 12) / 10;
                        }
                        else
                        {
                            tax = 0;
                        }
                    }
                    return Ok(tax);
                }
                
            }

            catch(Exception e)
            {
                return BadRequest("please try again!!!");
            }

        }
    }
}
