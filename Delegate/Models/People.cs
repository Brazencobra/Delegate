using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class People
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public People(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }


    }
}
