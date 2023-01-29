using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTierMidTerm.Classes
{
    internal class Students:CollectionBase
    {
        public void add(Student student)
        {
            List.Add(student);
        }

        public Student this[int index]
        {
            get { return (Student)List[index]; }
            set { List[index] = value; }
        }
    }
}
