using GrpahQLDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpahQLDemo
{
    public class EmpRepository :IEmpRepository
    {
        GrpahQLDemoDBContext _context;
        public EmpRepository (GrpahQLDemoDBContext context)
        {
            this._context = context;
        }
        public List<Employee> GetEmployees ()
        {
            return  this._context.Employees.ToList();
        }
    }
}
