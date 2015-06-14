using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    class HumanStudentWorker
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Ysf", "sdgsdfg", "11111"),
                new Student("sdfg", "sdgf", "11112"),
                new Student("fdghdfh", "dfghfdh", "111100"),
                new Student("pfdhfdhesho", "dfhfdh", "54665"),
                new Student("fdfgh", "hhh", "55555"),
                new Student("pesho", "jjj", "456456"),
                new Student("too", "lazy", "34561"),
                new Student("to", "write", "43561"),
                new Student("proper", "names", "87657"),
                new Student("pesho", "pesho", "34563"),
            };
            var sortedStudents = students.OrderBy(st => st.FacultyNumber);
            //foreach (var student in sortedStudents)
            //{
            //    Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.FacultyNumber);
            //}
            List<Worker> workers = new List<Worker>
            {
                new Worker("asdf", "sdgsdfg", 100, 1),
                new Worker("asg", "sdgdf", 400, 7),
                new Worker("ASDFSDF", "asdgag", 400, 8),
                new Worker("pfdghfdhesho","AFasg", 200, 5),
                new Worker("fdgfgh", "aaa", 1200, 8),
                new Worker("pgesho", "jjdfgj", 100, 4),
                new Worker("tgogo", "dg",  255, 6),
                new Worker("tgo", "wriggte", 480, 6),
                new Worker("prgoper", "ngames", 666, 6),
                new Worker("pegsho", "pgesho", 120, 1),
            };
            var sortedWorkers = workers.OrderByDescending(st => st.MoneyPerHour());
            //foreach (var worker in sortedWorkers)
            //{
            //    Console.WriteLine("{0} {1} - payment per hour: {2:c2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            //}

            List<Human> all = new List<Human>();
            all.AddRange(students);
            all.AddRange(workers);
            

            // The best output ever
            var sortedFinal = all.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);
            foreach (var person in all)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }

        }
    }
}
