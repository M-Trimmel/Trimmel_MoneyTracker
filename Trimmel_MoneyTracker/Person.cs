using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimmel_MoneyTracker
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Money { get; set; }

        public Person(string nameklein, int ageklein, int moneyklein)
        {
            Name = nameklein;
            Age = ageklein;
            Money = moneyklein;
        }
    }
}
