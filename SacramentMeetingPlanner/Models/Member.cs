using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Member
    {
        public int memberID { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string organization { get; set;}
        public string assignment { get; set; }
        public bool memberOfBB { get; set; }
    }
}
