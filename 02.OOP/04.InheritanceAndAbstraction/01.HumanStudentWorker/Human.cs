using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        

    }
}
