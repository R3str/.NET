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
            bool comma = false;
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
            comma = Check(start[0], comma);
            comma = Check(start[1], comma);
        // Добавление нехватающих нулей для равной разрядности обеих чисел
            count = start[0].Length - start[1].Length;

            if (count > 0)
            {
            // Добавление в свободный массив первые два символа для обозначения знака
                if (comma)
                {
                    change[1] += start[1][0];
                    change[1] += start[1][1];
                }
            // Добавление нулей
                for (int i = 0; i < count; i++)
                    change[1] += "0";
            // Добавление всего остального числа начиная от запятой
                for (int i = 0; i < start[1].Length; i++)
                {
                    if (comma)
                        i += 2;
                    change[1] += start[1][i];
                }
                change[0] = start[0];
            }

            if (count < 0)
            {
            // Добавление в свободный массив первые два символа для обозначения знака
                if (comma)
                {
                    change[0] += start[0][0];
                    change[0] += start[0][1];
                }
                // Добавление нулей
                for (int i = 0; i > count; i--)
                    change[0] += "0";
            // Добавление всего остального числа начиная от запятой
                for (int i = 0; i < start[0].Length; i++)
                {
                    if (comma)
                        i += 2;
                    change[0] += start[0][i];
                }
                change[1] = start[1];
            }

            if (count == 0)
            {
                change[0] = start[0];
                change[1] = start[1];
            }

        // Действие над числами
            count = change[0].Length;
            start[0] = null;
        // Определение отрицательного и перевод в обратный код
            if (change[0][0] == '1')
            {
                char[] charStr = change[0].ToCharArray();

                for (int i = 2; i < count; i++)
                {
                    if (change[0][i] == '1')
                        charStr[i] = '0';
                    else
                        charStr[i] = '1';
                }

                change[0] = new string(charStr);
            }

            if (change[1][0] == '1')
            {
                char[] charStr2 = change[1].ToCharArray();

                for (int i = 2; i < count; i++)
                {
                    if (change[1][i] == '1')
                        charStr2[i] = '0';
                    else
                        charStr2[i] = '1';
                }

                change[1] = new string(charStr2);
            }
        // Перевод в дополнительный код
            bool[] additCode = new bool[2] { false, false };

            if (change[0][0] == '1')
            {
                additCode[0] = true;
                change[0] = Action(count, change[0], change[1], additCode);
                additCode[0] = false;
            }
            if (change[1][0] == '1')
            {
                additCode[1] = true;
                change[1] = Action(count, change[0], change[1], additCode);
                additCode[1] = false;
            }
        // Сумма двух чисел
            start[0] = Action(count, change[0], change[1], additCode);

            Console.Write("\nРезультат вычисления: ");
            Console.Write(start[0]);
            Console.WriteLine();
        // Запись результата в файл
            using (StreamWriter SW = new StreamWriter(@"E:\_Programming test\2 course\output.txt"))
            {
                SW.WriteLine(start[0]);
                SW.Close();
            }
        }


// Метод для проверки соответствия разрядности и корректности вводимого числа (отсутствие букв и недопустимых цифр)
        static bool Check(string s1, bool comma)
        {
            if (s1.Length > 16)
            {
                if (s1[1] == ',' && s1.Length > 17)
                {
                    Console.WriteLine("\nВы ввели слишком большое число! Попробуйте еще раз");
                    Environment.Exit(0);
                }
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != '1' && s1[i] != '0')
                {
                    if (s1[1] == ',')
                        comma = true;
                    else
                    { 
                        Console.WriteLine("\nВы ввели некорректное число! Попробуйте еще раз");
                        Environment.Exit(0);
                    }
                }
            }
            return comma;
        }

    // Метод для вычислений (сумма двух чисел и добавление единички для перевода в доп. код)
        static string Action(int count, string change, string change2, bool[] addictCode)
        {
            int num = 0;
            bool dontReapet = false, addOne = false;
            string start = "";

            for (int i = count - 1; i >= 0; i--)
            {
                if (change[i] == ',')
                {
                    start = start.Insert(0, ",");
                    i--;
                }

                if (addictCode[0])
                {
                    if (!dontReapet)
                        num = (int)char.GetNumericValue(change[i]) + 1;
                    else
                        num = (int)char.GetNumericValue(change[i]);
                    dontReapet = true;
                }
                else if (addictCode[1])
                {
                    if (!dontReapet)
                        num = (int)char.GetNumericValue(change2[i]) + 1;
                    else
                        num = (int)char.GetNumericValue(change2[i]);
                    dontReapet = true;
                }
                else if (!addictCode[0] && !addictCode[1])
                    num = (int)char.GetNumericValue(change[i]) + (int)char.GetNumericValue(change2[i]);

                if (addOne)
                {
                    addOne = false;
                    num++;
                }

                if (num == 2)
                {
                    addOne = true;
                    num = 0;
                }
                if (num == 3)
                {
                    addOne = true;
                    num = 1;
                }

                start = start.Insert(0, Convert.ToString(num));
            }

            return start;
        }
    }
}
