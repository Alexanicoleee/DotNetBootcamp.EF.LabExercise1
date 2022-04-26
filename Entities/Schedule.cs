using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public DateTime Day { get; set; }
        public int ShiftID { get; set; }
        public int EmployeeID { get; set; }
        public decimal HourlyWage { get; set; }
        public bool OverTime { get; set; }

        public Shift Shift { get; set; }
        public Employee Employee { get; set; }
    }
}
