/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
namespace Task_03
{
    class Program
    {
        public static void Main()
        {
            double[,] array = new double[,]
            {
                {1, 4 ,7 ,2},
                {5 ,9 ,2 ,3},
                {8 ,4 ,2 ,4}
            };
            for (int j = 0; j < array.GetLength(1); j++)
            {
                double average = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    average = average + array[i, j];
                }
                average = average / array.GetLength(0);
                Console.WriteLine($" a ={Math.Round(average, 1)}");
            }
        }
    }
}
