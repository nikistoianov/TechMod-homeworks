using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            int nums = int.Parse(Console.ReadLine());
            //int nums = 1;
            for (int i = 0; i < nums; i++)
            {
                students.Add(ConvertInputToStudent(Console.ReadLine()));
                //students.Add(ConvertInputToStudent("Ani 5.50 5.25 6.00"));
            }

            foreach (Student student in students.OrderBy(x => x.Name).ThenBy(x => -x.AverageGrade).Where(x => x.AverageGrade >= 5))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:0.00}");
            }
        }

        private static Student ConvertInputToStudent(string inputString)
        {
            string[] arr = inputString.Split();
            string name = arr[0];
            List<double> grades = arr.Skip(1).Select(double.Parse).ToList();
            Student student = new Student() { Name = name, Grades = grades};
            return student;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade {
            get { return Grades.Average(); }
        }
    }

}
