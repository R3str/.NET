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
            string[] start = new string[2];
            string[] change = new string[2];
            int count = 0;
            // Считывание файла
            using (StreamReader SR = new StreamReader(@"E:\_Programming test\2 course\input.txt"))
            {
                start[0] = SR.ReadLine();
                start[1] = SR.ReadLine();
                SR.Close();
            }
            // Приветствие
            Console.WriteLine("Вы запустили программу для вычитания двух чисел (каждое из которых не должно превышать 16-ую степень разрядности)." +
                "\nВаши числа: " + start[0] + " и " + start[1]);
            // Проверка на соответствие разрядности и корректность вводимого числа (отсутствие букв и недопустимых цифр)
            Check(start[0]);
            Check(start[1]);
            // Добавление нехватающих нулей для равной разрядности обеих чисел
            if(start[0].Length > start[1].Length || start[0].Length < start[1].Length)
            {
                count = start[0].Length - start[1].Length;

                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                        change[1] += "0";
                    change[1] += start[1];
                    change[0] = start[0];
                }

                if(count < 0)
                {
                    for (int i = 0; i > count; i--)
                        change[0] += "0";
                    change[0] += start[0];
                    change[1] = start[1];
                }
            }
            // Вычитание чисел
            count = change[0].Length;
            int num = 0;
            start[0] = null;
            bool minusOne = false;

            for(int i = count-1; i >= 0; i--)
            {
                num = Convert.ToInt32(change[0][i]) - Convert.ToInt32(change[1][i]);
                if (minusOne)
                {
                    num = --num;
                    if (num == -2)
                    {
                        num = 0;
                        minusOne = true;
                    }
                    else
                        minusOne = false;
                }
                if (num < 0)
                {
                    minusOne = true;
                    num = Math.Abs(num);
                }

                start[0] += num;
            }
            // Переворот числа, так как запись была инвертированной
            char[] reverseString = start[0].ToCharArray();
            Array.Reverse(reverseString);
            Console.Write("\nРезультат вычисления: ");
            Console.Write(reverseString);
            Console.WriteLine();
            // Запись результата в файл
            using (StreamWriter SW = new StreamWriter(@"E:\_Programming test\2 course\output.txt"))
            {
                SW.WriteLine(reverseString);
                SW.Close();
            }
        }
        // Метод для проверки соответствия разрядности и корректности вводимого числа (отсутствие букв и недопустимых цифр)
        static void Check(string s1)
        {
            if (s1.Length > 16)
            {
                Console.WriteLine("\nВы ввели слишком большое число! Попробуйте еще раз");
                Environment.Exit(0);
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != '1' && s1[i] != '0')
                {
                    Console.WriteLine("\nВы ввели некорректное число! Попробуйте еще раз");
                    Environment.Exit(0);
                }
            }
        }
    }
}
