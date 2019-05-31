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
   public partial class FFindNumber : Form
   {
      int number;
      Label label2 = new Label();
      Button bGoChanche = new Button();
      bool delete = false;

      public FFindNumber()
      {
         InitializeComponent();
         bGoChanche.Click += new EventHandler(bGoChanche_Click);
         this.Controls.Add(label2);
      }

      private void FFindNumber_Load(object sender, EventArgs e)
      {

      }

      private void bFind_Click(object sender, EventArgs e)
      {
         number = Convert.ToInt32(tbNumber.Text);

         if (number > FMain.amount)
            label1.Text = "Знакомого под таким порядковым номером не существует!";
         else
         {
            FMain.Output(BoxOutput, FMain.user, number, "One", "0");

            label2.Location = new Point(326, 43);
            label2.Size = new Size(288, 13);
            if(FFind.Mode == "find")
            label2.Text = "Желаете изменить какие-то данные этого знакомого?";
            else
               label2.Text = "Вы действительно хотите удалить своего знакомого?";
            bGoChanche.Location = new Point(399, 67);
            bGoChanche.Size = new Size(140, 46);
            if (FFind.Mode == "find")
               bGoChanche.Text = "Перейти к вкладе изменить";
            else
               bGoChanche.Text = "Да";
            bGoChanche.TabIndex = 2;
            this.Controls.Add(bGoChanche);
         }
      }

      private void bGoChanche_Click(object sender, EventArgs e)
      {
         FFindChanche fFindChanche = new FFindChanche(number-1);
         if (delete)
            Close();

         if (FFind.Mode == "delete")
         {
            FFind.Delete(--number);
            delete = true;
            label2.Text = "Удалено!";
         }
         else
         {
            fFindChanche.ShowDialog();
            FMain.Output(BoxOutput, FMain.user, number, "One", "0");
         }
      }
   }
}
