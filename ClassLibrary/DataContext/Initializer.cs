using ClassLibrary.RepairWheels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataContext
{
    // инициализатор базы данных для первого старта
    class Initializer: DropCreateDatabaseIfModelChanges<ContextDb>
    {
        protected override void Seed(ContextDb context)
        {
            Purpose purp = new Purpose { Problem = "Переобувка" };
            
            TypeOfCar typeBus = new TypeOfCar { Type = "Микроавтобус/Джип", Wheels = 4};
            TypeOfCar typeLight = new TypeOfCar { Type = "Легковой", Wheels = 4 };
            TypeOfCar typeBusHeavy = new TypeOfCar { Type = "Микроавтобус грузовой/Джип", Wheels = 6 };
            TypeOfCar typeMoto = new TypeOfCar { Type = "Мото", Wheels = 2 };

            context.TypesOfCars.Add(typeLight);
            context.TypesOfCars.Add(typeBus);
            context.TypesOfCars.Add(typeBusHeavy);
            context.TypesOfCars.Add(typeMoto);

            context.SaveChanges();

            Material material = new Material();
            material.Name = "N0";
            material.Price = 2;

            Job job = new Job
            {
                Name = "тест",
                Price = 5,
                TypeOfCar = typeLight
            };
            context.Jobs.Add(job);

            //Job job1 = new Job
            //{
            //    Name = "разборка",
            //    Price = 5,
            //    TypeOfCar = typeBus
            //};

            //Job job2 = new Job
            //{
            //    Name = "разборка",
            //    Price = 5,
            //    TypeOfCar = typeBusHeavy
            //};

            //Job job3 = new Job
            //{
            //    Name = "самоклейка",
            //    Price = 5,
            //    TypeOfCar = typeBusHeavy
            //};



            //context.Jobs.Add(job);
            //context.Jobs.Add(job1);
            //context.Jobs.Add(job2);
            //context.Jobs.Add(job3);

            context.SaveChanges();

            List<Job> lightJobs = new List<Job>
                                  {
                                      new Job
                                      {
                                          Name = "разборка",
                                          Price = 5,
                                          TypeOfCar = typeLight
                                      },
                                      new Job
                                      {
                                          Name = "сборка",
                                          Price = 5,
                                          TypeOfCar = typeLight
                                      },
                                      new Job
                                      {
                                          Name = "набивной",
                                          Price = 5,
                                          TypeOfCar = typeLight
                                      },
                                      new Job
                                      {
                                          Name = "самоклейка",
                                          Price = 5,
                                          TypeOfCar = typeLight
                                      },
                                      new Job
                                      {
                                          Name = "снятие",
                                          Price = 5,
                                          TypeOfCar = typeLight
                                      },
                                      new Job
                                      {
                                          Name = "установка",
                                          Price = 5,
                                          TypeOfCar = typeLight
                                      }
                                  };

            List<Job> busJobs = new List<Job>
                                  {
                                      new Job
                                      {
                                          Name = "разборка",
                                          Price = 5,
                                          TypeOfCar = typeBus
                                      },
                                      new Job
                                      {
                                          Name = "сборка",
                                          Price = 5,
                                          TypeOfCar = typeBus
                                      },
                                      new Job
                                      {
                                          Name = "набивной",
                                          Price = 5,
                                          TypeOfCar = typeBus
                                      },
                                      new Job
                                      {
                                          Name = "самоклейка",
                                          Price = 5,
                                          TypeOfCar = typeBus
                                      },
                                      new Job
                                      {
                                          Name = "снятие",
                                          Price = 5,
                                          TypeOfCar = typeBus
                                      },
                                      new Job
                                      {
                                          Name = "установка",
                                          Price = 5,
                                          TypeOfCar = typeBus
                                      }
                                  };

            List<Job> busHeavyJobs = new List<Job>
                                  {
                                      new Job
                                      {
                                          Name = "разборка",
                                          Price = 5,
                                          TypeOfCar = typeBusHeavy
                                      },
                                      new Job
                                      {
                                          Name = "сборка",
                                          Price = 5,
                                          TypeOfCar = typeBusHeavy
                                      },
                                      new Job
                                      {
                                          Name = "набивной",
                                          Price = 5,
                                          TypeOfCar = typeBusHeavy
                                      },
                                      new Job
                                      {
                                          Name = "самоклейка",
                                          Price = 5,
                                          TypeOfCar = typeBusHeavy
                                      },
                                      new Job
                                      {
                                          Name = "снятие",
                                          Price = 5,
                                          TypeOfCar = typeBusHeavy
                                      },
                                      new Job
                                      {
                                          Name = "установка",
                                          Price = 5,
                                          TypeOfCar = typeBusHeavy
                                      }
                                  };

            List<Job> motoJobs = new List<Job>
                                  {
                                      new Job
                                      {
                                          Name = "разборка",
                                          Price = 5,
                                          TypeOfCar = typeMoto
                                      },
                                      new Job
                                      {
                                          Name = "сборка",
                                          Price = 5,
                                          TypeOfCar = typeMoto
                                      },
                                      new Job
                                      {
                                          Name = "самоклейка",
                                          Price = 5,
                                          TypeOfCar = typeMoto
                                      }
                                  };

            List<Job> sharedJobs = new List<Job>
            {
                new Job
                {
                    Name = "надбака за камеру",
                    Price = 3,
                    TypeOfCar = null,
                    TypeOfCarId = null
                },
                new Job
                {
                    Name = "очистка диска",
                    Price = 1,
                    TypeOfCar = null,
                    TypeOfCarId = null
                },
                new Job
                {
                    Name = "упаковка",
                    Price = 1.5m,
                    TypeOfCar = null,
                    TypeOfCarId = null
                },
                new Job
                {
                    Name = "уплотнение бортов",
                    Price = 0.5m,
                    TypeOfCar = null,
                    TypeOfCarId = null
                },
                new Job
                {
                    Name = "железо",
                    Price = 10,
                    TypeOfCar = null,
                    TypeOfCarId = null
                },
                new Job
                {
                    Name = "боковой порез",
                    Price = 10,
                    TypeOfCar = null,
                    TypeOfCarId = null
                },
                new Job
                {
                    Name = "литой",
                    Price = 20,
                    TypeOfCar = null,
                    TypeOfCarId = null
                },
                new Job
                {
                    Name = "сварка",
                    Price = 10,
                    TypeOfCar = null,
                    TypeOfCarId = null
                }
            };



            Client client = new Client
            {
                Surname = "Regoth",
                Name = "Filipp",
                Tel = "6987654",
                DateOfCreate = new DateTime(2012, 12, 12)
            };

            Visit visit = new Visit
            {
                DateOfVisit = new DateTime(2012, 12, 12),
                Purposes = new List<Purpose>() { purp },
                ClientId = client.Id
            };

            Car car = new Car
            {
                ClientId = client.Id,
                TypeOfCarId = typeLight.Id,
                RegNumber = "1111aa-3",
                Brand = "Mersedes",
                Driver = ""
            };

            // добавление работ
            context.Jobs.AddRange(lightJobs);
            context.Jobs.AddRange(busJobs);
            context.Jobs.AddRange(busHeavyJobs);
            context.Jobs.AddRange(motoJobs);
            context.Jobs.AddRange(sharedJobs);

            context.Materials.Add(material);
            context.CashClients.Add(client);
            context.Cars.Add(car);
            context.Visites.Add(visit);
            context.Purposes.Add(purp);

            context.SaveChanges();

            Bank clientBank = new Bank
            {
                BankName = "Приорбанк",
                Address = "Черниговское шоссе 87",
                BIC = "тут должен быть BIC"
            };

            CashlessClient newClient = new CashlessClient
            {
                DateOfCreate = DateTime.Now,
                ContractDate = new DateTime(2010, 11, 21),
                ContractNumber = "783",
                Name = @"OOO""Вяликия хрюхи""",
                Address = "Красноармейская 3А",
                Tel = "0232 412332",
                UNP = "490002445",
                IBAN = "тут должен быть IBAN",
                BankId = clientBank.Id
            };

            Car car2 = new Car
            {
                ClientId = newClient.Id,
                TypeOfCarId = typeLight.Id,
                RegNumber = "7827АВ-3",
                Brand = "Lexus",
                Driver = ""
            };

            Visit visit2 = new Visit
            {
                DateOfVisit = new DateTime(2018, 2, 1),
                Purposes = new List<Purpose>() { purp },
                ClientId = newClient.Id,
            };

            Invoice invoice = new Invoice();
            invoice.JobId = job.Id;
            invoice.Material = material;
            invoice.JobCount = 4;
            invoice.VisitId = visit2.Id;
            invoice.InvoiceDate = DateTime.Now;

            context.Invoices.Add(invoice);
            context.CashlessClients.Add(newClient);
            context.Cars.Add(car2);
            context.Visites.Add(visit2);
            context.Banks.Add(clientBank);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
