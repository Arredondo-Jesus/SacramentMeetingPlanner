using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(MeetingContext context) {
            context.Database.EnsureCreated();

            //Look for any meetings
            if (context.Meetings.Any()) {
                return; // DataBase has been seeded
            }

            var meetings = new Meeting[] {
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")},
                new Meeting{ meetingDate = DateTime.Parse("2012-09-01")}
            };
            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var hymns = new Hymn[] 
            {
                new Hymn{ hymnNumber = 123, title ="Favorite Hymn"},
                new Hymn{ hymnNumber = 123, title ="Favorite Hymn"},
                new Hymn{ hymnNumber = 123, title ="Favorite Hymn"},
                new Hymn{ hymnNumber = 123, title ="Favorite Hymn"},
                new Hymn{ hymnNumber = 123, title ="Favorite Hymn"}
            };

            foreach (Hymn h in hymns)
            {
                context.Hymns.Add(h);
            }
            context.SaveChanges();

            var members = new Member[] 
            {
                new Member{name ="test", lastName="test", organization ="Priesthood", assignment="Prayer", memberOfBB = false },
                new Member{name ="test", lastName="test", organization ="Priesthood", assignment="Prayer", memberOfBB = false },
                new Member{name ="test", lastName="test", organization ="Priesthood", assignment="Prayer", memberOfBB = false },
                new Member{name ="test", lastName="test", organization ="Priesthood", assignment="Prayer", memberOfBB = false },
                new Member{name ="test", lastName="test", organization ="Priesthood", assignment="Prayer", memberOfBB = true }
            };

            foreach (Member me in members)
            {
                context.Members.Add(me);
            }
            context.SaveChanges();

        }
    }
}
