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
    public partial class fMain : Form
    {
        fQuadrofigure Quadro = new fQuadrofigure();
        fTrapezium Trapezium = new fTrapezium();
        fDoublecalculating Doublecalculating = new fDoublecalculating();

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void bQuadro_Click(object sender, EventArgs e)
        {
            Quadro.ShowDialog();
        }

        private void bTrapezium_Click(object sender, EventArgs e)
        {
            Trapezium.ShowDialog();
        }

        private void bCommon_Click(object sender, EventArgs e)
        {
         Doublecalculating.ShowDialog();
      }
    }
}
