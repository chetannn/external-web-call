using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpPostHelper = new HttpPostHelper();

            var response = httpPostHelper.SendPostRequest(new InvoiceDetailViewModel()
            {
                username = "Test_CBMS",
                password = "test@321",
                seller_pan = "999999999",
                buyer_pan = "",
                buyer_name = "",
                fiscal_year = "",
                invoice_number = "",
                invoice_date = "",
                total_sales = 200,
                taxable_sales_vat = 200,
                vat = 10,
                excisable_amount = 0,
                excise = 0,
                taxable_sales_hst = 0,
                hst = 0,
                amount_for_esf = 0,
                esf = 0,
                export_sales = 0,
                tax_exempted_sales = 0,
                isrealtime = true,
                datetimeClient = DateTime.Now
            }, "http://202.166.207.75:9050/api/bill");

            var message = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"Response Result:{message}");
        }
    }

    public class InvoiceDetailViewModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string seller_pan { get; set; }
        public string buyer_pan { get; set; }
        public string fiscal_year { get; set; }
        public string buyer_name { get; set; }
        public string invoice_number { get; set; }
        public string invoice_date { get; set; }
        public double total_sales { get; set; }
        public double taxable_sales_vat { get; set; }
        public double vat { get; set; }
        public double excisable_amount { get; set; }
        public double excise { get; set; }
        public double taxable_sales_hst { get; set; }
        public double hst { get; set; } //health service tax
        public double amount_for_esf { get; set; }
        public double esf { get; set; } //education service fee
        public double export_sales { get; set; }
        public double tax_exempted_sales { get; set; }
        public bool isrealtime { get; set; }
        public DateTime datetimeClient { get; set; }

    }
}
