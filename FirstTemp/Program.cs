﻿using System;

namespace FirstTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительный диапазон значений случайных чисел, которые заполнят массив от 0 \n diapazon = ");
            int diapazon = Convert.ToInt32(Console.ReadLine());
            Console.Write("Определите первый размер двумерного массива : \n\t[x, ] = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Определите второй размер двумерного массива : \n\t[, y] = ");
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[x, y];
            //Заполнить массив рандомными значениями по заданному ранее диапазону
            Random rnd = new Random();
            //Заодно найду максимальный элемент, минимальный и сумму всех элементов
            int min, max;
            Console.WriteLine($"Заполненный массив \n\t int[,] arr = new int[{x}, {y}]");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, diapazon);
                    Console.Write($"  {arr[i, j]}  ");
                }
                Console.Write("}\n");
            }
        }   
    }
}
