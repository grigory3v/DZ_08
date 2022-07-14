/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
namespace Task_03
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine($" Введите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            double [] array = new double[size];

            Console.Write($"массив вещественных чисел = [ ");
            for ( int i = 0; i < array.Length; i++ )
            {   
                array[i] = new Random().Next(-10, 10);

                Console.Write($"{array[i]} ");
            }
            Console.Write($"]");
            Console.WriteLine();
            PrintArray(array);   

        }
        public static void PrintArray (double[] array)
        {
            int length = array.Length;
            double min = array[0];
            double max = array[0];
            double min_max = 0;
            for (int i = 0; i < length; i++ )
            {
                if ( array[i] <= min )
                {
                    min = array[i];
                }  
                if  ( array[i] >= max ) 
                {
                max = array[i];
                }
            }
            min_max = max - min;
            Console.Write($" разница между максимальным и минимальным элементом массива = {min_max} ");
        }

    }
}
