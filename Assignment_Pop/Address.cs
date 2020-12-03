using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Pop
{
    class Address
    {
        public int adress; // number of the street
        public string street;
        public string city;
        public string country;

        public Address(int adress, string street, string city, string country)
        {
            this.adress = adress;
            this.street = street;
            this.city = city;
            this.country = country;
        }
        public int Adress
        {
            get => this.adress;
            set => this.adress = value;
        }
        public string Street
        {
            get => this.street;
            set => this.street = value;
        }
        public string City
        {
            get => this.city;
            set => this.city = value;
        }
        public string Country
        {
            get => this.country;
            set => this.country = value;
        }
        // this method makes it possible to give the complete address
        public string FullAddress()
        {
            string fullAddress = Convert.ToString(adress) + " street " + street + ", " + city + ", " + country;
            return fullAddress;
        }
    }
}
