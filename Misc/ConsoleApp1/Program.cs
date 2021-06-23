using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(" ");

            int row = int.Parse(n[0]);
            int col = int.Parse(n[1]);

            //creates 2d array according to user input
            int[,] mat = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int nSearchedFor = int.Parse(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mat[i,j] == nSearchedFor)
                    {
                        Console.WriteLine("Position: " + i + ',' + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < row - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < col - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
