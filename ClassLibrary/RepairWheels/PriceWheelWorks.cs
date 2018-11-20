using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.RepairWheels
{
    public class PriceWheelWorks
    {
        public int PriceWheelWorksId { get; set; }
        public DateTime CreateDate { get; set; }

        //Wheel works
        public decimal DiskMetal { get; set; }
        public decimal DiskAllum { get; set; }
        public decimal DiskWeld { get; set; }
        public decimal BalanceKnock { get; set; }
        public decimal BalanceGlue { get; set; }
        public decimal TakeOffSetUp { get; set; }
        public decimal TakeOffSetUpDouble { get; set; }
        public decimal Shoe { get; set; }
        public decimal UnShoe { get; set; }
        public decimal DiskCleaing { get; set; }
        public decimal TirePacking { get; set; }
        public decimal Lubrication { get; set; }
    }
}
