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
            string n;

            Console.WriteLine("Введите целое число :");
            n = Console.ReadLine();

            bool check = int.TryParse(n, out int a);

            if (check)
            {
                a = a * a;
                Console.WriteLine("Результат: " + a);
            }
            else
            {
                Console.WriteLine("Вы ввели некорректные данные");
            }

        }
    }
}
