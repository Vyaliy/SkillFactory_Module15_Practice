using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var IECollection = from item in classes
                             from student in item.Students
                             select student;
            //var another = classes.SelectMany(item => item.Students);
            return IECollection.ToArray();

        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}