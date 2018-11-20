using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.DataContext
{
    // описание визита клиента
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public int ticketOfTheDay { get; set; }
        public DateTime DateOfVisit { get; set; }
        public virtual List<Purpose> Purposes { get; set; } = new List<Purpose>();
        public virtual List<Invoice> Invoices { get; set; } = new List<Invoice>();

        public int ClientId { get; set; }
        public AbstractClient Client { get; set; }
    }
}