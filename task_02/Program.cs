
/*

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

namespace Task_02
{
    class Program
    {
        public static void Main()
        {

            double[,] array = new double[,]
            {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4},
                {5, 2, 6, 7}
            };
            int minSumStr = 0;
            double min = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                if (i == 0)
                {
                    min = sum;
                }
                if (sum <= min)
                {
                    min = sum;
                    minSumStr = i + 1;
                }
            }
            Console.WriteLine($" номер строки с наименьшей суммой элементов: {minSumStr} строка  ");
        }
    }
}