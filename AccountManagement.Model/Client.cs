using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Model
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Idnumebr { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public int? ModifyByUser { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
