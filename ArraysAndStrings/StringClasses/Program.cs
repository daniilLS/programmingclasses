using System;

namespace StringClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecognizeGender();
            //IsYourNameLong();
            //string test="2,4,5,23,2";
            // int[] testResult = ConvertToArray(test);
            Console.WriteLine(ToSentence("thiS Sectence Has creppy CasTing"));
        }
        public static string ToSentence(string input)
        {
            string temp = input.ToLower();
            string firstletter = temp.Substring(0, 1).ToUpper();
            return firstletter + temp.Substring(1);
            

        }
        public static int[] ConvertToArray(string input)
        {
         
           string[] temp= input.Split(",");
            int[] result = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                result[i] = int.Parse(temp[i]);
            }
            return result;
        } 

        private static void IsYourNameLong()
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            if (name.Length > 5)
            {
                Console.WriteLine("your name is too long");
            }
            else
            {
                Console.WriteLine("name is short");
            }
        }

        private static void RecognizeGender()
        {
            Console.WriteLine("what's your name");
            string name = Console.ReadLine();
            if (name.EndsWith("a") && name != "Kuba")
            {
                Console.WriteLine("your a woman");
            }
            else
            {
                Console.WriteLine("your a man");
            }
        }
    }
}
