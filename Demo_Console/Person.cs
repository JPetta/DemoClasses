using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Console
{
    class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            Console.WriteLine("My Name is" + firstName + lastName);
        }
    }
}
