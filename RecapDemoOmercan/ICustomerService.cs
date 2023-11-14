using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOmercan
{
    internal interface ICustomerService
    {
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
    }
}
