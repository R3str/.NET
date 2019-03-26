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
        int k = 0;
        double[] area = new double[100];
        string[] nameQuadro = new string[100];
        string[] nameTrapezium = new string[100];
        double[] areaQuadro = new double[100];
        double[] areaTrapezium = new double[100];

        public fDoublecalculating()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            nameQuadro[k] = Convert.ToString(quadro.Text);
            nameTrapezium[k] = Convert.ToString(trapezium.Text);
          
            
            areaQuadro[k] = Convert.ToDouble(areaQ.Text);
            areaTrapezium[k] = Convert.ToDouble(areaT.Text);
            richTextBox1.Text += "Четырехугольник: " + nameQuadro[k] + " — " + areaQuadro[k] + "\n" + "Трапеция: " + nameTrapezium[k] + " — " + areaTrapezium[k] + "\n\n";
            k++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double maxQ = 0;
            double maxT = 0;
            int repeat = 0;

            for(int i = 0; i < k; i++)
            {
                if (areaQuadro[i] > maxQ)
                {
                    maxQ = areaQuadro[i];
                }

                if(areaQuadro[i+1] == maxQ)
                {
                    repeat++;
                }

                if (areaTrapezium[i] > maxT)
                {
                    maxT = areaTrapezium[i];
                }
            }

            richTextBox1.Text += "\n\nМаксимальная площадь четырехугоьника: " + maxQ + ", она повторяется " + repeat + " раз(-a)" + "\n" + "Максимальная площадь трапеции: " + maxT;
        }
    }
}
