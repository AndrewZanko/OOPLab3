﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    [Serializable]
    class StorageEmployee : Employee
    {
        public int storageNumber;
        public string storageType;

        public StorageEmployee(float salary, string name, int storageNumber, string storageType) : base(salary, name)
        {
            this.storageNumber = storageNumber;
            this.storageType = storageType;
        }
    }
}
