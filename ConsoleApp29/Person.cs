using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Person
    {
        private static int LastId = 1;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }


        public Person(string name, string surname, int age)
        {

            Id = LastId++;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
