using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimmel_MoneyTracker
{
    class Person
    {

        internal int Alter { get; set; }
        internal string Vorname { get; set; }
        internal int Money { get; set; }



        public Person(string name, int alter, int money)
        {
            Alter = alter;
            Vorname = name;
            Money = money;
        }
    }
}
