﻿using System;

namespace _01.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());


            for (int i = 1; i <= first; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 2; j <= second; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            for (int k = 1; k <= third; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
