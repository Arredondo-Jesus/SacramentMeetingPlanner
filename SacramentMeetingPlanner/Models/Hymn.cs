using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Hymn
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hymnNumber { get; set; }
        public string title { get; set; }
    }
}
