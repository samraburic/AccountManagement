using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Model
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingTime { get; set; }
        public string Description { get; set; }

        public virtual Client Client { get; set; }
        public virtual User User { get; set; }
    }
}
