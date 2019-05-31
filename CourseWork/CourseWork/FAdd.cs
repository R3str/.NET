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
   public partial class FAdd : Form
   {
      string s;
      int amountAdd = 0;

      public FAdd(int amount)
      {
         InitializeComponent();
      }

      private void FAdd_Load(object sender, EventArgs e)
      {

      }

      private void bOK_Click(object sender, EventArgs e)
      {
         s = textBox1.Text;
         if(!int.TryParse(s, out amountAdd) || Convert.ToInt32(s) < 1)
         {
            label1.Text = "Некорректные данные!";
            amountAdd = -1;
         }

         if(amountAdd > 0)
         {
            Hide();
            FAdd2 add2 = new FAdd2(amountAdd);
            add2.ShowDialog();
         }
      }
   }
}
