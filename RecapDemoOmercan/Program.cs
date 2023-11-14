namespace RecapDemoOmercan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ömercan";
            customer.LastName = "Cansever";
            customer.DateOfBirth = "2003";
            customer.NationalityId = "1234567890";

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Yaz Kampanyası";
            campaign.CampaignDiscount = 50;

            Product product = new Product();
            product.ProductName = "Red Dead Redemptiom";
            product.ProductPrice = 1000;


            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(customer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(customer, campaign, product);
        }
    }
}