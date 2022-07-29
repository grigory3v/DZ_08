/*
Задача 58: Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
namespace Task_03
{
    class Program
    {
        public static void Main()
        {
            double[,] array_1 = new double[,]
            {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
            };

            double[,] array_2 = new double[,]
            {
            {1, 5, 8, 5},
            {4, 9, 4, 2},
            {7, 2, 2, 6},
            {2, 3, 4, 7}
            };
            double[,] theProductNumbers = new double[array_1.GetLength(0), array_2.GetLength(1)];

            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_2.GetLength(1); j++)
                {
                    theProductNumbers[i, j] = array_1[i, j] * array_2[i, j];
                    Console.Write($" {theProductNumbers[i, j]} ");
                }
                Console.WriteLine();
            }











        }
    }
}
