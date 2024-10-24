using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class Teacher : Users
    {
        public List<Course> Courses { get; set; }
    }
}
