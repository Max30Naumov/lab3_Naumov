using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task930
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = 5;
            int numCols = 5;

            Random random = new Random();

            double[,] array = new double[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    array[row, col] = Math.Round((random.NextDouble() * 20) - 10, 3); // от -10 до 10
                }
            }
            Console.WriteLine("Исходный массив:");
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Console.Write(array[row, col] + " ");
                }
                Console.WriteLine();
            }
            double sumFirstRow = 0.0;
            for (int col = 0; col < numCols; col++)
            {
                sumFirstRow += array[0, col];
            }
            Console.WriteLine($"Сумма первой элементов строки: {sumFirstRow}");
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (array[row, col] < sumFirstRow)
                    {
                        array[row, col] = sumFirstRow;
                    }
                }
            }

            Console.WriteLine("Измененный массив:");
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Console.Write(array[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
