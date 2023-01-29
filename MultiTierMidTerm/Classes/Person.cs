using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTierMidTerm.Classes
{
    internal class Person
    {
        //class attributes
        string firstName;
        string lastName;
        int departmentCode;
        //constructors
        public Person() { }
        public Person(string firstName, string lastName, int departmentCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.departmentCode = departmentCode;
        }
        //getters and setters
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }
        //methods
        public string toString()
        {
            return FirstName + " " + LastName + " " + DepartmentCode;
        }
    }
}
