using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTierMidTerm.Classes
{
    internal class Teacher:Person
    {
        //attributes
        string teacherID;
        int yearsOfExperience;
        double teachingHours;
        //constructors
        public Teacher() { }
        public Teacher(string teacherID, int yearsOfExperience, double teachingHours, string firstName, string lastName, int departmentCode) : base(firstName, lastName, departmentCode)
        {
            this.teacherID = teacherID;
            this.yearsOfExperience = yearsOfExperience;
            this.teachingHours = teachingHours;
        }
        //getters and setters
        public string TeacherID
        {
            get { return teacherID; }
            set { teacherID = value; }
        }
        public int YearsOfExperience
        {
            get { return yearsOfExperience; }
            set { yearsOfExperience = value; }
        }
        public double TeachingHours
        {
            get { return teachingHours; }
            set { teachingHours = value; }
        }
        //method
        public string toString()
        {
            return base.toString() + " " + TeacherID + " " + YearsOfExperience + " " + TeachingHours;
        }
        public string GetID()
        {
            return TeacherID;
        }
        public int GetYearsOfExperience()
        {
            return YearsOfExperience;
        }
        public double GetHours()
        {
            return TeachingHours;
        }
    }
}
