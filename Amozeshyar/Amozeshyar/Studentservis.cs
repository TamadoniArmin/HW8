using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class Studentservis : IStudentservis
    {
        public void ShowAllCourses()
        {
            int counter = 1;
            foreach (var Course in Repository.Classes)
            {
                Console.WriteLine(counter + " )");
                Console.WriteLine("Topic: " + Course.NameofClass);
                Console.WriteLine("Name of teacher: " + Course.NameOFTeacher);
                Console.WriteLine("Vahed : " + "(" + Course.vahed + ")");
                Console.WriteLine("Presentation Code: " + Course.PresentaionCode);
                Console.WriteLine("Date of Class: " + Course.DateOfClass);
                Console.WriteLine("------------------------------------");
                counter++;
            }
        }
        public bool TakeCourses(int StudentId, int CourseId)
        {
            foreach (var students in Repository.Students)
            {
                if (students.UserId == StudentId)
                {
                    foreach (var cours in Repository.Classes)
                    {
                        if (cours.PresentaionCode == CourseId)
                        {
                            if (students.VahedAgeerToTake - cours.vahed > 0)
                            {
                                Course course = new Course();
                                bool result = course.ReduceCapacity();
                                if (!result)
                                {
                                    return false;
                                }
                                else
                                {
                                    students.StudentClass.Add(cours);
                                    students.DecreasingVahed(cours.vahed);
                                    cours.RegisteredStudents.Add(students);
                                    //students.VahedAgeerToTake -= cours.vahed;//برسی شود که به دانش آموز بریزد
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        public void SeeSchedule(int StudentId)
        {
            foreach (var student in Repository.Students)
            {
                if (student.UserId == StudentId)
                {
                    int counter = 1;
                    foreach (var Course in student.StudentClass)
                    {
                        Console.WriteLine(counter + " )");
                        Console.WriteLine("Topic: " + Course.NameofClass);
                        Console.WriteLine("Name of teacher: " + Course.NameOFTeacher);
                        Console.WriteLine("Vahed : " + "(" + Course.vahed + ")");
                        Console.WriteLine("Presentation Code: " + Course.PresentaionCode);
                        Console.WriteLine("Date of Class: " + Course.DateOfClass);
                        Console.WriteLine("------------------------------------");
                        counter++;
                    }
                }
            }
        }
    }
}
