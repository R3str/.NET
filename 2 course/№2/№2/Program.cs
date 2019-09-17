using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] start = new string[3];
            int index = 1, count = 0;
            // Считывание файла
            using (StreamReader SR = new StreamReader(@"E:\1Programming test\2 course\input.txt"))
            {
                start[0] = SR.ReadLine();
                SR.Close();
            }
            // Приветствие
            Console.WriteLine("Вы запустили программу для вычитания двух чисел (каждое из которых не должно превышать 16-ую степень разрядности).");
            // Проверка на соответствие разрядности
            if (start[0].Length > 16)
            {
                Console.WriteLine("\nВы ввели некорректное число! Попробуйте еще раз");
                Environment.Exit(0);
            }
            // Проверка на корректность вводимого числа (отсутствие букв и недопустимых цифр)
            for (int i = 0; i < start[0].Length; i++)
            {
                if (start[0][i] != ',' && start[0][i] != '1' && start[0][i] != '0')
                {
                    Console.WriteLine("\nВы ввели некорректное число! Попробуйте еще раз");
                    Environment.Exit(0);
                }
            }

        }
    }
}
