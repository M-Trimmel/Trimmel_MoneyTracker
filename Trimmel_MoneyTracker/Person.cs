using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimmel_MoneyTracker
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Money { get; private set; }

        public Person(string name, int age, int money)
        {
            Name = name;
            Age = age;
            Money = money;
        }
    }
}
