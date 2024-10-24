using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class Authentication : IAuthentication
    {
        public bool Login(string Username, string Password)
        {
            foreach (var user in Repository.Users)
            {
                if (user.Username==Username && user.Password==Password)
                {
                    Repository.Currentuser = user;
                    return true;
                }
            }
            return false;
        }
        public bool Register(string Email, string Password, string Username)
        {
            bool CanAction = true;
            int counter = 1;
            foreach (var user in Repository.Users)
            {
                if (user.Email==Email)
                {
                    Console.WriteLine("This Email is already taken!");
                    CanAction = false;
                    return false;
                }
                else if (user.Username==Username)
                {
                    Console.WriteLine("This Username is already taken!");
                    CanAction = false;
                    return false;
                }
                counter++;
            }
            if (CanAction)
            {
                Users user = new Users();
                user.Email = Email;
                user.Username = Username;
                user.Password = Password;
                user.UserId = counter;
                Repository.Users.Add(user);
                return true;
            }
            return false;
        }
        public int currentuserId()
        {
            return Repository.Currentuser.UserId;
        }
    }
}
