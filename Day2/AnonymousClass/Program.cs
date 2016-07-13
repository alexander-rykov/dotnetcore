using System;

namespace AnonymousClass
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var personOne = new { Name = "Sam", Age = 30 };
            var personTwo = new { Name = "Sam", Age = 30 };

            Console.WriteLine(personOne == personTwo); // false
            Console.WriteLine(personOne.Equals(personTwo)); // true
            Console.WriteLine(Object.ReferenceEquals(personOne, personTwo)); // false

            var personaOne = new Person { Name = "Max", Age = 30 };
            var personaTwo = new Person { Name = "Max", Age = 30 };
            Console.WriteLine(personaOne == personaTwo); // false
            Console.WriteLine(personaOne.Equals(personaTwo)); // false
            Console.WriteLine(Object.ReferenceEquals(personaOne, personaTwo)); // false
        }
    }
}
