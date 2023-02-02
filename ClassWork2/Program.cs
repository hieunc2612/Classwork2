using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number of person: ");
            var lines = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                System.Console.Write($"Enter the name of person: ");
                var name = Console.ReadLine();
                System.Console.Write($"Enter the age of person: ");
                var age = int.Parse(Console.ReadLine());
                System.Console.Write($"Enter the salary of person: ");
                var salary = decimal.Parse(Console.ReadLine());
                Person person = new Person(name, age, salary);
                people.Add(person);
                Console.WriteLine("----------------");
            }
            Console.ReadLine();
            foreach (var person in people)
            {
                System.Console.WriteLine(person);
                System.Console.WriteLine("------");
            }
            System.Console.WriteLine("---Sorted by name---");
            var sorted = people.OrderBy(p => p.Name).ThenBy(p => p.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, sorted));
        }
    }
}
