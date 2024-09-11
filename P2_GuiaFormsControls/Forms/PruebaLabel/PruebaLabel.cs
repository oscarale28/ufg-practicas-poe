using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.PruebaLabel
{
    public partial class PruebaLabel : Form
    {
        public PruebaLabel()
        {
            InitializeComponent();
        }

        private void btnMostrarClave_Click(object sender, EventArgs e)
        {
            if(txtDigitarClave.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, digite una clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblVerClave.Text = "Clave no ingresada";
                lblVerClave.ForeColor = Color.Red;
            } else
            {
                lblVerClave.Text = txtDigitarClave.Text;
                lblVerClave.ForeColor = Color.Black;
            }
        }
    }
}
