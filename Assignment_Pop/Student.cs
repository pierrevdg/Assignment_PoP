using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Pop
{
    class Student : Person
    {
        public string studentNumber;
        public int age;
        public Address address;
        public string fullName;
        public int[] scores;
        public double average;
        public string fullAddress;

        public Student(string firstName, string lastName, string studentNumber, int age, Address address, string fullName, int[] scores, double average, string fullAddress) : base(firstName, lastName)
        {
            this.studentNumber = studentNumber;
            this.age = age;
            this.address = address;
            this.fullName = firstName + " " + lastName;
            this.scores = scores;
            this.average = average;
            this.fullAddress = address.FullAddress();
        }
        public string StudentNumber
        {
            get => this.studentNumber;
            set => this.studentNumber = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
        public Address Address
        {
            get => this.address;
            set => this.address = value;
        }
        public string FullName
        {
            get => this.fullName;
        }
        public int[] Scores
        {
            get => this.scores;
            set => this.scores = value;
        }
        public double Average
        {
            get => this.average;
            set => this.average = value;
        }
        public string FullAddress
        {
            get => this.fullAddress;
            set => this.fullAddress = value;
        }
        public override string ToString()
        {
            return "Student : " + fullName + " is " + age + "\nStudent number : " + studentNumber + "\nAddress : " + fullAddress + "\nAverage : " + average;
        }
    }
}
