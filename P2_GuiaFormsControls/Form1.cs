using P2_GuiaFormsControls.Forms.CheckBox;
using P2_GuiaFormsControls.Forms.ComboBox;
using P2_GuiaFormsControls.Forms.Controles;
using P2_GuiaFormsControls.Forms.ListBox;
using P2_GuiaFormsControls.Forms.ListBoxComboBox;
using P2_GuiaFormsControls.Forms.NumericUpDown;
using P2_GuiaFormsControls.Forms.Panel;
using P2_GuiaFormsControls.Forms.PictureBox;
using P2_GuiaFormsControls.Forms.PruebaLabel;
using P2_GuiaFormsControls.Forms.RadioButton;
using P2_GuiaFormsControls.Forms.Tooltip;
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

        private void btnDisplayPanel_Click(object sender, EventArgs e)
        {
            PanelForm panel = new PanelForm();
            panel.Show();
        }

        private void btnDisplayCheckBox_Click(object sender, EventArgs e)
        {
            CheckBoxForm checkBoxForm = new CheckBoxForm();
            checkBoxForm.Show();

        }

        private void btnDisplayRadioButton_Click(object sender, EventArgs e)
        {
            RadioButtonForm rbtnForm = new RadioButtonForm();
            rbtnForm.Show();
        }

        private void btnDisplayPictureBox_Click(object sender, EventArgs e)
        {
            PictureBoxForm pbForm = new PictureBoxForm();
            pbForm.Show();
        }

        private void btnDisplayTooltip_Click(object sender, EventArgs e)
        {
            TooltipForm tooltipForm = new TooltipForm();
            tooltipForm.Show();
        }

        private void btnDisplayNumericUpDown_Click(object sender, EventArgs e)
        {
            NumericUpDownForm upDownForm = new NumericUpDownForm();
            upDownForm.Show();
        }

        private void btnDisplayListBox_Click(object sender, EventArgs e)
        {
            ListBoxForm lbForm = new ListBoxForm();
            lbForm.Show();
        }

        private void btnDisplayComboBox_Click(object sender, EventArgs e)
        {
            ComboBoxForm cmbForm = new ComboBoxForm();
            cmbForm.Show();
        }
    }
}
