using System;
using UniversityApp;

class Faculty : Person
    {
        public string EmpID { get; set; }
        public string Department { get; set; }

        public Faculty(string firstName, 
                       string lastName, 
                       string empID, 
                       string department, 
                       string street, 
                       string city, 
                       string telephone)
            : base(firstName, lastName, street, city, telephone)
        {
            EmpID = empID;
            Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + $", Employee ID: {EmpID}, Department: {Department}";
        }
    }

class Staff : Person
    {
        public string EmpID { get; set; }
        public string Department { get; set; }

        public Staff(string firstName, 
                     string lastName, 
                     string empID, 
                     string department, 
                     string street, 
                     string city, 
                     string telephone)
            : base(firstName, lastName, street, city, telephone)
        {
            EmpID = empID;
            Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + $", Employee ID: {EmpID}, Department: {Department}";
        }
    }
    
    class LabManager : Staff
    {
        public LabManager(string firstName, 
                          string lastName, 
                          string empID, 
                          string department, 
                          string street, 
                          string city, 
                          string telephone)
            : base(firstName, lastName, empID, department, street, city, telephone) { }
    }

    class FullTimeFaculty : Faculty
    {
        public string Rank { get; set; }

        public FullTimeFaculty(string firstName, 
                               string lastName, 
                               string empID, 
                               string department, 
                               string rank, 
                               string street,
                               string city, 
                               string telephone)
            : base(firstName, lastName, empID, department, street, city, telephone)
        {
            Rank = rank;
        }

        public override string ToString()
        {
            return base.ToString() + $", Rank: {Rank}";
        }
    }

    class PartTimeFaculty : Faculty
    {
        public PartTimeFaculty(string firstName, 
                               string lastName, 
                               string empID, 
                               string department, 
                               string street, 
                               string city, 
                               string telephone)
            : base(firstName, lastName, empID, department, street, city, telephone) { }
    }

    class Secretary : Staff
    {
        public Secretary(string firstName, 
                         string lastName, 
                         string empID, 
                         string department, 
                         string street, 
                         string city, 
                         string telephone)
            : base(firstName, lastName, empID, department, street, city, telephone) { }
    }
