using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1
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
         Console.WriteLine("Вы запустили программу для перевода чисел систем счисления (из двоичной в шестнадцатиричную c 8-ой разрядностью).");
// Проверка на соответствие разрядности
         if (start[0].Length > 8)
         {
            Console.WriteLine("\nВы ввели некорректное число! Попробуйте еще раз");
            Environment.Exit(0);
         }
// Проверка на корректность вводимого числа (отсутствие букв)
         for(int i = 0; i < start[0].Length; i++)
         {
            if (Char.IsLetter(start[0][i]))
            {
               Console.WriteLine("\nВы ввели некорректное число! Попробуйте еще раз");
               Environment.Exit(0);
            }
         }
// Добавление нулей, что бы добиться равного разделения по 4 разряда 
         if (start[0].Length % 4 != 0)
         {
            if (start[0].Length > 4)
               count = 8 - start[0].Length;
            else
               count = 4 - start[0].Length;

            start[1] = start[0];
            start[0] = null;

            for (int i = 0; i < count; i++)
               start[0] += "0";

            start[0] += start[1];
            start[1] = null;
         }

         Console.WriteLine("\n\nВаше число записаное в файле 'input.txt' - " + start[0]);
// Разделение по 4 разряда
         for (int i = 0; i < start[0].Length; i++)
         {
            start[index] += start[0][i];
            if (i == 3)
               index++;
         }

         count = start[0].Length / 4;
         start[0] = null;
// Перевод числа в 16-ую систему счисления
         for (int i = 1; i <= count; i++)
         {
            start[0] += Check(start[i]);
         }
         Console.WriteLine("Ваш результат сохраненный в файл 'output.txt' - " + start[0] + "\n");
// Запись в файл
         using (StreamWriter SW = new StreamWriter(@"E:\1Programming test\2 course\output.txt"))
         {
            SW.Write(start[0]);
            SW.Close();
         }
      }
// Метод для перевода числа
      static string Check(string str)
      {
         switch (str)
         {
            case "0000":
               str = "0"; break;
            case "0001":
               str = "1"; break;
            case "0010":
               str = "2"; break;
            case "0011":
               str = "3"; break;
            case "0100":
               str = "4"; break;
            case "0101":
               str = "5"; break;
            case "0110":
               str = "6"; break;
            case "0111":
               str = "7"; break;
            case "1000":
               str = "8"; break;
            case "1001":
               str = "9"; break;
            case "1010":
               str = "A"; break;
            case "1011":
               str = "B"; break;
            case "1100":
               str = "C"; break;
            case "1101":
               str = "D"; break;
            case "1110":
               str = "E"; break;
            case "1111":
               str = "F"; break;
         }
         return str;
      }
       
   }
}
