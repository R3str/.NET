using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            richTextBox1.Text += Convert.ToString("Некорректные данные в полях ввода! Автоматическая замена на значение '1'\n");
            xy = 1;
         }
         return xy;
      }

      public fDoublecalculating()
      {
         InitializeComponent();

         openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
         saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
//Открытие файла
         if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
         // получаем выбранный файл
         string filename = openFileDialog1.FileName;
         MessageBox.Show("Файл открыт");
//Загрузка файла
         FileStream fstream = File.OpenRead(filename);
                  StreamReader reader = new StreamReader(fstream);
                  string steam;
                  int count, i, z;
                  count = 0;
                  i = 0;
                  z = 0;
         while ((steam = reader.ReadLine()) != null)
         {
            string words = null;
            string s = steam;

            for (int j = z; j < s.Length; j++)
            {
               if (s[j] == '|')
               {
                  z = j + 1;

                  if (count == 0)
                  {
                     k = Convert.ToInt32(words);
                  }

                  if (count == 1)
                  {
                     nameQuadro[i] = words;
                  }

                  if (count == 2)
                  {
                     areaQuadro[i] = Convert.ToInt32(words);
                  }

                  if (count == 3)
                  {
                     nameTrapezium[i] = words;
                  }

                  if (count == 4)
                  {
                     areaTrapezium[i] = Convert.ToInt32(words);
                     count = 0;
                     i++;
                     z = 0;
                  }
                  else
                  {
                     count++;
                  }
                  words = null;
               }
               if (s[j] != '|')
               {
                  words += s[j];
               }
            }
         }
         reader.Close();
         fstream.Close();

         for(int j = 0; j <= k; j++)
         richTextBox1.Text += "Четырехугольник: " + nameQuadro[j] + " — " + areaQuadro[j] + "\n" + "Трапеция: " + nameTrapezium[j] + " — " + areaTrapezium[j] + "\n\n";
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
            for (int j = i+1; j <= k; j++)
            {
               if (nameQuadro[i] == nameQuadro[j])
               {
                  richTextBox1.Text += "Такие имена уже были использованы вами! Автоматическая замена на значение '" + (k + 1) + "'\n";
                  nameQuadro[j] = Convert.ToString(k + 1);
               }

               if (nameTrapezium[i] == nameTrapezium[j])
               {
                  richTextBox1.Text += "Такие имена уже были использованы вами! Автоматическая замена на значение '" + (k + 1) + "'\n";
                  nameTrapezium[j] = Convert.ToString(k + 1);
               }
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

      private void button3_Click(object sender, EventArgs e)
      {
         openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
         saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
//Открытие файла
         if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
         // получаем выбранный файл
         string filename = openFileDialog1.FileName;
         MessageBox.Show("Файл открыт");
//Сохранение файла
         FileStream fstream = new FileStream(filename, FileMode.Create);
         StreamWriter writer = new StreamWriter(fstream);

         for (int i = 0; i <= k; i++)
            writer.Write("{0}|{1}|{2}|{3}|{4}|\n", k, nameQuadro[i], areaQuadro[i], nameTrapezium[i], areaTrapezium[i]);
         writer.Close();
      }
   }
}
