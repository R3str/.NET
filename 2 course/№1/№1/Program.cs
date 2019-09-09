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
         string start;
         double finish = 0;
         int index = 0;

         using (StreamReader SR = new StreamReader(@"E:\1Programming test\2 course\input.txt"))
         {
            start = SR.ReadLine();
            SR.Close();
         }
              
            Console.WriteLine("Вы запустили программу для перевода чисел систем счисления (из двоичной в шестнадцатиричную c 8-ой разрядностью)." +
               "\n\nВаше число записаное в файле 'input.txt' - " + start);

         for(int i = start.Length-1; i >= 0; i--)
         {
            finish += Convert.ToInt32(Convert.ToString(start[index]))*Math.Pow(2,i);
            index++;
         }

         Console.WriteLine("Ваш результат сохраненый в файл 'output.txt' - " + finish + "\n");

         using (StreamWriter SW = new StreamWriter(@"E:\1Programming test\2 course\output.txt"))
            SW.Write(finish);

      }
   }
}
