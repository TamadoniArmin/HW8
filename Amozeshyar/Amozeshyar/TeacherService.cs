using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class TeacherService : ITeacherService
    {
        public void AddCourse(int teacherId,string Name, DateTime timeofclass, int vahed)
        {
            Course course = new Course();
            course.NameofClass = Name;
            course.DateOfClass = timeofclass;
            course.vahed = vahed;
            foreach (var teacher in Repository.Teachers)
            {
                if (teacher.UserId==teacherId)
                {
                    course.Teacher = teacher;//اینم بعدا دوباره نکاه کن
                    teacher.Courses.Add(course);
                }
            }
            bool action = false;
            do
            {
                Console.WriteLine("Please enter the pisniyas");
                Studentservis studentservis = new Studentservis();
                studentservis.ShowAllCourses();
                Console.WriteLine("Please enter the presentation code: ");
                int entercode = int.Parse(Console.ReadLine());
                foreach (var co in Repository.Classes)
                {
                    if (entercode == co.PresentaionCode)
                    {
                        course.Pisniyas.Add(co);
                    }
                }
                Console.WriteLine("press (+) if you want to enter another course.");
                Console.WriteLine("press (-) if you want to continiue.");
                char res = Convert.ToChar(Console.ReadLine());
                if (res=='-')
                {
                    action = true;
                }
            } while (!action);
            Repository.Classes.Add(course);
        }
        public void SeeStudents(int TeacherId)
        {
            foreach (var course in Repository.Classes)
            {
                if (course.IdOfTeacher==TeacherId)
                {
                    Console.WriteLine("*)");
                    Console.WriteLine(course.NameofClass+" : ");
                    foreach (var students in course.RegisteredStudents)
                    {
                        Console.WriteLine("- "+students.FirstName+" "+students.LastName);
                    }
                    Console.WriteLine("------------------------------");
                }
            }
        }
    }
}
