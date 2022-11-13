using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = 10;
            int columnsCount = 10;
            int maxElement = int.MinValue;
            int substitutionNumber = 0;
            int beginRandomValue = 0;
            int endRandomValue = 85;
            int[,] matrixA = new int[rowsCount,columnsCount];
            Random random = new Random();
            ConsoleColor defaultColor = Console.BackgroundColor;

            Console.WriteLine("Исходная матрица: ");

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i,j] = random.Next(beginRandomValue, endRandomValue);
                    Console.Write(matrixA[i,j] + "\t");

                    if (matrixA[i,j] > maxElement)
                    {
                        maxElement = matrixA[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Максимальный элемент матрицы = " + maxElement);
            Console.WriteLine("Запишем {0} в ячейки с максимальным элементом.\nПолучили матрицу: ", substitutionNumber);

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                { 
                    if (matrixA[i,j] == maxElement)
                    {
                        matrixA[i, j] = substitutionNumber;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    
                    Console.Write(matrixA[i,j] + "\t");
                    Console.BackgroundColor = defaultColor;
                }
                Console.WriteLine();
            }
        }
    }
}
