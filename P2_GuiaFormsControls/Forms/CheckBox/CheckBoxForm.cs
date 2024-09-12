using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.CheckBox
{
    public partial class CheckBoxForm : Form
    {
        public CheckBoxForm()
        {
            InitializeComponent();
        }

        private void checkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Font = new Font(lblTitle.Font, lblTitle.Font.Style ^ FontStyle.Bold);
        }

        private void checkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Font = new Font(lblTitle.Font, lblTitle.Font.Style ^ FontStyle.Italic);
        }
    }
}
