using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<int> range9 = Enumerable.Range(1, 100).ToList();
            int range2 = range9.Count(c => c % 2 ==0);
            
                Console.WriteLine("LEWIS {0}",range2);

            int[] number8 = new int[100];
            for (int i = 0; i < number8.Length; i++)
            {

                number8[i] = i + 1;



                if (number8[i] % 2 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number8[i] % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (number8[i] % 2==0 && number8[i] % 3 ==0)
                {
                    Console.WriteLine("Fizz BUzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }







            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> result = numbers.Where(number => number % 2 == 0).ToList();

            var r = (from n in numbers
                     where n % 2 == 0
                     select n).ToList();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(new string('-', 20));

            List<int> nums = Enumerable.Range(1, 70).ToList();

            List<int> numere = nums.Where(number => number >= 25 && number <= 50).ToList();
            for (int i = 0; i < numere.Count; i++)
            {
                Console.WriteLine(numere[i]);
            }
            Console.WriteLine(new string('-', 20));





            int[] numere1 = Enumerable.Range(1, 30).ToArray();
            List<int> num2 = numere1.Select(number => number * number).ToList();

            foreach (var item in num2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));



            string[] cities = { "Rome", "London", "Amsterdam", "Parris", "Luxembourg" };
            List<string> city = cities.Where(c => c[0] == 'L').ToList();

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));


            bool hasCityThatStartsWithA = cities.Any(c => c[0] == 'A');
            Console.WriteLine(hasCityThatStartsWithA);

            Console.WriteLine(new string('-', 20));


            int howManyStartWithL = cities.Count(c => c[0] == 'L');
            Console.WriteLine(howManyStartWithL);

            Console.WriteLine(new string('-', 20));

            List<int> letterPerWord = cities.Select(c => c.Length).ToList();

            foreach (var item in letterPerWord)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(new string('-', 20));


            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Age= 19, Name = "John"},
                new Employee(){Age = 29, Name = "Michael"},
                new Employee(){Age = 39, Name = "Dan"},
                new Employee(){Age = 59, Name = "Kim"},
                new Employee(){Age = 59, Name = "Sam"},
                new Employee(){Age = 24, Name = "Nick"},
                new Employee(){Age = 45, Name = "Kevin"},
                new Employee(){Age = 43, Name = "Dvane"},
                new Employee(){Age = 54, Name = "Max"},
                new Employee(){Age = 47, Name = "Ion"},
            };



            List<Employee> employeesOver30 = employees.Where(employee => employee.Age > 30).ToList();
            List<string> names3 = employees.Select(employe => employe.Name).ToList();
            Employee employeeM = employees.FirstOrDefault(employee => employee.Name[0] == 'M');
            Employee employeeN = employees.LastOrDefault(employee => employee.Name[0] == 'M');

            double averageAge = employees.Average(employee => employee.Age);


            //foreach (Employee employee in employees)
            //{
            //    if(employee.Age >= 30)
            //    {
            //        employeesOver30.Add(employee);
            //    }
            //}



            foreach (Employee employee in employeesOver30)
            {
                Console.WriteLine(string.Format("Name: {0} , Age: {1}", employee.Name,employee.Age));
            }


            List<int> age = employees.Select(employee => employee.Age).ToList();
            List<string> nume = employees.Select(employee => employee.Name).ToList();

            int totalAge = employees.Sum(employee => employee.Age);

            Employee first = employees.FirstOrDefault();

            Employee firstOver30 = employees.FirstOrDefault(employee => employee.Age > 30);

            Employee lastOver30 = employees.LastOrDefault(employee => employee.Age > 30);
            
            double averageAge1 = employees.Average(employee => employee.Age);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
