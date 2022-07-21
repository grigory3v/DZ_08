/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

namespace Task_01
{
    class Program
    {
        public static void Main()
        {
            int m = 3; //количество строк массива
            int n = 4; //количество столбцов массива

            double[,] array = new double[m, n];
            Console.Write($"двумерный массив размером m×n, заполненный случайными вещественными числами =  ");
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = new Random().Next(-100, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //     PrintArray(array);   

            // }
            // public static void PrintArray (int[] array)
            // {
            //     int length = array.Length;
            //     int count = 0;
            //     for (int i = 0; i < length; i++ )
            //     {
            //         if ( array[i] % 2 == 0 )
            //         {
            //             count++;    
            //         }
            //     }
            //     Console.Write($" количество чётных чисел в массиве = {count} ");
            //     Console.WriteLine();
        }

    }
}
