using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public interface IStudentservis
    {
        public void ShowAllCourses();
        public bool TakeCourses(int StudentId,int CourseId);
        public void SeeSchedule(int StudentId);
    }
}
