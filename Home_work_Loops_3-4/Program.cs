using System;

namespace Home_work_Loops_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //#3
            //  *
            // **
            //***
            Console.WriteLine("Enter rows count");

            int n = int.Parse(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
                for (int x = n; x > y; x--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= y; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //№ 4
            //***
            //**
            //*
            Console.WriteLine("Enter rows count");

            int c = int.Parse(Console.ReadLine());

            for (int d = 0; d < c; d++)
            {

                for (int x = c; x > d; x--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //№ 5
            //***
            // **
            //  *
            Console.WriteLine("Enter rows count");

            int f = int.Parse(Console.ReadLine());

            for (int y = 0; y < f; y++)
            {

                for (int x = 0; x <= y; x++)
                {
                    Console.Write(" ");
                }
                for (int x = f; x > y; x--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                                
            }
        }
    }
}
