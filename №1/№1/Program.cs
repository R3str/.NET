using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONPU.NET
{
    class Program
    {
        static void Main(string[] args)
        {
         int a;

         Console.WriteLine("Введите целое число :");

         while (!int.TryParse(Console.ReadLine(), out a))
         {
            Console.WriteLine("Некорректное значение! Попробуйте еще раз ");
         }

         Console.WriteLine("Результат: " + Math.Pow(a, 2));
      }
    }
}
