using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public interface IOperatorService
    {
        public void manageUsers();
        public void ChangeCapacity(int courseId, int newCapacity);
        public void CangeStatus(int UserId, int answer);
        public bool AddUser(string username, string email, string password);
    }
}
