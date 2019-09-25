using System;
using System.Collections.Generic;
using System.Text;

namespace In_Class3rd
{
    class Employee
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Julian";
            person.Age = 33;
            person.HasPet = true;

            person.Greeting();
        }
    }
}

