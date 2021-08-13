using System;

namespace Pattern
{
    public class printPattern
    {
        public static void Main(string[] args)
        {
         // define string
         string str = "PRORIGO";

         Console.WriteLine("String : " + str);

         // To print odd index characters
         for (int i = 1; i <= str.Length; i += 2)
            {
                Console.WriteLine(str.Substring(0, i));
            }

           //To print pyramid pattern
            for (int j = 1; j <= str.Length; j+=2)
            {
                for(int k= str.Length-j; k>0;k-- )
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" "+ str.Substring(0,j)+" ");  // HERE IS THE PROBLEM 
            }

         Console.ReadLine();
        }
    }
}
