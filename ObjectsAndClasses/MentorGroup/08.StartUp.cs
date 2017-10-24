using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Program
    {
        static void Main()
        {
            var students = new SortedDictionary<string, Student>();
            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                InputStudentDates(students, input);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of comments")
            {
                InputStudentComments(students, input);
                input = Console.ReadLine();
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.dates.OrderBy(x => x))
                {                    
                    //string dateString = string.Format(date, "dd/MM/yyyy");
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }

        private static void InputStudentComments(SortedDictionary<string, Student> students, string input)
        {
            string[] arr = input.Split('-');
            string studentName = arr[0], comment = arr[1];
            if (students.ContainsKey(studentName))
            {
                //if (students[studentName].comments == null)
                //{
                //    students[studentName].comments = new List<string>();
                //}
                students[studentName].comments.Add(comment);
            }
        }

        private static void InputStudentDates(SortedDictionary<string, Student> students, string input)
        {
            string[] arr = input.Split();
            string studentName = arr[0];
            List<DateTime> dates = new List<DateTime>();
            if (arr.Length > 1)
            {
                dates = arr[1].Split(',').Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
            }
            //string[] dates = arr.Length > 1 ? arr[1].Split(',') : null;

            if (!students.ContainsKey(studentName))
            {
                Student student = new Student() { comments = new List<string>()};
                student.dates = dates;
                //student.dates = dates.Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                students[studentName] = student;
            }
            else
            {
                var newDates = students[studentName].dates.Concat(dates).ToList();
                students[studentName].dates = newDates;
            }
        }
    }

    public class Student
    {
        public List<string> comments { get; set; }
        public List<DateTime> dates { get; set; }
    }
}
