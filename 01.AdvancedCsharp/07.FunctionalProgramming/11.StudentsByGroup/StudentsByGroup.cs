using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentsByGroup
{
    static void Main()
    {
        List<Student> students = new List<Student>
            {
                new Student { FirstName = "Sara", LastName = "Mills", Age = 22, FacultyNumber = "209412", Phone = "0211111",
                            email = "sara.mills@gmail.com", Marks = new List<int> { 3, 6, 4, 2, 2, 2 }, GroupName = "Group 1"},
                new Student { FirstName = "Daniel", LastName = "Carter", Age = 20, FacultyNumber = "211314", Phone = "+359211111",
                            email = "dcarter1@buzzfeed.com", Marks = new List<int> { 3, 5, 5 }, GroupName = "Group 1" },
                new Student { FirstName = "Aaron", LastName = "Gibson", Age = 12, FacultyNumber = "209414", Phone = "+359 211111",
                            email = "cgray6@abv.bg", Marks = new List<int> { 3, 6, 4 }, GroupName = "Group 1" },
                new Student { FirstName = "William", LastName = "Alexander", Age = 18, FacultyNumber = "222222", Phone = "1111111",
                            email = "aharper9@facebook.com", Marks = new List<int> { 3, 6, 4 }, GroupName = "Group 2" },
                new Student { FirstName = "Mildred", LastName = "Hansen", Age = 21, FacultyNumber = "220615", Phone = "1111111",
                            email = "ffisheru@mayoclinic.com", Marks = new List<int> { 6, 6, 4 }, GroupName = "Group 2" },
                new Student { FirstName = "Antonio", LastName = "Gonzalez", Age = 43, FacultyNumber = "215413", Phone = "1111111",
                            email = "lhartv@cnet.com", Marks = new List<int> { 5, 2, 4, 2 }, GroupName = "Group 2" },
                new Student { FirstName = "Cheryl", LastName = "Gray", Age = 29, FacultyNumber = "204312", Phone = "1111111",
                            email = "gwatson1b@abv.bg", Marks = new List<int> { 3, 3, 4 }, GroupName = "Group 3" }
            };

        var studentGroups =
                from s in students
                group s by s.GroupName;
        foreach (var studentGroupName in studentGroups)
        {
            Console.WriteLine("Group Name: {0}", studentGroupName.Key);
            foreach (var st in studentGroupName)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }
            Console.WriteLine();
        }
                
    }
}

