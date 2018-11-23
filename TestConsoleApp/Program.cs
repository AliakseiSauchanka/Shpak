using ClassLibrary.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextDb db = new ContextDb();
            void Print()
            {
                Invoice invoice = new Invoice();
                invoice.Job = db.Jobs.First(j=> j.Name == "сварка");
                invoice.JobCount = 1;
                Console.WriteLine(invoice.Job.Price.ToString());


                //invoice.Visit = new Visit();
                //invoice.Visit.Id = visit.Id;

                //db.Invoices.Add(invoice);
                var testPrice = db.Invoices.Where(i=>
                    (i.Job.Name == "железо" || i.Job.Name == "литой")
                    ).Sum(p => p.Job.Price * p.JobCount);

                decimal thisPanelPrice = invoice.JobCount * invoice.Job.Price;

                Console.WriteLine(thisPanelPrice);

            }

            Print();
        }
    }
}
