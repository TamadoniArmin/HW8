using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class Course
    {
        public string ?NameofClass { get; set; }
        public int Capacity { get; set; }
        public int NumberOfClass { get; set; } = 30;
        public int? IdOfTeacher { get; set; }
        public Teacher? Teacher { get; set; }
        public string? NameOFTeacher { get; set; }//یه جا استفاده کردی برو درستش کن
        public int vahed { get; set; }
        public int PresentaionCode { get; set; }//کد اراءه
        public CategoryCourseEnum CategoryCourse { get; set; }
        public List<Users> RegisteredStudents { get; set; }
        public DateTime DateOfClass { get; set; }
        public List<Course> Pisniyas { get; set; }
        public bool ReduceCapacity()
        {
            if (Capacity==0 || Capacity<0)
            {
                Console.WriteLine("You cant do this!");
                return false;
            }
            else
            {
                Capacity--;
                return true;
            }
        }
        /*public void ChangeCapacity(int number)
        {
            Capacity = number;
        }*/
    }
}
