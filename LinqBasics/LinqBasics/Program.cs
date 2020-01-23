using System;
using System.Linq;
namespace LinqBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = { 3, 4, 2, 4, 5, 4.5, 3.2, 5.7 };
            // Featureone(grades);
            //Features2(grades);
            string[] names = { "eve", "ivan", "Boris", "Katerina" };
            var sorted = names.OrderBy(x => x);
            foreach (var item in sorted)
            {
                 Console.WriteLine(item);
            }
            var namesExit = names.Any(x => x.EndsWith("a"));
            var allnames = names.All(x => x.Length > 1);
            
            

        }

        private static void Features2(double[] grades)
        {
            var mygoodgrades = grades
                              .Where(x => x > 3.5)
                              .OrderByDescending(x => x);

            var myfirstGrade = grades.First();
            var myLastGrade = grades.Last();
            var howManyGrades = grades.Count(x => x == 2);
            var ShowEverythree = grades.Skip(3).Take(3);
            var Projectiongrades = grades
                .Where(x => x > 2)
                .Select(x => x * 2)
                .OrderBy(x => x);
            foreach (var item in Projectiongrades)
                Console.WriteLine(item);
        }

        private static void Featureone(double[] grades)
        {
            double max = grades.Max();
            var positiveGrades = grades.Where(x => x > 2);
            foreach (var grade in positiveGrades)
            {
                Console.WriteLine(grade);
            }
            var evenGrades = grades.Where(x => x % 2 == 0);
            foreach (var grade in evenGrades)
                Console.WriteLine(grade);


            Console.WriteLine(grades.Average());
        }

    }
}
