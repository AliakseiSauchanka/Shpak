using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class DataContext:DbContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Purpose> Purposes { get; set; }
        DbSet<TypeOfCar> TypeOfCars { get; set; }
        DbSet<Visit> Visits { get; set; }
    }
}
