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
        public fTrapezium()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double[] length = new double[4];
            
            double x1 = Convert.ToDouble(X1.Text);
            double y1 = Convert.ToDouble(Y1.Text);

            double x2 = Convert.ToDouble(X2.Text);
            double y2 = Convert.ToDouble(Y2.Text);

            double x3 = Convert.ToDouble(X3.Text);
            double y3 = Convert.ToDouble(Y3.Text);

            double x4 = Convert.ToDouble(X4.Text);
            double y4 = Convert.ToDouble(Y4.Text);
            
            length[0] = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            length[1] = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            length[2] = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            length[3] = Math.Sqrt((x4 - x2) * (x4 - x2) + (y4 - y2) * (y4 - y2));

            for (int i = 0; i < 4; i++)
            {
                if (length[i] == 0)
                    label13.Text = Convert.ToString("Некорректные данные!");
            }

// Проверка на параллельность сторон и равность хотя бы одной пары сторон
            if (x1 / x2 == y1 / y2 || x1 / x3 == y1 / y3 || x1 / x4 == y1 / y4 || x2 / x3 == y2 / y3 || x2 / x4 == y2 / y4 || x3 / x4 == y3 / y4)
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
                label13.Text = Convert.ToString("Вывод: " + "\n Фигура не выполняет условие паралельности сторон!");
            }
        }
    }
}
