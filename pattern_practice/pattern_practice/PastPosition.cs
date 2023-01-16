using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_practice
{
    public class PastPosition
    {
        public String Name { get; set; }
        public Department Department { get; set; }
        public PastPosition(String position, Department dep)
        {
            Name = position;
            Department = dep;
        }
    }
}
