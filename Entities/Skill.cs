using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSolution.Entities
{
    public class Skill
    {
        public int SkillID { get; set; }
        public string Description { get; set; }
        public bool RequiresTicket { get; set; }
    }
}
