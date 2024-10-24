using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public static class Repository
    {
        public static Users Currentuser { get; set; }
        public static List<Users> Users { get; set; } = new List<Users>();
        public static List<Students> Students { get; set; } = new List<Students>();
        public static List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public static List<Course> Classes { get; set; } = new List<Course>();


        static Repository()
        {
            Users.Add(new Users { UserId = 1, Username = "Armin", Password = "123456", Role = RoleEnum.Operrator });
            Users.Add(new Users { UserId = 2, Username = "amir", Password = "123", Role = RoleEnum.Teacher });
            Users.Add(new Users { UserId = 3, Username = "nazanin", Password = "123", Role = RoleEnum.Student });







        }
    }
}
