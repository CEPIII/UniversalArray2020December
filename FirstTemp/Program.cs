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
            int lengthArr = arr.Length;
            Console.WriteLine(lengthArr);

            int summ = 0;
            foreach (var x in arr)
            {
                summ += x;
            }
            Console.WriteLine($"Сумма двумерного массива составляет ; \n summ = {summ}");
        }

    
    }
}
