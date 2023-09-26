using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task937
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = 10;
            int numCols = 10;

            Random random = new Random();

            int[,] array = new int[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    array[row, col] = random.Next(10) ; // от -10 до 10
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

            Console.Write("Побочная диагональ начиная с элемента в правом верхнем углу (а): ");
            for (int i = 0; i < numRows; i++)
            {
                Console.Write(array[i, numCols - 1 - i] + " ");
            }
            Console.WriteLine();

            Console.Write("Побочная диагональ начиная с элемента в левом нижнем углу (б): ");
            for (int i = 0; i < numRows; i++)
            {
                Console.Write(array[numRows - 1 - i, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
