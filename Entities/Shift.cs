using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public int PlacementContractID { get; set; }
        public int DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        public string? Notes { get; set; }

        public PlacementContract PlacementContract { get; set; }

    }
}
