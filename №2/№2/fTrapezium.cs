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
    public partial class fTrapezium : Form
    {
      private int Check(string s)
      {
         int xy;
         if (!int.TryParse(s, out xy))
         {
            label13.Text = Convert.ToString("Некорректные данные в полях ввода! Автоматическая замена на значение '0'\n");
         }
         return xy;
      }

      public fTrapezium()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         double[] length = new double[4];
         int[] x = new int[4];
         int[] y = new int[4];
            
            x[0] = Check(X1.Text);
            y[0] = Check(Y1.Text);

            x[1] = Check(X2.Text);
            y[1] = Check(Y2.Text);

            x[2] = Check(X3.Text);
            y[2] = Check(Y3.Text);

            x[3] = Check(X4.Text);
            y[3] = Check(Y4.Text);
            
            length[0] = Math.Sqrt((x[1] - x[0]) * (x[1] - x[0]) + (y[1] - y[0]) * (y[1] - y[0]));
            length[1] = Math.Sqrt((x[3] - x[2]) * (x[3] - x[2]) + (y[3] - y[2]) * (y[3] - y[2]));
            length[2] = Math.Sqrt((x[2] - x[0]) * (x[2] - x[0]) + (y[2] - y[0]) * (y[2] - y[0]));
            length[3] = Math.Sqrt((x[3] - x[1]) * (x[3] - x[1]) + (y[3] - y[1]) * (y[3] - y[1]));

         for (int i = 0; i < 4; i++) 
         {
            if (length[i] == 0)
            { 
               label13.Text += Convert.ToString("Некорректные данные! Одна из сторона равна нулю");
            goto link;
            }
         }

// Проверка на параллельность сторон и равность хотя бы одной пары сторон
            if (x[0] / x[1] == y[0] / y[1] || x[0] / x[2] == y[0] / y[2] || x[0] / x[3] == y[0] / y[3] || x[1] / x[2] == y[1] / y[2] || x[1] / x[3] == y[1] / y[3] || x[2] / x[3] == y[2] / y[3])
            {
                if (length[0] == length[1] && length[2] != length[3] && length[3] != length[0] && length[2] != length[0])
                {
                    label13.Text = Convert.ToString("Вывод: " + "\nТрапеция является равнобочной" + "\n\n1-ая сторона: " + length[0] + "       2-ая сторона: " + length[1] +
                                   "\n3-ая сторона: " + length[2] + "       4-ая сторона: " + length[3] + "\n");
                }
                else if (length[0] == length[2] && length[1] != length[3] && length[1] != length[0] && length[3] != length[0])
                {
                    label13.Text = Convert.ToString("Вывод: " + "\nТрапеция является равнобочной" + "\n\n1-ая сторона: " + length[0] + "       2-ая сторона: " + length[1] +
                                   "\n3-ая сторона: " + length[2] + "       4-ая сторона: " + length[3] + "\n");
                }
                else
                {
                    label13.Text = Convert.ToString("Вывод: " + "\nТрапеция не является равнобочной" + "\n\n1-ая сторона: " + length[0] + "       2-ая сторона: " + length[1] +
                                   "\n3-ая сторона: " + length[2] + "       4-ая сторона: " + length[3] + "\n");
                }
            }
            else
            {
                label13.Text = Convert.ToString("Вывод: " + "\nФигура не выполняет условие паралельности сторон!");
            }
      link:;
        }
    }
}
