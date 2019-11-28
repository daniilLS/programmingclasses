using System;

namespace StringClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecognizeGender();
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
