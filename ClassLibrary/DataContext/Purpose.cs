using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DataContext
{
    // описание цели визита
    public class Purpose
    {
        public int PurposeId { get; set; }
        public string Problem { get; set; }

        public int VisitId { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
