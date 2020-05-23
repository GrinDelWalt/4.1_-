using System;

internal sealed class Program
{
   
    
        static void Main()
        {
            Random r = new Random();
            Int32[] arr = Enumerable.Range(0, 10).Select(i => r.Next(0, 100)).ToArray();

            Console.Write("Элементы массива: ");
            arr.ToList().ForEach(i => Console.Write("{0} ", i));
            Console.Write("\nДва самых больших числа: ");
            arr.OrderByDescending(i => i).Take(2).ToList().ForEach(i => Console.Write("{0} ", i));
            Console.Write("\nДва самых маленьких числа: ");
            arr.OrderBy(i => i).Take(2).ToList().ForEach(i => Console.Write("{0} ", i));
        }
    }

