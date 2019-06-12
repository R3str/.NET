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
      /*static bool Print(int[] heigh, int[] width, int x, int y, int xQ, int yQ, bool tR)
      {
         for (int i = 0; i < width.Length + 1; i++)
            Console.Write("#");
         Console.WriteLine();

         for (int i = 0; i < heigh.Length/2; i++)
         {
            for (int j = 0; j < width.Length; j++)
            {
               if (xQ == x && yQ == y)
                  tR = true;
               if (j == 0 || j == width.Length - 1)
                  Console.Write("#");
               if (j == x && i == y)
                  Console.Write("0");
               else if (i == xQ && j == yQ)
                  Console.Write("X");
               else
               Console.Write(" ");
            }
            Console.WriteLine();
         }
         return tR;
      }

      static bool Print2(int[] heigh, int[] width, int x, int y, int xQ2, int yQ2, bool tR)
      {
         for (int i = heigh.Length / 2; i < heigh.Length; i++)
         {
            for (int j = 0; j < width.Length; j++)
            {
               if (xQ2 == y && yQ2 == x)
                  tR = true;
               if (j == 0 || j == width.Length - 1)
                  Console.Write("#");
               if (j == x && i == y)
                  Console.Write("0");
               else if (i == xQ2 && j == yQ2)
                  Console.Write("X");
               else
                  Console.Write(" ");
            }
            Console.WriteLine();
         }
         
         for (int i = 0; i < width.Length + 1; i++)
            Console.Write('#');
         Console.WriteLine();
         return tR;
      }*/


            

   static void Main(string[] args)
      {
         int sizeX = 5;
         int sizeY = 5;

         int xQ = 4;
         int yQ = 4;

         bool stop = false;

         int amount = 0;

         /*Thread thread = new Thread(() => { amount = Print2(sizeX, sizeY, xQ, yQ, stop, amount); });

         thread.Start();*/

         amount = Print(sizeX, sizeY, xQ, yQ, stop, amount);
         amount = Print2(sizeX, sizeY, xQ, yQ, stop, amount);
         Console.WriteLine(amount);

         /*Thread thread = new Thread(() => { Prnt(sizeX, sizeY); });
         Thread thread2 = new Thread(() => { Prnt2(sizeX, sizeY); });

         thread.Start();
         thread2.Start();*/
         /*int[] heigh = new int[sizeY];
         int[] width = new int[sizeX];
         int x = 17;
         int y = 15;
         int xQ = 0;
         int yQ = 0;
         int xQ2 = sizeX;
         int yQ2 = sizeY;
         bool tR = false;

         Thread thread = new Thread(Prnt);
         Thread thread2 = new Thread(Prnt2);

         thread.Start();
         thread2.Start();*/

            /*for (int i = 0; i < sizeY - 1; i++)
            {
               xQ = i;
               xQ2 = sizeY - 1 - i;
               for (int j = 0; j < sizeX - 1; j++)
               {
                  yQ = j;
                  yQ2 = sizeX - 2 - j;
                  /*tR = Print(heigh, width, x, y, xQ, yQ, tR);
                  tR = Print2(heigh, width, x, y, xQ2, yQ2, tR);
                  if (tR)
                  {
                     goto link;
                  }
                  else
                     Thread.Sleep(10);
                  Console.Clear();
               }
            }
         link:;
            Console.WriteLine("Цель устранена!");*/
      }

      static int Print(int sizeX, int sizeY, int xQ, int yQ, bool stop, int amount)
      {
         bool death = false;

         for (int i = 0; i < sizeY; i++)
         {
            for (int j = 0; j < sizeX; j++)
            {
               Console.SetCursorPosition(j, i);
               Console.Write("X");
               if (!death)
               {
                  Console.SetCursorPosition(xQ, yQ);
                  Console.Write("O");
               }
               else
               {
                  Console.SetCursorPosition(xQ, yQ);
                  Console.Write("0");
               }

               if (j == xQ && i == yQ)
               {
                  death = true;
                  Console.Write("0");
                  amount++;
               }
               else
                  Thread.Sleep(100);
               Console.Clear();
            }
         }
         /*Console.WriteLine(amount);*/
         return amount;
      }

      static int Print2(int sizeX, int sizeY, int xQ, int yQ, bool stop, int amount)
      {
         bool death = false;

         for (int i = sizeY - 1; i > -1; i--)
         {
            for (int j = sizeX - 1; j > -1 ; j--)
            {
               Console.SetCursorPosition(j, i);
               Console.Write("X");
               if (!death)
               {
                  Console.SetCursorPosition(xQ, yQ);
                  Console.Write("O");
               }
               else
               {
                  Console.SetCursorPosition(xQ, yQ);
                  Console.Write("0");
               }

               if (j == xQ && i == yQ)
               {
                  death = true;
                  Console.Write("0");
                  amount++;
               }
               else
                  Thread.Sleep(100);
               Console.Clear();
            }
         }
        /* Console.WriteLine(amount);*/
         return amount;
      }
   }
}
