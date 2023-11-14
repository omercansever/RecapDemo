using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOmercan
{
    internal interface ISaleService
    {
        public void Sale(Customer customer, Campaign campaign, Product product);
    }
}
