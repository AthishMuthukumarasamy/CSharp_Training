using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    //Parent class
    internal class Student
    {
        protected int rollNo;
        protected string name;
        protected string className;
        protected int semester;
        protected string branch;

        public Student(int r, string n, string c, int s, string b)
        {
            rollNo = r;
            name = n;
            className = c;
            semester = s;
            branch = b;
        }

        public virtual void DisplayData()
        {
            Console.WriteLine("\nRoll No   : " + rollNo);
            Console.WriteLine("Name      : " + name);
            Console.WriteLine("Class     : " + className);
            Console.WriteLine("Semester  : " + semester);
            Console.WriteLine("Branch    : " + branch);
        }
    }
}