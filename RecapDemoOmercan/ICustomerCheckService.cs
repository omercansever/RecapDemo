using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOmercan
{
    internal interface ICustomerCheckService
    {
        public bool CheckIfRealCustomer (Customer customer);
    }
}
