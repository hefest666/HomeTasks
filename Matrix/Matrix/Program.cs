using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = FillMatrix();
            ShowMatrix(matrix);
            ShowCalculating(matrix);

            Console.ReadLine();
        }

        static void Dye(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        static int[,] FillMatrix()
        {
            int[,] matrix = new int[10, 10];
            Random rand = new Random();

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }               

            return matrix;
        }
        static void ShowMatrix(int[,] matrix)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(matrix[i, j] % 2 == 0)
                    {
                        Dye(ConsoleColor.Magenta);                  
                    }                    
                    Console.Write(matrix[i, j] + "  ");
                    if (matrix[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.ResetColor();
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
        static void ShowCalculating(int[,] matrix)
        {
            Console.WriteLine();
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(matrix[j, i] % 2 == 0)
                    {
                        sum += matrix[j, i];
                    }
                }

                Dye(ConsoleColor.Green);
                Console.Write(sum);
                Console.ResetColor();
                if (sum < 100)
                {
                    Console.Write(" ");
                }
                Console.Write(" |");
                sum = 0;
            }
        }
    }
}
