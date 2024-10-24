using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public interface IAuthentication
    {
        public bool Login(string Username, string Password);
        public bool Register(string Email, string Password, string Username);
        public int currentuserId();
    }
}
