using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Model
{
    public class ChangePasswordUpsertRequest
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }

}
