using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firtstName, string lastName, string facultyNumber) 
            : base (firtstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length <5 || value.Length>10)
                {
                    throw new ArgumentException("Invalid faculty number");
                }
                this.facultyNumber = value;
            }
        }
    }
}
