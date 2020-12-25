using GrpahQLDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpahQLDemo
{
    public interface IEmpRepository
    {
        List<Employee> GetEmployees ();
    }
}
