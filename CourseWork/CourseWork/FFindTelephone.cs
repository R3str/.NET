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
   public partial class FFindTelephone : Form
   {
      public static int[] arrAmount = new int[FMain.amount];
      public static string telephone;
      public static int amount = -1;
      bool delete = false;
      Label label2 = new Label();
      Button bGoChanche = new Button();
      TextBox chooseNumber = new TextBox();

      public FFindTelephone()
      {
         InitializeComponent();
         bGoChanche.Click += new EventHandler(bGoChanche_Click);
         this.Controls.Add(label2);
      }

      private void FFindTelephone_Load(object sender, EventArgs e)
      {

      }

      private void bFind_Click(object sender, EventArgs e)
      {
         arrAmount[0] = -1;

         telephone = tbNumber.Text;
         FMain.Output(BoxOutput, FMain.user, amount, "Telephone", telephone);

         if (arrAmount[0] < 0)
         {
            label1.Text = "Знакомого с таким номером телефона не существует!";
         }

         else
         {
            label1.Text = "Введите номер телефона вашего знакомого";

            label2.Location = new Point(326, 43);
            label2.Size = new Size(288, 27);
            if (FFind.Mode == "find")
               label2.Text = "Желаете изменить какие-то данные этого знакомого?";
            else
               label2.Text = "Вы действительно хотите удалить своего знакомого?";

            bGoChanche.Location = new Point(399, 75);
            bGoChanche.Size = new Size(140, 46);
            if (FFind.Mode == "find")
               bGoChanche.Text = "Перейти к вкладе изменить";
            else
               bGoChanche.Text = "Да";
            bGoChanche.TabIndex = 3;
            this.Controls.Add(bGoChanche);
         }

         if (arrAmount[1] > 0)
         {
            chooseNumber.Location = new Point(353, 81);
            chooseNumber.Size = new Size(40, 20);
            chooseNumber.TabIndex = 2;
            this.Controls.Add(chooseNumber);

            label2.Text = "Желаете изменить какие-то данные знакомого?\nТогда укажите его порядковый номер ниже";
         }
      }

      private void bGoChanche_Click(object sender, EventArgs e)
      {
         if (arrAmount[1] > 0)
         {
            amount = Convert.ToInt32(chooseNumber.Text);

            for (int i = 0; i < FMain.amount; i++)
            {
               if (delete)
                  Close();

               else if (arrAmount[i] != amount - 1)
               {
                  label2.Text = "В данном списке такого порядкового номера не существует!";
               }

               else if (FFind.Mode == "delete")
               {
                  FFind.Delete(--amount);
                  delete = true;
                  label2.Text = "Удалено!";
               }

               else
               {
                  amount--;
                  FFindChanche fFindChanche = new FFindChanche(amount);
                  fFindChanche.ShowDialog();
                  FMain.Output(BoxOutput, FMain.user, amount, "Address", FMain.user[amount].Street);
                  break;
               }
            }
         }

         else
         {
            if (delete)
               Close();
            else
            {
               amount = arrAmount[0];
               FFindChanche fFindChanche = new FFindChanche(amount);
               fFindChanche.ShowDialog();
               FMain.Output(BoxOutput, FMain.user, amount, "Telephone", FMain.user[amount].Street);
            }
         }
      }
   }
}
