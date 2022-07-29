/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/

namespace Task_01
{
    class Program
    {
        public static void Main()
        {

            double[,] array = new double[,]
            {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double number = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = array.GetLength(1) - 1; k != j; k--)
                    {
                        if (array[i, j] > array[i, k])
                        {
                            number = array[i, k];
                            array[i, k] = array[i, j];
                            array[i, j] = number;
                        }
                    }
                    Console.Write($" {array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
