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

         int sizeX = 16;
         int sizeY = 16;

         int[] xQ = { 6, 4, 9 };
         int[] yQ = { 1, 5, 10 };

         bool stop = false;

         Thread thread = new Thread(() => { Print(sizeX, sizeY, xQ, yQ, stop); });
         Thread thread2 = new Thread(() => { Print2(sizeX, sizeY, xQ, yQ, stop); });
         thread.Start();
         thread2.Start();

         for (int q = 0; q < 1; q++)
         {
            if (stop)
            {
               Console.Clear();
               break;
            }
            PrintMap(sizeX, sizeY);
            for (int i = 0; i < xQ.Length; i++)
            {
               Console.SetCursorPosition(xQ[i], yQ[i]);
               Console.Write("O");
            }
         }

         /*stop = Print(sizeX, sizeY, xQ, yQ, stop, amount);
         stop2 = Print2(sizeX, sizeY, xQ, yQ, stop, amount);*/

         Console.WriteLine(amount);
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

      static void Print(int sizeX, int sizeY, int[] xQ, int[] yQ, bool stop)
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

                  Thread.Sleep(70);
                  Console.SetCursorPosition(j, i);
                  Console.Write(" ");
               
               //Console.ReadKey();
            }
         }
      }

      static void Print2(int sizeX, int sizeY, int[] xQ, int[] yQ, bool stop)
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
               
               //Console.ReadKey();
            }
         }
         Console.Clear();
         Console.WriteLine("Обнаружено целей на карте: " + amount);
      }
   }
}
