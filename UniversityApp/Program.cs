using System;

namespace UniversityApp
{
    class Program
    {
        static void Main()
        {
            int choice;
            do
            {   Console.WriteLine("\nChoose the type of person details you want to enter:");
                Console.WriteLine("1. Part-Time Student");
                Console.WriteLine("2. Full-Time Undergraduate Student");
                Console.WriteLine("3. Graduate Student");
                Console.WriteLine("4. PhD Student");
                Console.WriteLine("5. Lab Manager");
                Console.WriteLine("6. Full-Time Faculty");
                Console.WriteLine("7. Part-Time Faculty");
                Console.WriteLine("8. Secretary");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice (1-9): ");
                choice = Convert.ToInt32(Console.ReadLine());

                // Asks the user's choice
                switch (choice)
                {
                    case 1:
                        EnterPartTimeStudentDetails();
                        break;
                    case 2:
                        EnterUnderGradStudentDetails();
                        break;
                    case 3:
                        EnterGradStudentDetails();
                        break;
                    case 4:
                        EnterPhDStudentDetails();
                        break;
                    case 5:
                        EnterLabManagerDetails();
                        break;
                    case 6:
                        EnterFullTimeFacultyDetails();
                        break;
                    case 7:
                        EnterPartTimeFacultyDetails();
                        break;
                    case 8:
                        EnterSecretaryDetails();
                        break;
                    case 9:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 9); 
        }

        static void EnterPartTimeStudentDetails()
        {
            string firstName, lastName, ssn, street, city, telephone;
            int test1, test2;

            Console.WriteLine("\nEnter Part-Time Student Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            ssn = GetInput("SSN");
            test1 = GetTestScore("Test 1 Score");
            test2 = GetTestScore("Test 2 Score");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            PartTimeStudent partTimeStudent = new PartTimeStudent(firstName, lastName, ssn, test1, test2, street, city, telephone);
            Console.WriteLine("\nPart-Time Student Details: ");
            Console.WriteLine(partTimeStudent);
        }

        static void EnterUnderGradStudentDetails()
        {
            string firstName, lastName, id, street, city, telephone;
            int test1, test2;

            Console.WriteLine("\nEnter Full-Time Undergraduate Student Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            id = GetInput("ID");
            test1 = GetTestScore("Test 1 Score");
            test2 = GetTestScore("Test 2 Score");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            UnderGradStudent underGradStudent = new UnderGradStudent(firstName, lastName, id, test1, test2, street, city, telephone);
            Console.WriteLine("\nFull-Time Undergraduate Student Details: ");
            Console.WriteLine(underGradStudent);
        }

        static void EnterGradStudentDetails()
        {
            string firstName, lastName, id, thesis, street, city, telephone;
            int test1, test2;

            Console.WriteLine("\nEnter Graduate Student Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            id = GetInput("ID");
            test1 = GetTestScore("Test 1 Score");
            test2 = GetTestScore("Test 2 Score");
            thesis = GetInput("Thesis Title");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            GradStudent gradStudent = new GradStudent(firstName, lastName, id, test1, test2, thesis, street, city, telephone);
            Console.WriteLine("\nGraduate Student Details: ");
            Console.WriteLine(gradStudent);
        }

        static void EnterPhDStudentDetails()
        {
            string firstName, lastName, id, thesis, advisor, dissertation, street, city, telephone;
            int test1, test2;

            Console.WriteLine("\nEnter PhD Student Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            id = GetInput("ID");
            test1 = GetTestScore("Test 1 Score");
            test2 = GetTestScore("Test 2 Score");
            thesis = GetInput("Thesis");
            advisor = GetInput("PhD Advisor");
            dissertation = GetInput("Dissertation");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            PhDStudent phdStudent = new PhDStudent(firstName, lastName, id, test1, test2, thesis, advisor, dissertation, street, city, telephone);
            Console.WriteLine("\nPhD Student Details: ");
            Console.WriteLine(phdStudent);
        }

        static void EnterLabManagerDetails()
        {
            string firstName, lastName, empID, department, street, city, telephone;

            Console.WriteLine("\nEnter Lab Manager Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            empID = GetInput("Employee ID");
            department = GetInput("Department");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            LabManager labManager = new LabManager(firstName, lastName, empID, department, street, city, telephone);
            Console.WriteLine("\nLab Manager Details: ");
            Console.WriteLine(labManager);
        }

        static void EnterFullTimeFacultyDetails()
        {
            string firstName, lastName, empID, department, rank, street, city, telephone;

            Console.WriteLine("\nEnter Full-Time Faculty Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            empID = GetInput("Employee ID");
            department = GetInput("Department");
            rank = GetInput("Rank (e.g., Professor, Assistant Professor)");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            FullTimeFaculty fullTimeFaculty = new FullTimeFaculty(firstName, lastName, empID, department, rank, street, city, telephone);
            Console.WriteLine("\nFull-Time Faculty Details: ");
            Console.WriteLine(fullTimeFaculty);
        }

        static void EnterPartTimeFacultyDetails()
        {
            string firstName, lastName, empID, department, street, city, telephone;

            Console.WriteLine("\nEnter Part-Time Faculty Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            empID = GetInput("Employee ID");
            department = GetInput("Department");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            PartTimeFaculty partTimeFaculty = new PartTimeFaculty(firstName, lastName, empID, department, street, city, telephone);
            Console.WriteLine("\nPart-Time Faculty Details: ");
            Console.WriteLine(partTimeFaculty);
        }

        static void EnterSecretaryDetails()
        {
            string firstName, lastName, empID, department, street, city, telephone;

            Console.WriteLine("\nEnter Secretary Details:");
            firstName = GetInput("First Name");
            lastName = GetInput("Last Name");
            empID = GetInput("Employee ID");
            department = GetInput("Department");
            street = GetInput("Street");
            city = GetInput("City");
            telephone = GetInput("Telephone");

            Secretary secretary = new Secretary(firstName, lastName, empID, department, street, city, telephone);
            Console.WriteLine("\nSecretary Details: ");
            Console.WriteLine(secretary);
        }
        static string GetInput(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine() ?? string.Empty;
        }
        static int GetTestScore(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
