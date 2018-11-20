using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataContext
{
    // описание безналичного клиента
    public class CashlessClient : AbstractClient
    {
        public string Address { get; set; }

        public string UNP { get; set; }
        public string IBAN { get; set; }
        public DateTime ContractDate { get; set; }
        public string ContractNumber { get; set; }

        //[ForeignKey("Bank")]
        public int BankId{ get; set; }
        public Bank Bank { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
