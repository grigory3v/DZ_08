/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

namespace Task_01
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine($" Введите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[size];
            Console.Write($"массив заполненный случайными положительными трёхзначными числами = [ ");
            for ( int i = 0; i < array.Length; i++ )
            {   
                array[i] = new Random().Next(100, 1000);
                Console.Write($"{array[i]} ");
            }
            Console.Write($"]");
            Console.WriteLine();
            PrintArray(array);   

        }
        public static void PrintArray (int[] array)
        {
            int length = array.Length;
            int count = 0;
            for (int i = 0; i < length; i++ )
            {
                if ( array[i] % 2 == 0 )
                {
                    count++;    
                }
            }
            Console.Write($" количество чётных чисел в массиве = {count} ");
            Console.WriteLine();
        }

    }
}
