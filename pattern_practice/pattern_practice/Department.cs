using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_practice
{
    public class Department : Unit, Menu
    {
        public string Name { get; set; }
        public List<Employee>? Employees;
        public void addEmployee(Employee e)
        {
            this.Employees.Add(e);
        }
        public List<Employee> getEmployees()
        {
            return this.Employees;
        }
        public void removeEmployee(Employee e)
        {
            this.Employees.Remove(e);
        }
    }
}
