using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Pop
{
    class Person
    {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string FirstName
        {
            get => this.firstName;
        }
        public string LastName
        {
            get => this.lastName;
        }
    }
}
