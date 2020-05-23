using System;
using System.ComponentModel.DataAnnotations;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите поличество столбцов: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите поличество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            var matrix = new int[n,a];

            for (int i = 0; i < n; i++)
            {

            }


        }
    }
}
