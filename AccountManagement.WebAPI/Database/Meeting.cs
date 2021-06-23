using System;
using System.Collections.Generic;

#nullable disable

namespace AccountManagement.WebAPI.Database
{
    public partial class Meeting
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
