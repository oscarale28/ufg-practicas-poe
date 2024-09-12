using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.ListBox
{
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string valorEntrada = txtEntrada.Text;

            if (valorEntrada != "")
            {
                lbItems.Items.Add(valorEntrada);
                txtEntrada.Clear();
                txtEntrada.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex != -1)
            {
                lbItems.Items.RemoveAt(lbItems.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un item para eliminar", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
        }
    }
}
