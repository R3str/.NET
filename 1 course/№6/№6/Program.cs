using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _6
{
   class Program
   {
      public static int amount = 0;

      static void Main(string[] args)
      {
         Console.CursorVisible = false;

         int sizeX = 16;   //Размер карты
         int sizeY = 16;

         int[] xQ = { 6, 4, 9 }; //Координаты целец
         int[] yQ = { 1, 5, 10 };

         Thread thread = new Thread(() => { Print(sizeX, sizeY, xQ, yQ); });  //Запуск разведчиков
         Thread thread2 = new Thread(() => { Print2(sizeX, sizeY, xQ, yQ); });
         thread.Start();
         thread2.Start();

         for (int q = 0; q < 1; q++)
         {
            PrintMap(sizeX, sizeY); //Отрисовка карты с целями
            for (int i = 0; i < xQ.Length; i++)
            {
               Console.SetCursorPosition(xQ[i], yQ[i]);
               Console.Write("O");
            }
         }
      }

      static void PrintMap(int sizeX, int sizeY)
      {
         for (int c = 1; c < sizeX; c++)
         {
            Console.SetCursorPosition(c, 0);
            Console.Write("_");
         }
         for (int c = 1; c < sizeY / 2; c++)
         {
            Console.SetCursorPosition(0, c);
            Console.Write("|");
         }
         for (int c = sizeX / 2 - 1; c > 0; c--)
         {
            Console.SetCursorPosition(sizeX, c);
            Console.Write("|");
         }
         ///////////////////////////////////////////////
         for (int c = sizeX - 1; c > sizeX / 2 - 1; c--)
         {
            Console.SetCursorPosition(0, c);
            Console.Write("|");
         }
         for (int c = sizeY - 1; c > sizeY / 2 - 1; c--)
         {
            Console.SetCursorPosition(sizeX, c);
            Console.Write("|");
         }
         for (int c = sizeX - 1; c > 0; c--)
         {
            Console.SetCursorPosition(c, sizeX);
            Console.Write("—");
         }
      }

      static void Print(int sizeX, int sizeY, int[] xQ, int[] yQ)
      {
         for (int i = 1; i < sizeY/2; i++)
         {
            for (int j = 1; j < sizeX; j++)
            {
               Console.SetCursorPosition(j, i);
               Console.Write("X");

               for (int q = 0; q < xQ.Length; q++)
                  if (j == xQ[q] && i == yQ[q])
                  {
                     amount++;
                  }

                  Thread.Sleep(110);
                  Console.SetCursorPosition(j, i);
                  Console.Write(" ");
            }
         }
      }

      static void Print2(int sizeX, int sizeY, int[] xQ, int[] yQ)
      {
         for (int x = sizeY - 1; x > sizeY/2-1; x--)
         {
            for (int z = sizeX - 1; z > 0; z--)
            {
               Console.SetCursorPosition(z, x);
               Console.Write("X");

               for (int i = 0; i < xQ.Length; i++)
                  if (z == xQ[i] && x == yQ[i])
                  {
                     amount++;
                  }

                  Thread.Sleep(150);
                  Console.SetCursorPosition(z, x);
                  Console.Write(" ");
            }
         }
         Console.Clear();
         Console.WriteLine("Обнаружено целей на карте: " + amount);
      }
   }
}
