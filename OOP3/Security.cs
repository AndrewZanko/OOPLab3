using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    class Security : Employee
    {
        public int serviceWeaponID;
        public int toleranceLevel;

        public Security(float salary, string name, int serviceWeaponID, int toleranceLevel) : base(salary, name)
        {
            this.serviceWeaponID = serviceWeaponID;
            this.toleranceLevel = toleranceLevel;
        }
    }
}
