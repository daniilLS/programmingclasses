using System;

namespace BasicClasses
{

    public class Person
    {
        private int Height;
        private int Weight;
        public Person(int height,int weight) // consrtructor
        {
            if (height <= 0 || weight <= 0)

                throw new ArgumentException("the height cannot be 0, should be possitive ");
           
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
        public int GetHeight()
        {
            return Height;
        }
        public int GetWeight()
        {
            return Weight;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person Daniil = new Person(179,60);
            
            Console.WriteLine($"bmi for {Daniil.GetWeight()} weight and  {Daniil.GetHeight()} hight is {Daniil.Bmi()}");
            Console.WriteLine($"classification is {Daniil.Classsification()}");
            Console.WriteLine($"recommendation is {Daniil.Recommendation()}");
        } 
    }
}
