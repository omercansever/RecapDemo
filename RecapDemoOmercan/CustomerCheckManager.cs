using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOmercan
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            if (customer.DateOfBirth == "2003" && customer.FirstName == "Ömercan" && customer.LastName == "Cansever" && customer.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
