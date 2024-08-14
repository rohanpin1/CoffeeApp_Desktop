using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_DeskApp.DTO
{
    public class AuthenticateUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Is2FAEnabled { get; set; }
    }
}
