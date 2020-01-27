using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
                


                for (int i = 0; i < n; i++)
                {
                    for (int empty = 0; empty < n; empty++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine("~ ~ ~");

                }
                for (int i = 0; i < 3 * n + 6 - 1; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();

               
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < (3 * n + 6) - n - 2; j++)
                    {
                        Console.Write("~");
                    }
                    Console.Write("|");
                    for (int space = 0; space < n - 1; space++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }

                Console.Write("|");
                for (int a = 0; a < n; a++)
                {
                    Console.Write("~");
                }
                Console.Write("JAVA");
                for (int b = 0; b < n; b++)
                {
                    Console.Write("~");
                }
                Console.Write("|");
                for (int c = 0; c < n - 1; c++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();

                if (n % 2 == 0)
                {
                    for (int h = 0; h < n / 2 - 2; h++)
                    {
                        Console.Write("|");
                        for (int j = 0; j < (3 * n + 6) - n - 2; j++)
                        {
                            Console.Write("~");
                        }
                        Console.Write("|");
                        for (int space = 0; space < n - 1; space++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("|");
                        Console.WriteLine();

                    }
                }
                else
                {
                    for (int h = 0; h < n / 2 - 1; h++)
                    {
                        Console.Write("|");
                        for (int j = 0; j < (3 * n + 6) - n - 2; j++)
                        {
                            Console.Write("~");
                        }
                        Console.Write("|");
                        for (int space = 0; space < n - 1; space++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("|");
                        Console.WriteLine();

                    }
                }

                for (int d = 0; d < 3 * n + 6 - 1; d++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();

                for (int bottom = 0; bottom < n; bottom++)
                {
                    for (int i = 0; i < bottom; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\");
                    for (int i = 0; i < (3 * n + 6) - n - 2 - bottom * 2; i++)
                    {
                        Console.Write("@");
                    }
                    Console.Write("/");
                    Console.WriteLine();
                }

                for (int i = 0; i < 3 * n + 6 - n; i++)
                {
                    Console.Write("=");
                }

            }
        }
    }



