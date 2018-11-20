using ClassLibrary.RepairWheels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.DataContext
{
    // описание акта выполненных работ
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public int MaterialCount { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }
        public Job Job { get; set; }
        public int JobCount { get; set; }

        [ForeignKey("Visit")]
        public int VisitId { get; set; }
        public Visit Visit { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
    }
}