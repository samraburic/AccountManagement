using System;
using System.Collections.Generic;

#nullable disable

namespace AccountManagement.WebAPI.Database
{
    public partial class Client
    {
        public Client()
        {
            Meetings = new HashSet<Meeting>();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Idnumebr { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public int? ModifyByUser { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
