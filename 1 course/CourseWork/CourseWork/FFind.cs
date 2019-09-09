using System;
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
   public partial class FFind : Form
   {
      public static string Mode;

      public static void Delete(int number)
      { 
         FMain.MyFriends[] userDelete = new FMain.MyFriends[FMain.amount - 1];

         for (int i = 0; i < FMain.amount; i++)
         {
            if (i == number)
               continue;

            if (i > number)
               userDelete[i - 1] = FMain.user[i];

            else
               userDelete[i] = FMain.user[i];
         }

         FMain.user = new FMain.MyFriends[--FMain.amount];

         for (int i = 0; i < FMain.amount; i++)
         {
            FMain.user[i] = userDelete[i];
         }
      }

      public FFind(string mode)
      {
         InitializeComponent();
         Mode = mode;
      }

      private void FFind_Load(object sender, EventArgs e)
      {

      }

      private void bNumber_Click(object sender, EventArgs e)
      {
         FFindNumber findNumber = new FFindNumber();
         Hide();
         findNumber.ShowDialog();
      }

      private void bFio_Click(object sender, EventArgs e)
      {
         FFindFio findFio = new FFindFio();
         Hide();
         findFio.ShowDialog();
      }

      private void bBirthday_Click(object sender, EventArgs e)
      {
         FFindBirthday findBirthday = new FFindBirthday();
         Hide();
         findBirthday.ShowDialog();
      }

      private void bStreet_Click(object sender, EventArgs e)
      {
         FFindAddress findAddress = new FFindAddress();
         Hide();
         findAddress.ShowDialog();
      }

      private void bTelephone_Click(object sender, EventArgs e)
      {
         FFindTelephone findTelephone = new FFindTelephone();
         Hide();
         findTelephone.ShowDialog();
      }
   }
}
