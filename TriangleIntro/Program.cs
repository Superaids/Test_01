﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var list = new List<int>();

                for (int i = 1; i <= 3;)
                {
                    Console.WriteLine($"Please input the {i} triangle side length in numbers only.");

                    int res;

                    if (Int32.TryParse(Console.ReadLine(), out res))
                    {
                        list.Add(res);
                        Console.WriteLine("Successfully added.");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Please only input numbers, without spaces or any other symbols");
                    }
                }

                if (list[0] == list[1])
                {
                    if (list[0] == list[2])
                    {
                        Console.WriteLine("Equilateral triangle detected");
                    }
                    else
                    {
                        Console.WriteLine("Isosceles triangle detected");
                    }
                }
                else
                {
                    Console.WriteLine("Scalene triangle detected");
                }
                Console.ReadKey();
            }
        }
    }
}
