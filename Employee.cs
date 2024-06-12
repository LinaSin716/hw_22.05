using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22._05
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public string PositionLevel { get; set; }
        public Employee(string Name, string Department, double Salary, string PositionLevel) 
        {
            this.Name = Name;
            this.Department = Department;
            this.Salary = Salary;
            this.PositionLevel = PositionLevel;
        }

       
    }
}
