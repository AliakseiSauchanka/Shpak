namespace Data.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int TakeOff { get; set; }
        public int SetUp { get; set; }
        public int Shoe { get; set; }
        public int UnShoe { get; set; }
        public int Balancing { get; set; }
        public string Valve { get; set; }
        public string Patch { get; set; }
        public string DiskRepair { get; set; }
        public string DiskCleaing { get; set; }
        public string Lubrication { get; set; }
        public decimal Price { get; set; }

        public int VisitId { get; set; }
        public Visit Visit { get; set; }
    }
}