using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ClassStudent
{
    static void Main()
    {
        // Problem 1.	Class Student

        List<Student> students = new List<Student>
            {
                new Student { FirstName = "Sara", LastName = "Mills", Age = 22, FacultyNumber = "209412", Phone = "0211111",
                            email = "sara.mills@gmail.com", Marks = new List<int> { 3, 6, 4, 2, 2, 2 }, GroupNumber = 1 },
                new Student { FirstName = "Daniel", LastName = "Carter", Age = 20, FacultyNumber = "211314", Phone = "+359211111",
                            email = "dcarter1@buzzfeed.com", Marks = new List<int> { 3, 5, 5 }, GroupNumber = 2 },
                new Student { FirstName = "Aaron", LastName = "Gibson", Age = 12, FacultyNumber = "209414", Phone = "+359 211111",
                            email = "cgray6@abv.bg", Marks = new List<int> { 3, 6, 4 }, GroupNumber = 1 },
                new Student { FirstName = "William", LastName = "Alexander", Age = 18, FacultyNumber = "222222", Phone = "1111111",
                            email = "aharper9@facebook.com", Marks = new List<int> { 3, 6, 4 }, GroupNumber = 1 },
                new Student { FirstName = "Mildred", LastName = "Hansen", Age = 21, FacultyNumber = "220615", Phone = "1111111",
                            email = "ffisheru@mayoclinic.com", Marks = new List<int> { 6, 6, 4 }, GroupNumber = 3 },
                new Student { FirstName = "Antonio", LastName = "Gonzalez", Age = 43, FacultyNumber = "215413", Phone = "1111111",
                            email = "lhartv@cnet.com", Marks = new List<int> { 5, 2, 4, 2 }, GroupNumber = 2 },
                new Student { FirstName = "Cheryl", LastName = "Gray", Age = 29, FacultyNumber = "204312", Phone = "1111111",
                            email = "gwatson1b@abv.bg", Marks = new List<int> { 3, 3, 4 }, GroupNumber = 3 }
            };
        //Problem 2.	Students by Group
        var groupTwoStudents =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

        Console.WriteLine("Student by Group:");
        foreach (var s in groupTwoStudents)
        {
            Console.WriteLine("{0} {1}, Group: {2}", s.FirstName, s.LastName, s.GroupNumber);
        }

        //Problem 3.	Students by First and Last Name
        var studetnButFirstAndLastName = 
            from student in students
            where student.FirstName.CompareTo(student.LastName) == -1
            select student;

        Console.WriteLine();
        Console.WriteLine("Student by First and Last Name:"); 
        foreach (var s in studetnButFirstAndLastName)
        {
            Console.WriteLine("First Name = {0}, Last Name = {1}", s.FirstName, s.LastName);
        }

        //Problem 4.	Students by Age
        var studentsByAge =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;
        Console.WriteLine();
        Console.WriteLine("Students by Age");
        foreach (var s in studentsByAge)
        {
            Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}", s.FirstName, s.LastName, s.Age);
        }

        //Problem 5.	Sort Students
        Console.WriteLine();
        Console.WriteLine("Sort students:");
        var sortStudentsLambda = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
        foreach (var st in sortStudentsLambda)
        {
            Console.WriteLine(st);
        }

        Console.WriteLine();
        Console.WriteLine("LINQ query:");

        var sortStudentsLINQ =
            from s in students
            orderby s.FirstName descending, s.LastName descending
            select s;

        foreach (var s in sortStudentsLINQ)
        {
            Console.WriteLine(s.FirstName + " " + s.LastName);
        }
        Console.WriteLine();

        //Problem 6.	Filter Students by Email Domain
        var emailFilterByDomain =
            from s in students
            where s.email.Contains("@abv.bg")
            select s;
        Console.WriteLine("Filter Students by Email Domain");
        foreach (var s in emailFilterByDomain)
        {
            Console.WriteLine("{0} {1} - {2}", s.FirstName, s.LastName, s.email);
        }
        Console.WriteLine();

        //Problem 7.	Filter Students by Phone
        var phoneFilter =
            from s in students
            where (s.Phone.Substring(0, 2) == "02" || s.Phone.Substring(0, 5) == "+3592" || s.Phone.Substring(0, 6) == "+359 2")
            select s;
        Console.WriteLine("Filter Student by Phone");
        foreach (var s in phoneFilter)
        {
            Console.WriteLine("{0} {1} - {2}", s.FirstName, s.LastName, s.Phone);
        }
        Console.WriteLine();

        //Problem 8.	Excellent Students
        var exellentStudents =
            from s in students
            where s.Marks.Contains(6)
            select new { name = string.Join(" ", s.FirstName, s.LastName), Marks = string.Join(" ", s.Marks) };
        Console.WriteLine("Exellent students:");
        foreach (var s in exellentStudents)
        {
            Console.WriteLine("Name: {0} - {1}", s.name, s.Marks);
        }
        Console.WriteLine();

        //Problem 9.	Weak Students
        var weakStudents =
            from s in students
            where (s.Marks.Count(x => x == 2) == 2)
            select new { name = string.Join(" ", s.FirstName, s.LastName), Marks = string.Join(" ", s.Marks) };
        Console.WriteLine("Weak students:");
        foreach (var s in weakStudents)
        {
            Console.WriteLine("Name: {0} - {1}", s.name, s.Marks);
        }
        Console.WriteLine();

        //Problem 10.	Students Enrolled in 2014
        var studentsEnrolledint2014 =
            from s in students
            where s.FacultyNumber.Substring(4, 2) == "14"
            select s;
        Console.WriteLine("Weak students:");
        foreach (var s in studentsEnrolledint2014)
        {
            Console.WriteLine("Name: {0} {1} - {2}", s.FirstName, s.LastName, s.FacultyNumber );
        }
    }
}

