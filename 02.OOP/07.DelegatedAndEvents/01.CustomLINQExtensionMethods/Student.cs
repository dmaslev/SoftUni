using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.CustomLINQExtensionMethods
{
    class Student
    {
        private string name;
        private int grade;
        public Student(string name, int grade)
        {
            this.Grade = grade;
            this.Name = name;
        }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}
