using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    public abstract class Employee
    {
        public float salary;
        public string Name;

        public Employee(float salary, string name)
        {
            this.salary = salary;
            this.Name = name;
        }
    }
}
