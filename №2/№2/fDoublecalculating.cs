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
    public partial class fDoublecalculating : Form
    {
      int k = -1;
      string[] nameQuadro = new string[100];
      string[] nameTrapezium = new string[100];
      int[] areaQuadro = new int[100];
      int[] areaTrapezium = new int[100];
// Функция для проверки ввода
      private int Check(string s)
      {
         int xy;
         if (!int.TryParse(s, out xy) || Convert.ToInt32(s) <= 0)
         {
            richTextBox1.Text = Convert.ToString("Некорректные данные в полях ввода! Автоматическая замена на значение '1'\n");
            xy = 1;
         }
         return xy;
      }

      public fDoublecalculating()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         k++;
         nameQuadro[k] = Convert.ToString(quadro.Text);
         nameTrapezium[k] = Convert.ToString(trapezium.Text);

         areaQuadro[k] = Check(areaQ.Text);
         areaTrapezium[k] = Check(areaT.Text);
         for (int i = 0; i <= k; i++)
         {
            if (nameQuadro[i] == nameQuadro[i + 1])
            {
               richTextBox1.Text += "Такие имена уже были использованы вами! Автоматическая замена на значение '" + k + "'\n";
               nameQuadro[i + 1] = Convert.ToString(k);
            }

            if (areaTrapezium[i] == areaTrapezium[i + 1])
            {
               richTextBox1.Text += "Такие имена уже были использованы вами! Автоматическая замена на значение '" + k + "'\n";
               nameTrapezium[i + 1] = Convert.ToString(k);
            }
         }
         richTextBox1.Text += "Четырехугольник: " + nameQuadro[k] + " — " + areaQuadro[k] + "\n" + "Трапеция: " + nameTrapezium[k] + " — " + areaTrapezium[k] + "\n\n";
      }

      private void button2_Click(object sender, EventArgs e)
      {
         double maxQ = 0;
         double maxT = 0;
         int repeat = 0;

// Подсчет макисмальной площади из каждой фигуры
         for (int i = 0; i <= k; i++)
         {
            if (areaQuadro[i] > maxQ)
            {
               maxQ = areaQuadro[i];
            }

            if (areaTrapezium[i] > maxT)
            {
               maxT = areaTrapezium[i];
            }
         }

// Подсчет повторений максимальной фигуры в четырехугольнике
         for (int i = 0; i <= k; i++)
         {
            if (areaQuadro[i] == maxQ)
            {
               repeat++;
            }
         }

         if(repeat != 0)
         {
            repeat--;
         }

         richTextBox1.Text += "\nМаксимальная площадь четырехугольника: " + maxQ + ", она повторяется " + repeat + " раз(-a)" + "\n" + "Максимальная площадь трапеции: " + maxT + "\n";
      }
    }
}
