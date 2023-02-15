using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = { -3, 5, 28, 19, -2, -4, -10, 9 };
            int max = array[0];
             int indexMax = 0;
             for (int i = 1; i < array.Length; i++)
             {
                 if (array[i] > max)
                 { 
                 max = array[i];
                     indexMax = i;
                 }
             }
            Console.WriteLine($"max = {max}\t indexMax = {indexMax}");

            //минимальное значение
            int min = array[0];
            int indexMin = 0;
            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    indexMin = j;
                }
            }
                  Console.WriteLine($"max = {min}\t indexMax = {indexMin}");

            int temp;
            temp = array[indexMax];
            array[indexMax] = array[indexMin];
            array[indexMin] = temp;
            
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine($" index {i} = {array[i]}");
            }
            Console.WriteLine($"Количество элементов между min и max = {Math.Abs(indexMax - indexMin) - 1}");//кол=во элементов


            int minmax = Math.Abs(array[indexMax] - array[indexMin]);
            Console.WriteLine($"Разность по модулю = {Math.Abs(array[indexMax] - array[indexMin])}");


            for (int i = 0;i < array.Length;i++)
            {
                array[i] *= minmax;
                WriteLine($" array = { array[i]}");
            }
            Console.ReadKey();
        }
    }
}
