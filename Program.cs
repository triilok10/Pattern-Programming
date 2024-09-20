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
            for (x = 1; x <= num; x++)
            {
                for (y = 1; y <= x; y++)

                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();



            //Square Pattern Printing Code
            int a;
            int b;
            int side;

            Console.WriteLine("Write side ");
            side = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= side; a++)
            {
                for (b = 1; b <= side; b++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            //Rectangle Pattern Programming

            int breadth;
            int length;

            int len;
            int brth;

            Console.WriteLine("Write Breadth Side");
            len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Length Side");
            brth = Convert.ToInt32(Console.ReadLine());

            for (breadth = 1; breadth <= brth; breadth++)
            {
                for (length = 1; length <= len; length++)
                {
                    Console.Write(" + ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            int starNo;
            Console.WriteLine("Write Pyramid Side:");
            starNo = Convert.ToInt32(Console.ReadLine());
            int space = starNo - 1;

            for (int i = 1; i <= starNo; i++)
            {
             
                for (int j = 1; j <= space; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                space--;
            }

            Console.ReadLine();
        }

    }
}


