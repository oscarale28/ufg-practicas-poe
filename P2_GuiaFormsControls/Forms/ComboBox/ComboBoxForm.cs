using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.ComboBox
{
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void cmbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics miGrafico = CreateGraphics();
            Pen miPen = new Pen(Color.DarkRed);
            SolidBrush miSolidBrush = new SolidBrush(Color.DarkRed);

            miGrafico.Clear(Color.White);

            switch (cmbShapes.SelectedIndex)
            {
                case 0:
                    miGrafico.DrawEllipse(miPen, 50, 50, 150, 150);
                    break;
                case 1:
                    miGrafico.DrawRectangle(miPen, 50, 50, 150, 150);
                    break;
                case 2:
                    miGrafico.DrawEllipse(miPen, 50, 85, 150, 115);
                    break;
                case 3:
                    miGrafico.DrawPie(miPen, 50, 50, 150, 150, 0, 40);
                    break;
                case 4:
                    miGrafico.FillEllipse(miSolidBrush, 50, 50, 150, 150);
                    break;
                case 5:
                    miGrafico.FillRectangle(miSolidBrush, 50, 50, 150, 150);
                    break;
                case 6:
                    miGrafico.FillEllipse(miSolidBrush, 50, 85, 150, 115);
                    break;
                case 7:
                    miGrafico.FillPie(miSolidBrush, 50, 50, 150, 150, 0, 40);
                    break;

            }
            miGrafico.Dispose();
        }
    }
}
