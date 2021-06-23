using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Model.Requests
{
    public class UserUpsertRequerst
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string Phone { get; set; }
        public int? CreatedByUser { get; set; }
        public int? ModifyByUser { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastChanged { get; set; }
        public DateTime? Deleted { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
