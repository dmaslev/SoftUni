using System;

namespace _01.Persons
{
    class Person
    {
        public string name;

        public int age;

        public string email;

        public Person(string name, int age, string email)
        {
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100 )
                {
                    throw new ArgumentException("Enter valid age");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Email is invalid");
                }
                this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email ?? "...");
        }
    }
}
