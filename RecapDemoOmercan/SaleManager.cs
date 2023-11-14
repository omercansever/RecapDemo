using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOmercan
{
    internal class SaleManager : ISaleService
    {
        public void Sale(Customer customer, Campaign campaign, Product product)
        {
            int discount = campaign.CampaignDiscount;
            product.ProductPrice = product.ProductPrice * discount / 100;

            Console.WriteLine(customer.FirstName + "" + customer.LastName + "İsimli Kullanıcı satın aldı\n"
                + "Ürün" + product.ProductName
                + "\nFiyat" + product.ProductPrice + "TL"                
                );
        }
    }
}
