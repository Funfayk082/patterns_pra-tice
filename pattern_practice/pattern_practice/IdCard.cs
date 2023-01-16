using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_practice
{
    public class IdCard
    {
        public IdCard(int n)
        {
            Number = n;
        }

        public int Number { get; protected set; }
        public DateTime DateExpire { get; protected set; }
    }
}
