using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataContext
{
    // описание наличного клиента
    public class Client : AbstractClient
    {
        public string Surname { get; set; }
        public double Discount { get; set; }
    }
}