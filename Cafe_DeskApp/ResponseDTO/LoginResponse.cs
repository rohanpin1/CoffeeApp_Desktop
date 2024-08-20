using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_DeskApp.ResponseDTO
{
    public class LoginResponse
    {
        public bool Is2FAEnabled { get; set; }
        public string Token { get; set; }
        public int FlagCode { get; set; }
    }
}
