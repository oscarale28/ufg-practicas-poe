using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.NumericUpDown
{
    public partial class NumericUpDownForm : Form
    {
        public NumericUpDownForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal principal;
            double tasa;
            int anio;

            decimal monto;
            string salida;

            if (txtPrincipal.Text != "" && txtTasaInteres.Text != "" && nudAnios.Value != 0)
            {

                principal = Convert.ToDecimal(txtPrincipal.Text);
                tasa = Convert.ToDouble(txtTasaInteres.Text);
                anio = Convert.ToInt32(nudAnios.Value);

                salida = "Año\tMonto del depósito\r\n";
                for (int contadorAnios = 1; contadorAnios <= anio; contadorAnios++)
                {
                    monto = principal * ((decimal)Math.Pow((1.0 + tasa / 100), contadorAnios));
                    salida += (contadorAnios + "\t" + String.Format("{0:C}", monto) + "\r\n");
                }
                txtResultado.Text = salida;
            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
