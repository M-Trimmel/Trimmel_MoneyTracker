using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimmel_MoneyTracker
{
    class Person
    {
        internal string Name { get; set; }
        internal int Alter { get; set; }
        internal int Money { get; set; }



        public Person(string name, int alter, int money)
        {
            Name = name;
            Alter = alter;
            Money = money;
        }
    }
}
