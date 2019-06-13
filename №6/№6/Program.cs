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
   static void Main(string[] args)
      {
         Console.CursorVisible = false;

         int sizeX = 16;
         int sizeY = 16;

         int sizeX2 = 16;
         int sizeY2 = 16;

         int xQ = 4;
         int yQ = 4;

         int xQ2 = 4;
         int yQ2 = 4;

         bool stop = false;
         bool stop2 = false;

         int amount = 0;
         int amount2 = 0;

         Thread thread = new Thread(() => { stop = Print(sizeX, sizeY, xQ, yQ, stop, amount); });
         Thread thread2 = new Thread(() => { stop2 = Print2(sizeX2, sizeY2, xQ2, yQ2, stop2, amount2); });
         thread.Start();
         thread2.Start();
         for (int i = 0; i < 1; i++)
         {
            if (stop && stop2)
            {
               Console.Clear();
               break;
            }
            PrintMap(sizeX, sizeY);
            Console.SetCursorPosition(xQ, yQ);
            Console.Write("O");
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

      static bool Print(int sizeX, int sizeY, int xQ, int yQ, bool stop, int amount)
      {
         for (int i = 1; i < sizeY/2; i++)
         {
            for (int j = 1; j < sizeX; j++)
            {
               Console.SetCursorPosition(j, i);
               Console.Write("X");

               if (j == xQ && i == yQ)
               {
                  amount++;
               }
               else
                  Thread.Sleep(100);
               Console.SetCursorPosition(j, i);
               Console.Write(" ");
            }
         }
         return stop = true;
      }

      static bool Print2(int sizeX2, int sizeY2, int xQ2, int yQ2, bool stop2, int amount2)
      {
         for (int i = sizeY2 - 1; i > sizeY2/2-1; i--)
         {
            for (int j = sizeX2 - 1; j > 0; j--)
            {
               Console.SetCursorPosition(j, i);
               Console.Write("X");

               if (j == xQ2 && i == yQ2)
               {
                  amount2++;
               }
               else
                  Thread.Sleep(100);
               Console.SetCursorPosition(j, i);
               Console.Write(" ");
            }
         }
         return stop2 = true;
      }
   }
}
