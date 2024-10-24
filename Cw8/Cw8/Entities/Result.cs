using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8.Entities
{
    public class Result
    {
        public Result(string message,bool isdone) 
        {
            Message = message;
            IsDone = isdone;
        }
        public string Message { get; set; }
        public bool IsDone { get; set; }
    }
}
