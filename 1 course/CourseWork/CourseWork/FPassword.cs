using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
   public partial class FPassword : Form
   {
      string notPassword;
      public static int count = 0;

      public FPassword()
      {
         InitializeComponent();
      }

      private void FPassword_Load(object sender, EventArgs e)
      {
         FileStream fstream = File.OpenRead(@"E:\NotPassword.txt");
         StreamReader reader = new StreamReader(fstream);
         notPassword = reader.ReadLine();
      }

      private void bOK_Click(object sender, EventArgs e)
      {
         count++;

         if (textBox1.Text != notPassword)
         {
            label1.Text = "Вы ввели неверный пароль!";
         }

         else
         {
            label1.Text = "Пароль верный. Приятного пользования!";
            if (count > 1)
            {
               Close();
               count = 10;
            }
         }
      }

      private void FPassword_FormClosed(object sender, FormClosedEventArgs e)
      {
         if(count < 10)
         count = -1;
      }
   }
}
