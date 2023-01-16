using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_practice
{
    public class Employee : Man
    {
        public string Position { get; set; }
        public IdCard Card { get; set; }
        public List<Room> Room { get; set; }
        public Department Department { get; set; }
        public List<PastPosition>? PastPosition { get; set; }

        public Employee(string n, string s, string p)
        {
            this.Name = n;
            this.Surname = s;
            this.Position = p;
        }

        public void DeleteRoom(Room r)
        {
            this.Room.Remove(r);
        }

        public void DeletePastPosition(PastPosition p)
        {
            this.PastPosition.Remove(p);
        }
    }
}
