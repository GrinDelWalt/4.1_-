using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Умножение матричы на число");

            Console.Write("Введите количество столбцов: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число на которое нужно умножить матрицу: ");
            int m = Convert.ToInt32(Console.ReadLine());

            var matrix = new int[n, a];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int d = 0; d < a; d++)
                {
                    matrix[i, d] = rand.Next(1, 30);
                    Console.Write($"{matrix[i, d]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int d = 0; d < a; d++)
                {
                    matrix[i, d] *= m;
                    Console.Write($"{matrix[i, d]}  ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("Сложение и вычитание матриц");

            Console.Write("Введите количество столбцов: ");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество строк: ");
            int q = Convert.ToInt32(Console.ReadLine());

            var tempMatrix = new int[q, w];
            var temp2Matrix = new int[q, w];
            var dublTempMatrix = new int[q, w];

            Console.WriteLine();
            Console.WriteLine("матрица 1");
            Console.WriteLine();

            for (int i = 0; i < q; i++)
            {
                for (int d = 0; d < w; d++)
                {
                    tempMatrix[i, d] = rand.Next(1, 10);
                    dublTempMatrix[i, d] = tempMatrix[i, d];
                    Console.Write($"{tempMatrix[i, d]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("матрица 2");
            Console.WriteLine();

            for (int i = 0; i < q; i++)
            {
                for (int d = 0; d < w; d++)
                {
                    temp2Matrix[i, d] = rand.Next(1, 10);
                    Console.Write($"{temp2Matrix[i, d]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("сумма");
            Console.WriteLine();

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine();
                for (int d = 0; d < w; d++)
                {
                    dublTempMatrix[i, d] += temp2Matrix[i, d];
                    Console.Write($"{tempMatrix[i, d]}  ");
                }

            }

            Console.WriteLine();
            Console.WriteLine("разность");
            Console.WriteLine();

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine();
                for (int d = 0; d < w; d++)
                {
                    tempMatrix[i, d] -= temp2Matrix[i, d];
                    Console.Write($"{tempMatrix[i, d]}  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Умножение матриц");

            while (true)
            {
                Console.Write("Введите количество столбцов 1й матрицы: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество строк 1й матрицы: ");
                int z = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество столбцов 2й матрицы: ");
                int v = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество строк 2й матрицы: ");
                int c = Convert.ToInt32(Console.ReadLine());

                var matrixOne = new int[z, x];
                var matrixTwo = new int[c, v];
                var matrixResult = new int[z, v];

                Console.WriteLine();
                Console.WriteLine("матрица 1");
                Console.WriteLine();

                for (int i = 0; i < z; i++)
                {
                    for (int d = 0; d < x; d++)
                    {
                        matrixOne[i, d] = rand.Next(1, 10);
                        Console.Write($"{matrixOne[i, d]}  ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("матрица 2");
                Console.WriteLine();

                for (int i = 0; i < c; i++)
                {
                    for (int d = 0; d < v; d++)
                    {
                        matrixTwo[i, d] = rand.Next(1, 10);
                        Console.Write($"{matrixTwo[i, d]}  ");
                    }
                    Console.WriteLine();
                }

                if (x == c)
                {
                    for (int i = 0; i  < z; i++)
                    {
                        for (int d = 0; d < v; d++)
                        {
                            for (int p = 0; p < x; p++)
                            {
                                matrixResult[i, d] += matrixOne[i, p] * matrixTwo[p, d];
                                Debug.WriteLine(matrixResult[i, d]);
                            }
                            
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("результат");
                    Console.WriteLine();

                    for (int i = 0; i < z; i++)
                    {
                        for (int d = 0; d < v; d++)
                        {

                            Console.Write($"{matrixResult[i, d]}  ");
                        }
                        Console.WriteLine();
                    }
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Матрицы не являються согласованными повоторите ввод");
                }
                





            }
            Console.ReadKey();
        }
    }
}
