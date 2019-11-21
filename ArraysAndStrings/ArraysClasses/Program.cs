using System;

namespace ArraysClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExample();
            //SecondExample();
            //ThirdExample();
            double[] weektemperature = { 8.7, 9, 6, 7, 4, 3, 1 };
            double[] NextNumber = new double[7];
            for (int i = weektemperature.Length ) 
            {

            }
            
        }

        private static void ThirdExample()
        {
            double[] weektemperature = { 8.7, 9, 6, 7, 4, 3, 1 };
            double[] reverted = new double[7];
            for (int i = 0; i < weektemperature.Length; i++)
            {
                reverted[i] = weektemperature[6 - i];

            }
            DisplayArray(reverted);
        }

        private static void SecondExample()
        {
            double[] weektemperatures = { 8.7, 9, 6, 7, 4, 3, 1 };

            double sum = 0;
            foreach (var temperature in weektemperatures)

                sum += temperature;
            double everagetemperature = sum / weektemperatures.Length;
            Console.WriteLine($" average temperature is {everagetemperature}");
        }

        private static void FirstExample()
        {
            int[] myarray = new int[3];
            DisplayArray(myarray);

               

            myarray[0] = 10;
            myarray[1] = 24;
            myarray[2] = 27;
            DisplayArray(myarray);

            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = myarray[i] + 3;
            }
            DisplayArray(myarray);
        }
    
         public static void DisplayArray<T>(T[] array)
        {
            foreach (var item in array)

                Console.WriteLine(item);
        }
    
    
    }
}
