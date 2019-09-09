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
   public partial class FAdd2 : Form
   {
      int amountAdd;
      static public int amountFinish;
      static public FMain.MyFriends[] userAdd;
      bool checkBool;
      static public int reapetPosition;
      int close = 1;

      public FAdd2(int amountAdd)
      {
         InitializeComponent();
         this.amountAdd = amountAdd;
         amountFinish = FMain.amount + amountAdd;
         userAdd = new FMain.MyFriends[amountFinish];
         FMain.Resize(userAdd, FMain.amount, amountFinish); 
      }

      int number = 1;
      private void FAdd2_Load(object sender, EventArgs e)
      {
         label6.Text = "Знакомый №" + number;
      }

      private void bOK_Click(object sender, EventArgs e)
      {
         if (close == 2)
         {
            Close();
            goto close;
         }
         if (FMain.amount <= amountFinish)
         {
            checkBool = FMain.Change(FMain.amount, textFio, textBirthday, textStreet, textHouse, textTelephone);
            if (checkBool)
               FMain.amount++;
            else
               label6.Text = "Список знакомых уже имеет такого пользователя! Это №" + reapetPosition;
         }

         else
            Close();

         if (checkBool)
         {
            if ((amountFinish - FMain.amount) != 0)
               label6.Text = "Знакомый №" + ++number;
            else
            {
               label6.Text = "Вы добавили всех своих знакомых!";
               close++;
            }
         }
      close:;
      }
   }
}
