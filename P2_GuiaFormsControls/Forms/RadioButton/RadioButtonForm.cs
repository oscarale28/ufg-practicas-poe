using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.RadioButton
{
    public partial class RadioButtonForm : Form
    {
        public RadioButtonForm()
        {
            InitializeComponent();
        }

        private void tipoBoton_CheckedChange(object sender, EventArgs e)
        {
            if (sender == rbtnAccept)
            {
                tipoBoton = MessageBoxButtons.OK;
            }
            else if (sender == rbtnAcceptCancel)
            {
                tipoBoton = MessageBoxButtons.OKCancel;
            }
            else if (sender == rbtnAbort)
            {
                tipoBoton = MessageBoxButtons.AbortRetryIgnore;
            }
            else if (sender == rbtnYesNo)
            {
                tipoBoton = MessageBoxButtons.YesNo;
            }
            else if (sender == rbtnYesNoCancel)
            {
                tipoBoton = MessageBoxButtons.YesNoCancel;
            }
            else
            {
                tipoBoton = MessageBoxButtons.RetryCancel;
            }
        }

        private void tipoIcono_CheckedChange(object sender, EventArgs e)
        {
            if (sender == rbtnAsterisk)
            {
                tipoIcono = MessageBoxIcon.Asterisk;
            }
            else if (sender == rbtnError)
            {
                tipoIcono = MessageBoxIcon.Error;
            }
            else if (sender == rbtnExclamation)
            {
                tipoIcono = MessageBoxIcon.Exclamation;
            }
            else if (sender == rbtnHand)
            {
                tipoIcono = MessageBoxIcon.Hand;
            }
            else if (sender == rbtnInfo)
            {
                tipoIcono = MessageBoxIcon.Information;
            }
            else if (sender == rbtnQuestion)
            {
                tipoIcono = MessageBoxIcon.Question;
            }
            else if (sender == rbtnStop)
            {
                tipoIcono = MessageBoxIcon.Stop;
            }
            else
            {
                tipoIcono = MessageBoxIcon.Warning;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Este es su MessageBox personalizado", "MessageBox personalizado", tipoBoton, tipoIcono, 0, 0);
            switch (result)
            {
                case DialogResult.OK:
                    lblResult.Text = "Se presionó OK";
                    break;
                case DialogResult.Cancel:
                    lblResult.Text = "Se presionó Cancel";
                    break;
                case DialogResult.Abort:
                    lblResult.Text = "Se presionó Abort";
                    break;
                case DialogResult.Retry:
                    lblResult.Text = "Se presionó Retry";
                    break;
                case DialogResult.Ignore:
                    lblResult.Text = "Se presionó Ignore";
                    break;
                case DialogResult.Yes:
                    lblResult.Text = "Se presionó Yes";
                    break;
                case DialogResult.No:
                    lblResult.Text = "Se presionó No";
                    break;
            }
        }
    }
}
