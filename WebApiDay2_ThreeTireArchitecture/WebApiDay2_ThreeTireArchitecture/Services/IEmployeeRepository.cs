using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDay2_ThreeTireArchitecture.Models;

namespace WebApiDay2_ThreeTireArchitecture.Services
{
    public interface IEmployeeRepository
    {
        string GetEmployeeById(int id);

        Task<string> GetEmployeeByIdA(int id);
    }
}
