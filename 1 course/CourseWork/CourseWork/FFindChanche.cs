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
   public partial class FFindChanche : Form
   {
      public int Amount;
      bool checkBool = false;
      int close = 0;

      public FFindChanche(int amount)
      {
         InitializeComponent();
         Amount = amount;
      }

      private void FFindChanche_Load(object sender, EventArgs e)
      {
         label6.Text = "Знакомый №" + (Amount + 1);
         textFio.Text = Convert.ToString(FMain.user[Amount].Fio);
         textBirthday.Text = Convert.ToString(FMain.user[Amount].Bithday.Year + "." + FMain.user[Amount].Bithday.Month + "." + FMain.user[Amount].Bithday.Day);
         textStreet.Text = Convert.ToString(FMain.user[Amount].Street);
         textHouse.Text = Convert.ToString(FMain.user[Amount].House);
         textTelephone.Text = Convert.ToString(FMain.user[Amount].Telephone);
      }

      private void bOK_Click(object sender, EventArgs e)
      {
         close++;
         if (!checkBool)
         {
            //Внутри метода checkBool меняется на 'true'
            checkBool = FMain.Change(Amount, textFio, textBirthday, textStreet, textHouse, textTelephone);
         }
         label6.Text = "Вы изменили данные своего знакомого";

         if(close == 2)
         {
            Close();
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {

      }
   }
}
