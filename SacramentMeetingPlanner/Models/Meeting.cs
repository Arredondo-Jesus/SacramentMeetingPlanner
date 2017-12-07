using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {   
        [Key]
        public int meetingID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime meetingDate { get; set; }

        public ICollection<Hymn> hymns { get; set; }
        public ICollection<Member> members { get; set; }

    }
}
