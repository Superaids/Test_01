using System;
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
            bool cont = true;
            while (cont)
            {
                var list = new List<uint>();

                for (int i = 1; i <= 3;)
                {
                    Console.WriteLine($"Please input the {i} triangle side length in numbers only.");

                    uint res;

                    if (uint.TryParse(Console.ReadLine(), out res))
                    {
                        list.Add(res);
                        Console.WriteLine("Successfully added.");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Please only input numbers above 0, without spaces or any other symbols");
                    }
                }

                list = (from a in list
                               orderby a descending
                               select a).ToList();

                if ((list[1] ^ 2 * list[2] ^ 2) == (list[0] ^ 2) || list[0] == list[1] && list[1] == list[2])
                {
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
                }
                else
                {
                    Console.WriteLine($"Input of {list[0]}, {list[1]} and {list[2]} isn't a true triangle");
                }

                Console.WriteLine("Want to input another triangle? Y/N");

                bool finishing = true;
                while (finishing)
                {
                    switch (Console.ReadLine()?.ToLower())
                    {
                        case "y":
                            cont = true;
                            finishing = false;
                            break;
                        case "n":
                            cont = false;
                            finishing = false;
                            break;
                        default:
                            Console.WriteLine("Sorry, I didn't understand the input. Please write Y if you want to input another triangle. N if you want to stop");
                            break;
                    }
                }
            }
        }
    }
}
