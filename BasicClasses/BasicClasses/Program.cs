using System;

namespace BasicClasses
{

    public class Person
    {
        public int Height;
        public int Weight;
        public Person(int height,int weight) // consrtructor
        {
            Height = height;
            Weight = weight;
        }
        public int Bmi()
        {
            return 10000 * Weight / (Height * Height);

        }
        public string Classsification()
        {
            int bmi = Bmi();
            if (bmi < 18)
                return "underweight";
            if (bmi < 24)
                return "normal";
            if (bmi < 30)
                return "overweight";
            return "obese";

        }
        public string Recommendation ()
        {
            int bmi = Bmi();
            if (bmi < 18)
                return "eat more";
            if (bmi < 24)
                return "good job";
            if (bmi < 30)
                return "eat less";
            return "stop eating";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person Daniil = new Person(179,60);
            
            Console.WriteLine($"bmi for {Daniil.Weight} weight and  {Daniil.Height} hight is {Daniil.Bmi()}");
            Console.WriteLine($"classification is {Daniil.Classsification()}");
            Console.WriteLine($"recommendation is {Daniil.Recommendation()}");
        } 
    }
}
