using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public AcivationEnum Acivation { get; set; } = AcivationEnum.Deactive;
        public RoleEnum Role { get; set; }
    }
}
