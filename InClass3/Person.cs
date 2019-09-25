using System;
using System.Collections.Generic;
using System.Text;

namespace InClass3
{
    class Person
    {
        public string firstName;
        public string lastName;

        public Person()
        {
            firstName = "John";
            lastName = "Doe";
        }
        public string getName()
        {
            return " " + firstName + " "+  lastName + " ";
        }
    }

}
