using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataContext
{
    // описание банка
    public class Bank
    {
        [Key]
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Address { get; set; }
        public string BIC { get; set; }

        public override string ToString()
        {
            return (BankName + " " + BIC);
        }
    }
}
