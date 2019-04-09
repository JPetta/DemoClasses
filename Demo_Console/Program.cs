using Demo_Console.Math;
using System;

namespace Demo_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person
            {
                firstName = " John",
                lastName = " Smith"
            };
            john.introduce();
            Calculator calc1 = new Calculator();
            var result = calc1.Add(2, 6);
            Console.WriteLine(result);
        }
    }
}
