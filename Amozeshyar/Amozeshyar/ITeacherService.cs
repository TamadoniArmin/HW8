using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public interface ITeacherService
    {
        public void AddCourse(int teacherId,string Name, DateTime timeofclass, int vahed);
        public void SeeStudents(int TeacherId);
    }
}
