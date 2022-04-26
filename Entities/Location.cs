using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSolution.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public char Province { get; set; }
        public string? Contact { get; set; }
        public char Phone { get; set; }
        public bool Active { get; set; }

    }
}
