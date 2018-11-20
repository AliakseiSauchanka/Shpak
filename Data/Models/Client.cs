using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public DateTime DateOfCreate { get; set; }
        public virtual List<Car> Cars { get; set; }
        public virtual List<Visit> Visits { get; set; }
    }
}