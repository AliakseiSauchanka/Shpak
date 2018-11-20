using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public DateTime DateOfVisit { get; set; }
        public virtual List<Purpose> Purpose { get; set; }
        //public string InvoiceId { get; set; }
        //public virtual Invoice Invoice { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}