using ClassLibrary.RepairWheels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataContext
{
    // контекст данных
    public class ContextDb : DbContext
    {
        static ContextDb()
        {
            Database.SetInitializer<ContextDb>(new Initializer());
        }

        public ContextDb() : base("ShpakDb")
        {           
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<AbstractClient> Clients { get; set; }
        public DbSet<CashlessClient> CashlessClients { get; set; }
        public DbSet<Client> CashClients { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<TypeOfCar> TypesOfCars { get; set; }
        public DbSet<Bank> Banks { get; set; } 

        public DbSet<Visit> Visites { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}