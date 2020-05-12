using System;

namespace OOP3
{
    [Serializable]
    class OfiiceEmployee : Employee
    {
        public string departmentName;
        public string position;

        public OfiiceEmployee(float salary, string name, string departmentName, string position) : base(salary, name)
        {
            this.departmentName = departmentName;
            this.position = position;
        }
    }
}
