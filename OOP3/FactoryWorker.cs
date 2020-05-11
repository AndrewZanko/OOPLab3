using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    class FactoryWorker : Employee
    {
        public int rank;
        public int machineNumber;

        public FactoryWorker(float salary, string name, int rank, int machineNumber) : base (salary, name)
        {
            this.rank = rank;
            this.machineNumber = machineNumber;
        }
    }
}
