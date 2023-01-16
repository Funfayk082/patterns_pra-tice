using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_practice
{
    public class Room
    {
        public int Number { get; protected set; }
        public Room(int n)
        {
            Number = n;
        }
    }
}
