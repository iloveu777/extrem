using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = { -3, 5, 18, 19, -2, -4, 0, -9 };
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
//             Console.WriteLine($"max = {max}\t indexMax = {indexMax}");

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
            //      Console.WriteLine($"max = {min}\t indexMax = {indexMin}");

            int p;
            p = array[indexMax];
            array[indexMax] = array[indexMin];
            array[indexMin] = p;
            
            foreach(int i in array)
            {
                Console.WriteLine($"index{i} = array{array[i]}");
            }
            
            Console.ReadKey();
        }
    }
}
