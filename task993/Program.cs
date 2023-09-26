using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task993
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = 7;
            int numCols = 7;

            Random random = new Random();

            int[,] matrix = new int[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    matrix[row, col] = random.Next(10); // от 0 до 9
                }
            }
            Console.WriteLine("Исходная матрица:");
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
           

            for (int row = 0; row < numRows; row++)
            {
                int maxElement = matrix[row, 0]; 
                int maxColIndex = 0;

                for (int col = 1; col < numCols; col++)
                {
                    if (matrix[row, col] > maxElement)
                    {
                        maxElement = matrix[row, col];
                        maxColIndex = col;
                    }
                }

                int temp = matrix[row, row];
                matrix[row, row] = maxElement;
                matrix[row, maxColIndex] = temp;
            }

            Console.WriteLine("Измененная матрица:");
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
