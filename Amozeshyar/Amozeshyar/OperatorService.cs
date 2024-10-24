using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class OperatorService : IOperatorService
    {
        public void manageUsers()
        {
            foreach (var user in Repository.Users)
            {
                Console.WriteLine("*) "+user.FirstName+" "+user.LastName+":");
                Console.WriteLine($"User ID :{user.UserId}");
                if (user.Role==RoleEnum.Operrator)
                {
                    Console.WriteLine("Role : Operator");
                }
                else if (user.Role == RoleEnum.Teacher)
                {
                    Console.WriteLine("Role : Teacher ");
                }
                else if (user.Role == RoleEnum.Student)
                {
                    Console.WriteLine("Role : Student");
                }
            }
        }
        public void ChangeCapacity(int courseId, int newCapacity)
        {
            foreach (var course in Repository.Classes)
            {
                if (course.PresentaionCode==courseId)
                {
                    Console.WriteLine($"The latest capacity: {course.Capacity}");
                    course.Capacity = newCapacity;// برسی شود
                }
            }
        }
        public void CangeStatus(int UserId, int answer)
        {
            foreach (var user in Repository.Users)
            {
                if (answer==1)
                {
                    user.Acivation = AcivationEnum.Active;
                }
                else if (answer==2)
                {
                    user.Acivation = AcivationEnum.Deactive;
                }
            }
        }
        public bool AddUser(string username,string email,string password,int role)
        {
            foreach (var user in Repository.Users)
            {
                if (user.Username==username || user.Email==email)
                {
                    Console.WriteLine("This information is already taken.");
                    return false;
                }
            }
            Users users = new Users();
            users.Username = username;
            users.Email = email;
            users.Password = password;
            users.Acivation = AcivationEnum.Deactive;
            if (role==1)
            {
                users.Role = RoleEnum.Operrator;
            }
            else if (role==2)
            {
                users.Role = RoleEnum.Teacher;
            }
            else if (role==3)
            {
                users.Role = RoleEnum.Student;
            }
            int counter = 1;
            foreach (var user in Repository.Users)
            {
                if (user is not null)
                {
                    counter++;
                }
            }
            users.UserId = counter;
            Repository.Users.Add(users);
            return true;
        }

    }
}
