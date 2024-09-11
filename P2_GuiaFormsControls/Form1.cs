using P2_GuiaFormsControls.Forms.Controles;
using P2_GuiaFormsControls.Forms.ListBoxComboBox;
using P2_GuiaFormsControls.Forms.PruebaLabel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjemplo1_Click(object sender, EventArgs e)
        {
            // show the Controles form
            Controles controles = new Controles();
            controles.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PruebaLabel pruebaLabel = new PruebaLabel();
            pruebaLabel.Show();
        }

        private void btnDisplayListBoxComboBox_Click(object sender, EventArgs e)
        {
            ListBoxComboBox listBoxComboBox = new ListBoxComboBox();
            listBoxComboBox.Show();

        }
    }
}
