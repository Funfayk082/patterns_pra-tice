using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pattern_practice
{
    public class Department : Unit
    {
        public string Name { get; set; }
        List<Employee>? employees;
        
        public Department(){
            employees = new Employees();
        }
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
        
        public int PersCount()
        {
            return (this.Employees.Count());
        }
    }
}
