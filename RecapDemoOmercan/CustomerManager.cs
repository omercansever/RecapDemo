using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOmercan
{
    internal class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService userValidationService)
        {
            _customerCheckService = userValidationService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                Console.WriteLine("Added this Customer" + customer.FirstName + "" + customer.LastName);
            }
            else
            {
                throw new Exception("Not A Valid Person");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted this Customer" + customer.FirstName + "" + customer.LastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Updated this Customer" + customer.FirstName + "" + customer.LastName);
        }
    }
}
