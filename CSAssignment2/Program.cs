using System;

namespace Pattern

{
    class Program
    {
        static void Main(string[] args)
        {
            // define string
            String str = "PRORIGO";

            Console.WriteLine("String : " + str);

            // To print odd index characters
            for (int i = 1; i <= str.Length; i += 2)
            {
                Console.WriteLine(str.Substring(0, i));
               
            }

         Console.ReadLine();
        }
    }
}
