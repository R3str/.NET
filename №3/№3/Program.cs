using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
   public class Matrix
   {
      double[,] arr = new double[3, 3];
      char name;

      int rows;
      int columns;

      public Matrix(char n, double a0, double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8)
      {
         rows = arr.GetUpperBound(0) + 1;
         columns = arr.Length / rows;

         name = n;
         arr[0, 0] = a0;
         arr[0, 1] = a1;
         arr[0, 2] = a2;
         arr[1, 0] = a3;
         arr[1, 1] = a4;
         arr[1, 2] = a5;
         arr[2, 0] = a6;
         arr[2, 1] = a7;
         arr[2, 2] = a8;
      }

// Вывод матрицы с проверкой на единичную матрицу
      public void Write()
      {
         int n = 0;
         Console.WriteLine(name + " = " + '\n');
         for (int i = 0; i < 3; i++)
         {
            for (int j = 0; j < 3; j++)
            {
               if (arr[i, j] == 1)
               {
                  n++;
               }
               Console.Write(String.Format("{0,7}", arr[i, j] + "\t"));
            }
            Console.WriteLine();
         }
         Console.WriteLine('\n' + "Размерность матрицы: " + rows + "x" + columns);
         if (n == 9)
         {
            Console.Write("Матрица является единичной" + '\n');
         }
      }

//  Вывод матрицы над которой уже произошло алгебраическое действие
      public void WriteA(double[,] action)
      {
         for (int i = 0; i < 3; i++)
         {
            for (int j = 0; j < 3; j++)
            {
               Console.Write(String.Format("{0,7}", action[i, j] + "\t"));
            }
            Console.WriteLine();
         }
      }

// Алгебраические действия над матрицами
      public void Action(Matrix A, Matrix B, int numberAction, double[,] action)
      {
         switch (numberAction)
         {
            case 1:
               {
                  for (int i = 0; i < 3; i++)
                  {
                     for (int j = 0; j < 3; j++)
                     {
                        action[i, j] = A.arr[i, j] + B.arr[i, j];
                     }
                  }
                  WriteA(action);
                  break;
               }

            case 2:
               {
                  int num;
                  Console.WriteLine("От какой матрицы будете вычитывать?" + '\n' + "1 — от матрицы 'А'" + '\t' + "2 — от матрицы 'В'");
                  num = int.Parse(Console.ReadLine());

                  switch (num)
                  {
                     case 1:
                        {
                           for (int i = 0; i < 3; i++)
                           {
                              for (int j = 0; j < 3; j++)
                              {
                                 action[i, j] = A.arr[i, j] - B.arr[i,j];
                              }
                           }
                           WriteA(action);
                           break;
                        }

                     case 2:
                        {
                           for (int i = 0; i < 3; i++)
                           {
                              for (int j = 0; j < 3; j++)
                              {
                                 action[i, j] = B.arr[i, j] - A.arr[i,j];
                              }
                           }
                           WriteA(action);
                           break;
                        }
                  }
                  break;
               }

            case 3:
               {
                  for (int i = 0; i < 3; i++)
                  {
                     for (int j = 0; j < 3; j++)
                     {
                        action[i, j] = A.arr[i, j] * B.arr[i, j];
                     }
                  }
                  WriteA(action);
                  break;
               }

            case 4:
               {
                  int num;
                  Console.WriteLine("На какую матрицу будете умножать?" + '\n' + "1 — матрица 'А'" + '\t' + "2 — матрица 'В'");
                  num = int.Parse(Console.ReadLine());

                  switch (num)
                  {
                     case 1:
                        {
                           Console.WriteLine("На какое число будете умножать?");
                           num = int.Parse(Console.ReadLine());

                           for (int i = 0; i < 3; i++)
                           {
                              for (int j = 0; j < 3; j++)
                              {
                                 action[i, j] = A.arr[i, j] * num;
                              }
                           }
                           WriteA(action);
                           break;
                        }

                     case 2:
                        {
                           Console.WriteLine("На какое число будете умножать?");
                           num = int.Parse(Console.ReadLine());

                           for (int i = 0; i < 3; i++)
                           {
                              for (int j = 0; j < 3; j++)
                              {
                                 action[i, j] = B.arr[i, j] * num;
                              }
                           }
                           WriteA(action);
                           break;
                        }
                  }
                  break;
               }
         }
      }
   }


      public class Program
      {
         static double[,] action = new double[3, 3];
         static int numberAction;

         static void Main(string[] args)
         {
            //Matrix A = new Matrix("Единичная матрица", 1, 1, 1, 1, 1, 1, 1, 1, 1); 
            Matrix A = new Matrix('A', 1, 2, 2, 0, 3, 1, 1, 0, 0);
            Matrix B = new Matrix('B', 0, 0, 1, (-1 / 4.0), (1 / 2.0), (1 / 4.0), (3 / 4.0), (-1 / 2.0), (-7 / 10.0));
            A.Write();
            B.Write();
// Алгебраические действия над матрицами
            Console.WriteLine("Что вы хотите сделать с этими матрицами?");
            Console.WriteLine("1 — сумма" + '\t' + "2 — вычитание" + '\t' + "3 — умножение двух матриц" + '\t' + "4 — умножение матрицы на число");

            numberAction = int.Parse(Console.ReadLine());

            A.Action(A, B, numberAction, action);
         }

      }
}
