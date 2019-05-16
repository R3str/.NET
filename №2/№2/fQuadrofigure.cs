using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class fQuadrofigure : Form
    {

      private int Check(string s)
      {
         int xy;
         if (!int.TryParse(s, out xy))
         {
            label1.Text = "Некорректные данные в полях ввода!Автоматическая замена на значение '0'\n";
         }

         return xy;
      }

      public fQuadrofigure()
        {
            InitializeComponent();
        }

        private void fQuadrofigure_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         double[] length = new double[6];
         int[] x = new int[4];
         int[] y = new int[4];
         double perimetr = 0;
         double S;
         
         
         x[0] = Check(X1.Text);
         y[0] = Check(Y1.Text);

         x[1] = Check(X2.Text);
         y[1] = Check(Y2.Text);

         x[2] = Check(X3.Text);
         y[2] = Check(Y3.Text);

         x[3] = Check(X4.Text);
         y[3] = Check(Y4.Text);

         // Стороны
         length[0] = Math.Round(Math.Sqrt((x[1] - x[0]) * (x[1] - x[0]) + (y[1] - y[0]) * (y[1] - y[0])), 2);
         length[1] = Math.Round(Math.Sqrt((x[3] - x[2]) * (x[3] - x[2]) + (y[3] - y[2]) * (y[3] - y[2])), 2);
         length[2] = Math.Round(Math.Sqrt((x[2] - x[0]) * (x[2] - x[0]) + (y[2] - y[0]) * (y[2] - y[0])), 2);
         length[3] = Math.Round(Math.Sqrt((x[3] - x[1]) * (x[3] - x[1]) + (y[3] - y[1]) * (y[3] - y[1])), 2);

         length[4] = Math.Round(Math.Sqrt((x[3] - x[0]) * (x[3] - x[0]) + (y[3] - y[0]) * (y[3] - y[0])), 2);
         length[5] = Math.Round(Math.Sqrt((x[1] - x[2]) * (x[1] - x[2]) + (y[1] - y[2]) * (y[1] - y[2])), 2);

         for(int i = 0; i < 6; i++)
         {
            if (length[i] == 0)
            {
               label1.Text += Convert.ToString("Некорректные данные! Одна из сторон равна нулю");
               goto link;
            }
         }
         
         perimetr = Math.Round(length[0] + length[1] + length[2] + length[3], 2);

         // Площадь для любого четырехугольника
         S = Math.Round(Math.Sqrt((perimetr / 2 - length[0]) * (perimetr / 2 - length[1]) * (perimetr / 2 - length[2]) * (perimetr / 2 - length[3])), 2);

         label1.Text = Convert.ToString("Вывод:" + "\n1-ая сторона: " + length[0] + "      2-ая сторона: " + length[1] +
             "\n3-ая сторона: " + length[2] + "      4-ая сторона: " + length[3]
             + "\n\nПериметр: " + perimetr + "\nДиагонали: " + length[4] + " и " + length[5] + "\nПлощадь: " + S);

         link:;
        }

    }
}
