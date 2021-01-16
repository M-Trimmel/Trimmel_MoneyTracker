using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimmel_MoneyTracker
{
    class Person
    {
        internal string Vorname { get; set; }
        internal int Age { get; set; }
        internal int Money { get; set; }



        public Person(string name, int age, int money)
        {
            Vorname = name;
            Age = age;
            Money = money;
        }
    }
}
