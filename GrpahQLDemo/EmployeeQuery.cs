using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpahQLDemo
{
    public class EmployeeQuery :ObjectGraphType
    {
        public EmployeeQuery (IEmpRepository employeeRepository)
        {
            Field<ListGraphType<EmployeeType>>(
                "employe",
                resolve: context => employeeRepository.GetEmployees()
                );
        }
    }
}
