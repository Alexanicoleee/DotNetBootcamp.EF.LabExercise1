using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSolution.Entities
{
    public class PlacementContract
    {
        public int PlacementContractID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}

