using GraphQL.Types;
using GraphQL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpahQLDemo
{
    public class EmployeeSchema :Schema
    {
        public EmployeeSchema (IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<EmployeeQuery>();
        }
    }
}
