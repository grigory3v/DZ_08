
/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

namespace Task_02
{
    class Program
    {
        public static void Main()
        {
            {
                Console.WriteLine($" Введите позицию элемента в двумерном массиве:");
                int positionArray = Convert.ToInt32(Console.ReadLine());

                double[,] array = new double[,]
                {
                {1, 4 ,7 ,2},
                {5 ,9 ,2 ,3},
                {8 ,4 ,2 ,4}
                };
                if (positionArray % 10 <= array.GetLength(0) && positionArray / 10 <= array.GetLength(1))
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (positionArray % 10 == i && positionArray / 10 == j)
                            {
                                Console.Write($"значение этого элемента двумерном массиве =  ");
                                Console.WriteLine($"{array[i, j]} ");
                            }
                        }

                    }
                }
                else Console.Write($"такого числа в массиве нет");

            }

        }
    }
}