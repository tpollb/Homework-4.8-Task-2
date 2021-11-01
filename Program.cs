using System;

namespace Homework_4._8_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayMaxValue = -1;
            int number;
            int i;
            int result;
            
            while (arrayMaxValue < 1 || arrayMaxValue > 255)
            {
                Console.WriteLine("Enter array lenght 1 to 255: ");
                arrayMaxValue = int.Parse(Console.ReadLine());
            }
           
            int[] array = new int[arrayMaxValue];

            Console.WriteLine($"Enter {arrayMaxValue} nubers");
            //заполнение массива
            for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Number {i + 1}: ");
                    number = int.Parse(Console.ReadLine());
                    array[i] = number;
                }

            //вывод массива
            /*
            for (i = 0; i < array.Length; i++)
                {
                    Console.Write($"Array: {array[i]} ");
                }
                Console.WriteLine();
            */

            //обработка. поиск наименьшего
            Array.Sort(array);
            result = array[0];
            Console.WriteLine($"Min number is: {result}");



            Console.ReadKey();
            
        }
    }
}
