/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

namespace Task_02
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine($" Введите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[size];
            Console.Write($"одномерный массив, заполненный случайными числами = [ ");
            for ( int i = 0; i < array.Length; i++ )
            {   
                array[i] = new Random().Next(-100, 100);
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
                if ( i % 2 == 0 )
                {
                    count = count + array[i];    
                }
            }
            Console.Write($" суммa элементов, стоящих на нечётных позициях = {count} ");
            Console.WriteLine();
        }

    }
}