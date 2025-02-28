using System;
using UniversityApp;
abstract class Student : Person
    {
        public int Test1 { get; set; }
        public int Test2 { get; set; }
        public string Id { get; set; }

        public Student(string firstName, 
                       string lastName, 
                       string id, 
                       int test1, 
                       int test2, 
                       string street, 
                       string city, 
                       string telephone)
            : base(firstName, lastName, street, city, telephone)
        {
            Id = id;
            Test1 = test1;
            Test2 = test2;
        }

        public virtual double ComputeGrade() => 0.45 * Test1 + 0.55 * Test2;

        public override string ToString()
        {
            return base.ToString() + $", ID: {Id}, Grade: {ComputeGrade()}";
        }
    }

     // Derived Student Classes
    class PartTimeStudent : Student
    {
        public PartTimeStudent(string firstName, 
                               string lastName, 
                               string ssNum, 
                               int test1, 
                               int test2, 
                               string street, 
                               string city, 
                               string telephone)
            : base(firstName, lastName, ssNum, test1, test2, street, city, telephone) { }
    }

    class UnderGradStudent : Student
    {
        public UnderGradStudent(string firstName, 
                                string lastName, 
                                string id, 
                                int test1, 
                                int test2, 
                                string street, 
                                string city, 
                                string telephone)
            : base(firstName, lastName, id, test1, test2, street, city, telephone) { }
    }

    class GradStudent : Student
    {
        public string Thesis { get; set; }

        public GradStudent(string firstName, 
                           string lastName, 
                           string id, 
                           int test1, 
                           int test2, 
                           string thesis, 
                           string street, 
                           string city, 
                           string telephone)
            : base(firstName, lastName, id, test1, test2, street, city, telephone)
        {
            Thesis = thesis;
        }

        public override string ToString()
        {
            return base.ToString() + $", Thesis: {Thesis}";
        }
    }


 class PhDStudent : GradStudent
    {
        public string PhDAdvisor { get; set; }
        public string Dissertation { get; set; }

        public PhDStudent(string firstName, 
                          string lastName, 
                          string id, 
                          int test1, 
                          int test2, 
                          string thesis, 
                          string phDAdvisor, 
                          string dissertation, 
                          string street, 
                          string city, 
                          string telephone)
            : base(firstName, lastName, id, test1, test2, thesis, street, city, telephone)
        {
            PhDAdvisor = phDAdvisor;
            Dissertation = dissertation;
        }

        public override double ComputeGrade() => 0.3 * Test1 + 0.7 * Test2;

        public override string ToString()
        {
            return base.ToString() + $", Advisor: {PhDAdvisor}, Dissertation: {Dissertation}, Adjusted Grade: {ComputeGrade()}";
        }
    }
