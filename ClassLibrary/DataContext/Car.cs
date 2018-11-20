﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.DataContext
{
    // описание машины
    public class Car
    {
        public int CarId { get; set; }
        public string Driver { get; set; }
        public string RegNumber { get; set; }
        public string Brand { get; set; }
        public int TypeOfCarId { get; set; }
        public virtual TypeOfCar TypeOfCar { get; set; }


        public int ClientId { get; set; }
        public AbstractClient Client { get; set; }

        public override string ToString()
        {
            return (Brand + " " + RegNumber);
        }
    }
}