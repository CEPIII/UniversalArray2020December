using System;

namespace FirstTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /// Подсчитать сумму чисел в двухмерном массиве
            
            int[,] arr = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };

            /*
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum + "\n");      */

            
            int lengthArr = arr.Length;
            Console.WriteLine(lengthArr);

            int summ = 0;
            foreach (var x in arr)
            {
                summ += x;
            }
            Console.WriteLine($"Сумма двумерного массива составляет ; \n summ = {summ}");
            
            /*
            Console.WriteLine("====Заполнить двумерный массив случайными числами====");
            int[,] arrTwo10 = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < arrTwo10.Length; i++)
            {

            }
            */


        }   
    }
}
