using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amozeshyar
{
    public class Students : Users
    {
        public StudentStateEnum StateEnum { get; set; }
        public int VahedAgeerToTake { get; set; }
        public List<Course> StudentClass { get; set; }
        public Students()
        {
            VahedAgeerToTake = VahedeMojaz(StateEnum);
        }
        private int VahedeMojaz(StudentStateEnum student)
        {
            if (student==StudentStateEnum.GradeA)
            {
                return 24;
            }
            else if (student==StudentStateEnum.Mshroot)
            {
                return 15;
            }
            return 20;
        }
        public void DecreasingVahed(int vahed)
        {
            VahedAgeerToTake -= vahed;
        }
    }
}
