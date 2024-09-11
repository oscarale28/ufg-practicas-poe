using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.Controles
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void btnDisplayTextboxes_Click(object sender, EventArgs e)
        {
            TextBox txtBox1 = new TextBox
            {
                Location = new Point(50, 50),
                Size = new Size(250, 20),
                Font = new Font("Arial", 12)
            };
            TextBox txtBox2 = new TextBox
            {
                Location = new Point(50, 100),
                Size = new Size(250, 20),
                Font = new Font("Arial", 12)
            };
            this.Controls.Add(txtBox1);
            this.Controls.Add(txtBox2);
        }
    }
}
