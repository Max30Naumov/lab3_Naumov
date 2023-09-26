using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task956
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = 8;
            int numCols = 8;

            Random random = new Random();

            int[,] array = new int[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    array[row, col] = random.Next(10); // от 0 до 9
                }
            }

            Console.WriteLine("Исходний масив:");
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Console.Write(array[row, col] + "   ");
                }
                Console.WriteLine();
            }
            int sumThirdRow = 0;
            int rowToSum = 3; 
            for (int col = 0; col < array.GetLength(1); col++)
            {
                sumThirdRow += array[rowToSum, col];
            }
            Console.WriteLine("Сумма элементов третьей строки: " + sumThirdRow); 
            int sumSecondColumn = 0;
            int  colToSum = 2; 
            for (int row = 0; row < array.GetLength(0); row++)
            {
                sumSecondColumn += array[row, colToSum];
            }
            Console.WriteLine("Сумма элементов второго столбца: " + sumSecondColumn);
      
            int s;
            do
            {
                Console.Write("Введите значение s: ");
                if (int.TryParse(Console.ReadLine(), out s) && s >= 0 && s < numCols)
                {
                    break;
                }
                Console.WriteLine("Недействительное значение s. Попробуйте еще раз.");
            } while (true);
           
            int k;
            do
            {
                Console.Write("Введите значение k: ");
                if (int.TryParse(Console.ReadLine(), out k) && k >= 0 && k < numRows)
                {
                    break;
                }
                Console.WriteLine("Недействительное значение k. Попробуйте еще раз.");
            } while (true);

            int sumColumnS = 0;
            for (int row = 0; row < numRows; row++)
            {
                sumColumnS += array[row, s];
            }
            Console.WriteLine("Сумма элементов " + s + "-го столбца: " + sumColumnS);

            int sumRowK = 0;
            for (int col = 0; col < numCols; col++)
            {
                sumRowK += array[k, col];
            }
            Console.WriteLine("Сумма элементов " + k + "-й строки: " + sumRowK);

        }
    }
}
