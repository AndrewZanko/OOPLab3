using System;

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
            Name = name;
        }
    }
}
