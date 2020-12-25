using GraphQL.Types;
using GrpahQLDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpahQLDemo
{
    public class EmployeeType:ObjectGraphType<Employee>
    {
        public EmployeeType ()
        {
            Field(a => a.Id);
            Field(a => a.Name).Description("Name property from the emp object."); ;
            Field(a => a.Email);
            Field(a => a.Mobile);
            Field(a => a.Company);
            Field(a => a.Address);
            Field(a => a.ShortDescription);
            Field(a => a.LongDescription);
        } 
    }
}
