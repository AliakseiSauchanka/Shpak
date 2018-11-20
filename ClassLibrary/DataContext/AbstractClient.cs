using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataContext
{
    // описание абстрактной сущности клиента
    public abstract class AbstractClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public DateTime DateOfCreate { get; set; }
        public virtual List<Car> Cars { get; set; } = new List<Car>();
        public virtual List<Visit> Visits { get; set; } = new List<Visit>();
    }
}
