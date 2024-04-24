using ConsoleApp29;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class CustomCollection<T> where T : Person
    {

        private static T[] values = new T[0];

        public CustomCollection()
        {

        }

        public void addEmp(T emp)
        {
            Array.Resize(ref values, values.Length + 1);
            values[values.Length - 1] = emp;
        }

        public bool getById(int id)
        {

            foreach (T emp in values)
            {
                if (emp.Id == id)
                {
                    Console.WriteLine($"Employee tapıldı: Id: {emp.Id}, Name: {emp.Name}, Surname: {emp.Surname}, Age: {emp.Age}");
                    return true;
                }
            }
            return false;
        }

        public void getAllEmp()
        {
            foreach (T emp in values)
            {
                Console.WriteLine($"Employee tapıldı: Id: {emp.Id}, Name: {emp.Name}, Surname: {emp.Surname}, Age: {emp.Age}");
            }
        }
    }

}