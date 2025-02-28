using System;

namespace UniversityApp
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }

        public Person(string firstName, 
                     string lastName, 
                     string street, 
                     string city, 
                     string telephone)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            City = city;
            Telephone = telephone;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Address: {Street}, {City}, Contact: {Telephone}";
        }
    }
}
