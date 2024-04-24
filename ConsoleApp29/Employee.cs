using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Employee : Person
    {

        public int Salary { get; set; }

        public Employee( string name, string surname, int age, int salary) : base( name, surname, age)
        {
            Salary = salary;
        }

      
    }
}
