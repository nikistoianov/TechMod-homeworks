using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main()
        {
            string[] inputLines = File.ReadAllLines(@"..\..\input.txt");
            int index = 0;
            File.WriteAllText(@"..\..\output.txt", "");

            while (index < inputLines.Length)
            {
                List<Student> students = new List<Student>();
                int nums = int.Parse(inputLines[index]);
               
                for (int i = 0; i < nums; i++)
                {
                    index++;
                    students.Add(ConvertInputToStudent(inputLines[index]));
                }

                foreach (Student student in students.OrderBy(x => x.Name).ThenBy(x => -x.AverageGrade).Where(x => x.AverageGrade >= 5))
                {
                    string result = $"{student.Name} -> {student.AverageGrade:0.00}";
                    Console.WriteLine(result);
                    File.AppendAllText(@"..\..\output.txt", result + Environment.NewLine);
                }
                File.AppendAllText(@"..\..\output.txt", Environment.NewLine);
                Console.WriteLine();

                index++;
            }            
        }

        private static Student ConvertInputToStudent(string inputString)
        {
            string[] arr = inputString.Split();
            string name = arr[0];
            List<double> grades = arr.Skip(1).Select(double.Parse).ToList();
            Student student = new Student() { Name = name, Grades = grades };
            return student;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get { return Grades.Average(); }
        }
    }

}
