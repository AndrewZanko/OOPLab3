using System;

namespace OOP3
{
    [Serializable]
    class Scientist : Employee
    {
        public string scienceDegree;
        public string researchArea;

        public Scientist(float salary, string name, string scienceDegree, string researchArea) : base(salary, name)
        {
            this.scienceDegree = scienceDegree;
            this.researchArea = researchArea;
        }
    }
}
