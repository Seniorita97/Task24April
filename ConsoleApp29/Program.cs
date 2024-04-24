using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomCollection<Employee> customCollection = new CustomCollection<Employee>();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1) Employee elave Etmek");
                Console.WriteLine("2) İd-e gore Employee-ni tapib ekrana çixartmaq");
                Console.WriteLine("3) Butun Employeeler Ekrana çixartmaq");
                Console.WriteLine("0) Proqramdan çixmaq");

                Console.Write("\nSeçiminizi daxil edin: ");

                Console.WriteLine("Hansi Emeliyyat icra olunacaq?");
                int check;
                if (!int.TryParse(Console.ReadLine(), out check))
                {
                    Console.WriteLine("Duzgun bir seçim daxil edin.");
                    return;
                }


                switch (check)
                {
                    case 1:
                        Console.WriteLine("Employee add details");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();


                        Console.Write("Surname: ");
                        string surname = Console.ReadLine();

                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Salary: ");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        Employee emp = new Employee(name, surname, age, salary);

                        customCollection.addEmp(emp);
                        break;
                         
                    case 2:
                        Console.WriteLine("Id daxil edin");
      
                        int Id = Convert.ToInt32(Console.ReadLine());
                        if (!customCollection.getById(Id))
                        {
                            Console.WriteLine("Bele bir istifadeci yoxdur");
                        }
                        break;

                    case 3:

                        customCollection.getAllEmp();
                        break;

                    case 0:
                        
                            Console.Write("\nDavam etmek isteyirsiniz? (yes/no): ");
                            string choice = Console.ReadLine().ToLower();

                            if (choice == "no")
                            {
                                Console.WriteLine("Proqramdan çıxılır.");
                                Environment.Exit(0);
                            }
                        
                        break;

                    default:
                        Console.WriteLine("Düzgün bir seçim daxil edin.");
                        break;

                }

            }
        }
    }
}