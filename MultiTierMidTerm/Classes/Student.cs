using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTierMidTerm.Classes
{
    internal class Student:Person
    {
        //class attributes
        string studentID;
        string cohortNumber;
        double balance;
        string semesterID;

        //constructors
        public Student() { }
        public Student(string studentID, string cohortNumber, double balance, string semesterID, string firstName, string lastName, int departmentCode):base (firstName, lastName, departmentCode)
        {
            this.StudentID = studentID;
            this.CohortNumber = cohortNumber;
            this.Balance = balance;
            this.SemesterID = semesterID;
        }
        //getters and setters
        public string StudentID {
            get { return studentID; }
            set { studentID = value; }
        }
        public string CohortNumber
        {
            get { return cohortNumber; }
            set { cohortNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string SemesterID
        {
            get { return semesterID; }
            set { semesterID = value; }
        }

        //methods
        public string toString()
        {
            return base.toString() + " " + StudentID + " " + CohortNumber + " " + Balance + " " + SemesterID;
        }
        public string GetID()
        {
            return StudentID;
        }
        public string GetCohortNumber()
        {
            return CohortNumber;
        }
        public double GetBalance()
        {
            return Balance;
        }
        public void SetNull()
        {
            StudentID = null;
            CohortNumber = null;
            Balance = -1;
            SemesterID = null;
            FirstName = "REMOVED";
            LastName = null;
            DepartmentCode = -1;
        }
    }
}
