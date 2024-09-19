using System;

namespace console
{
    class Program
    {

        static void Main(string[] args)
        {


            //Star Pattern Printing Code
            int x;
            int y;
            int num;
            Console.WriteLine("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (x = 0; x < num; x++)
            {
                for (y = 0; y < x; y++)

                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }

}


