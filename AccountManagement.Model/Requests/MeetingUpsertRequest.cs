using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Model.Requests
{
    public class MeetingUpsertRequest
    {
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingTime { get; set; }
        public string Description { get; set; }
    }
}
