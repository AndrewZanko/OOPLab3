using System;

namespace OOP3
{
    [Serializable]
    class Сourier : Employee
    {
        public string auto;
        public string corierType;

        public Сourier(float salary, string name, string auto, string corierType) : base(salary, name)
        {
            this.auto = auto;
            this.corierType = corierType;
        }
    }
}
