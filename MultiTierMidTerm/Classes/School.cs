using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiTierMidTerm.Classes
{
    internal class School
    {
        static void Main(string[] args)
        {
            string filePath = @".\\student.txt";
            Students students = new Students();
            Teachers teachers = new Teachers();
            while (true)
            {
                MainMenu();
            }

            //method
            void MainMenu()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the epic school management system design by and for cool people ONLY!!");
                    Console.WriteLine("Please tell me your select:\n");
                    Console.WriteLine(
/*DONE*/                        "1 - Add Student\n" +
/*DONE*/                        "2 - Add Teacher\n" +
/*DONE*/                        "3 - Remove Student\n" +
/*DONE*/                        "4 - Add Balance To Student Profile\n" +
/*DONE*/                        "5 - Deduct Balance To Student Profile\n" +
/*DONE*/                        "6 - Change Student Cohort Number\n" +
/*DONE*/                        "7 - Change A Teacher's Experience Amount\n" +
/*DONE*/                        "8 - Increment The Teacher Hours\n" + 
/*DONE*/                        "9 - Decrement The Teacher Hours\n" +
/*DONE*/                        "10 - Print All Students\n" +
/*DONE*/                        "11 - Print All Teachers\n" +
/*DONE*/                        "12 - Find Teacher With Above 5 Years Of Experience\n" +
/*DONE*/                        "13 - Write All Registered Student To File\n" +              
/*DONE*/                        "0 - Quit\n");
                    try
                    {
                        string userInput = Console.ReadLine();
                        Console.Clear();
                        int choice = Convert.ToInt32(userInput);
                        switch (choice)
                        {
                            case 1:
                                //1 - Add Student
                                AddStudent();
                                break;
                            case 2:
                                //2 - Add Teacher
                                AddTeacher();
                                break;
                            case 3:
                                //3 - Remove Student
                                RemoveStudentFromTheSemester();
                                break;
                            case 4:
                                //4 - Add Balance To Student Profile
                                while (true) {
                                    Console.WriteLine("4 - Add Balance To Student Profile\n");
                                    Console.WriteLine("Please enter the amount first, then the student ID will be asked.");
                                    userInput = Console.ReadLine();
                                    try
                                    {
                                        choice = Convert.ToInt32(userInput);
                                        AddBalanceToStudentProfile(choice);
                                        break;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("================ ERROR CODE ================");
                                        Console.WriteLine(e);
                                        Console.WriteLine("================ ERROR CODE ================");
                                        Console.WriteLine("\n\nPlease only enter a number\npress enter to continue...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }
                                break;
                            case 5:
                                //5 - Deduct Balance To Student Profile
                                while (true)
                                {
                                    Console.WriteLine("5 - Deduct Balance To Student Profile\n");
                                    Console.WriteLine("Please enter the amount first, then the student ID will be asked.");
                                    userInput = Console.ReadLine();
                                    try
                                    {
                                        choice = Convert.ToInt32(userInput);
                                        DeductBalanceFromStudentProfile(choice);
                                        break;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("================ ERROR CODE ================");
                                        Console.WriteLine(e);
                                        Console.WriteLine("================ ERROR CODE ================");
                                        Console.WriteLine("\n\nPlease only enter a number\npress enter to continue...");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                }

                                break;
                            case 6:
                                //Change Student Cohort Number
                                Console.WriteLine("6 - Change Student Cohort Number\n");
                                    Console.WriteLine("Please enter the new cohort number:");
                                    userInput = Console.ReadLine();
                                    ChangeStudentCohortNumber(userInput);
                                break;
                            case 7:
                                //7 - Change A Teacher's Experience Amount
                                Console.WriteLine("7 - Change A Teacher's Experience Amount\n");
                                Console.WriteLine("Please enter the amount of experience to add in month:\n");
                                userInput = Console.ReadLine();
                                try
                                {
                                    choice = Convert.ToInt32(userInput);
                                    IncrementTheTeacherExperience(choice);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("================ ERROR CODE ================");
                                    Console.WriteLine(e);
                                    Console.WriteLine("================ ERROR CODE ================");
                                    Console.WriteLine("\n\nPlease only enter numbers.\n");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                            case 8:
                                //8 - Increment The Teacher Hours
                                Console.WriteLine("8 - Increment The Teacher Hours\n");
                                Console.WriteLine("Please enter the amount of hours to add:\n");
                                userInput = Console.ReadLine();
                                try
                                {
                                    choice = Convert.ToInt32(userInput);
                                    IncrementTheTeacherHours(choice);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("================ ERROR CODE ================");
                                    Console.WriteLine(e);
                                    Console.WriteLine("================ ERROR CODE ================");
                                    Console.WriteLine("\n\nPlease only enter numbers.\n");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                            case 9:
                                //9 - Decrement The Teacher Hours
                                Console.WriteLine("9 - Decrement The Teacher Hours\n");
                                Console.WriteLine("Please enter the amount of hours to remove:\n");
                                userInput = Console.ReadLine();
                                try
                                {
                                    choice = Convert.ToInt32(userInput);
                                    DecrementTheTeacherHours(choice);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("================ ERROR CODE ================");
                                    Console.WriteLine(e);
                                    Console.WriteLine("================ ERROR CODE ================");
                                    Console.WriteLine("\n\nPlease only enter numbers.\n");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                            case 10:
                                //10 - Print All Students
                                PrintAllStudentsList();
                                break;
                            case 11:
                                //11 - Print All Teachers
                                PrintAllTeachersList();
                                break;
                            case 12:
                                //12 - Find Teacher With Above 5 Years Of Experience
                                FindTeacherWithAboveFiveYearsExperience();
                                break;
                            case 13:
                                SaveStudentsInformationIntoFile();
                                break;
                            case 0:
                                //0 - Quit
                                Environment.Exit(0);
                                break;
                        }
                    }
                    catch(Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine(e);
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine("\n\nPlease only enter a number between 0 and 10\npress enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
            }
            void AddStudent()
            {
                string studentID;
                string firstName;
                string lastName;
                int departmentCode;
                string cohortNumber;
                double balance;
                string semesterID;

                string userInput;

                //StudentID
                do
                {
                    Console.WriteLine("1 - Add Student\n");
                    Console.WriteLine("Please enter the student ID:\n");
                    studentID = Console.ReadLine();

                } while (!StudentVerifier(studentID));

                //FirstName and LastName
                while (true) {
                    Console.WriteLine("Please enter the first name:\n");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Please enter the last name:\n");
                    lastName = Console.ReadLine();
                    if(firstName.Length + lastName.Length > 35)
                    {
                        Console.WriteLine("First name and Last name can't exceed 35 characters!");
                    }
                    else { break; }
                }

                //Dep Code
                while (true)
                {
                    Console.WriteLine("Please enter the department code:\n");
                    userInput = Console.ReadLine();
                    try
                    {
                        departmentCode = Convert.ToInt32(userInput);
                        break;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine(e);
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine("Please only enter a number.");
                    }
                }

                //CohortNumber
                Console.WriteLine("Please enter the cohort number:\n");
                cohortNumber = Console.ReadLine();

                //balance
                balance = 0;

                //semesterID
                Console.WriteLine("Please enter the semesterID:\n");
                semesterID = Console.ReadLine();

                Student student = new Student(studentID, cohortNumber, balance, semesterID, firstName, lastName, departmentCode);
                students.add(student);
                Console.WriteLine(student.toString());
                Console.WriteLine("Student successfully added!\nPress enter to go back to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }

            bool StudentVerifier (string studentID) {
                bool flag = true;
                    if (studentID.Length != 6)
                    {
                        Console.WriteLine("ID must be 6 digits exactly.");
                        flag = false;
                    }
                    else
                    {
                        foreach (Student student in students)
                        {
                            if (studentID == student.GetID())
                            {
                                Console.WriteLine("Student already exists in database...");
                                flag = false;
                            }
                        }
                    }
                return flag;
            }

            void AddTeacher() {
                string teacherID;
                string firstName;
                string lastName;
                int departmentCode;
                int yearsOfExperience;
                double teachingHours;

                //teacherID
                do
                {
                    Console.WriteLine("2 - Add Teacher\n");

                    Console.WriteLine("Please enter the Teacher ID:\n");
                    teacherID = Console.ReadLine();
                } while (!TeacherVerifier(teacherID));

                //firstname and lastname
                while(true)
                {
                    Console.WriteLine("Please enter the first name:\n");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Please enter the last name:\n");
                    lastName = Console.ReadLine();
                    if(firstName.Length + lastName.Length > 35)
                    {
                        Console.WriteLine("First name and Last name can't exceed 35 characters!");
                    }
                    else { break; }
                }

                //departmentCode
                while (true)
                {
                    Console.WriteLine("Please enter the department code:\n");
                    string userInput = Console.ReadLine();
                    try
                    {
                        departmentCode = Convert.ToInt32(userInput);
                        break;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine(e);
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine("\n\nPlease only enter numbers for department code.\n");
                    }
                }

                //experience
                while (true)
                {
                    Console.WriteLine("Please enter the amount of experience in month:\n");
                    string userInput = Console.ReadLine();
                    try
                    {
                        yearsOfExperience = Convert.ToInt32(userInput);
                        yearsOfExperience /= 12;
                        
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine(e);
                        Console.WriteLine("================ ERROR CODE ================");
                        Console.WriteLine("\n\nPlease only enter numbers.\n");
                    }
                }

                //teaching hours

                teachingHours = 0;
                Console.Clear();
                Teacher teacher = new Teacher(teacherID, yearsOfExperience, teachingHours, firstName, lastName, departmentCode);
                teachers.add(teacher);
                Console.WriteLine("Teacher successfully added!\nPress enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();

            }

            bool TeacherVerifier(string teacherID) {
                bool flag = true;
                if (teacherID.Length != 6)
                {
                    Console.WriteLine("ID must be 6 digits exactly.");
                    flag = false;
                }
                else
                {
                    foreach (Teacher teacher in teachers)
                    {
                        if (teacherID == teacher.GetID())
                        {
                            Console.WriteLine("Teacher already exists in database...");
                            flag = false;
                        }
                    }
                }
                return flag;
            }

            void RemoveStudentFromTheSemester() 
            {
                Console.WriteLine("3 - Remove Student\n");

                Console.WriteLine("Please enter the ID:\n");
                string userInput = Console.ReadLine();
                bool flag = false;
                            
                foreach (Student student in students)
                {
                    Console.WriteLine(student.GetID());
                    if(student.GetID() == userInput)
                    {
                        student.SetNull();
                        Console.WriteLine("Student successfully removed.");
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("No student was found!");
                }
                Console.WriteLine("Press enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();

            }

            void AddBalanceToStudentProfile(double amount) 
            {

                Console.WriteLine("Please enter the studentID:\n");
                string userInput = Console.ReadLine();
                bool flag = false;
                foreach(Student student in students)
                {
                    if(student.GetID() == userInput)
                    {
                        student.Balance += amount;
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Balance was successfully added to the student's profile");
                }
                else
                {
                    Console.WriteLine("No student found with the corresponding ID.");
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }        

            void DeductBalanceFromStudentProfile(double amount) 
            {

                Console.WriteLine("Please enter the studentID:\n");
                string userInput = Console.ReadLine();
                bool flag = false;
                foreach (Student student in students)
                {
                    if (student.GetID() == userInput)
                    {
                        student.Balance -= amount;
                        if(student.GetBalance() < 0)
                        {
                            student.Balance = 0;
                        }
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Balance was successfully deducted from the student's profile");
                }
                else
                {
                    Console.WriteLine("No student found with the corresponding ID");
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();

            }

            void ChangeStudentCohortNumber(string number) 
            {
                Console.WriteLine("Please enter the student ID:\n");
                string userInput = Console.ReadLine();
                bool flag = false;
                foreach(Student student in students)
                {
                    if(student.GetID() == userInput)
                    {
                        student.CohortNumber = number;
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Student's cohort number was changed successfully!");
                }
                else
                {
                    Console.WriteLine("No student was found.");
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }

            void IncrementTheTeacherExperience(int month) 
            {
                Console.WriteLine("7 - Change A Teacher's Experience Amount\n");
                Console.WriteLine("Please enter the teacher's ID:\n");
                string userInput = Console.ReadLine();
                bool flag = false;
                foreach(Teacher teacher in teachers)
                {
                    if(teacher.GetID() == userInput)
                    {
                        teacher.YearsOfExperience += (month / 12);
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Teacher's experience was updated!");
                }
                else
                {
                    Console.WriteLine("No teacher was found with this ID");
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }

            void IncrementTheTeacherHours(int hour)
            {
                Console.WriteLine("Please enter the teacher's ID:\n");
                string userInput = Console.ReadLine();
                bool flag = false;
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.GetID() == userInput)
                    {
                        teacher.TeachingHours += hour;
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Teacher's hours was updated!");
                }
                else
                {
                    Console.WriteLine("No teacher was found with this ID");
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }

            void DecrementTheTeacherHours(int hour) 
            {
                Console.WriteLine("Please enter the teacher's ID:\n");
                string userInput = Console.ReadLine();
                bool flag = false;
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.GetID() == userInput)
                    {
                        teacher.TeachingHours -= hour;
                        flag = true;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Teacher's hours was updated!");
                }
                else
                {
                    Console.WriteLine("No teacher was found with this ID");
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }

            void PrintAllStudentsList()
            {
                Console.WriteLine("10 - Print All Students\n");
                foreach(Student student in students)
                {
                    Console.WriteLine(student.toString());
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }

            void PrintAllTeachersList() 
            {
                Console.WriteLine("11 - Print All Teachers\n");
                foreach(Teacher teacher in teachers)
                {
                    Console.WriteLine(teacher.toString());
                }
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }

            void FindTeacherWithAboveFiveYearsExperience()
            {
                Console.WriteLine("12 - Find Teacher With Above 5 Years Of Experience\n");
                int counter = 0;
                foreach(Teacher teacher in teachers)
                {
                    Console.WriteLine(teacher.toString());
                    counter++;
                }
                Console.WriteLine("Found " + counter + " teachers");
                Console.WriteLine("\nPress enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }
            
            void SaveStudentsInformationIntoFile()
            {
                using(StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (Student student in students)
                    {
                        sw.WriteLine(student.toString());
                    }
                    Console.WriteLine("Students successfully saved to file.");
                    Console.WriteLine("\nFiles can be found in [PROJECT'S FOLDER]/bin/Debug\n");
                    Console.WriteLine("\nPress enter to return to the main menu...");
                    Console.ReadLine();
                }
            }
        }
    }
}
