using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.PictureBox
{
    public partial class PictureBoxForm : Form
    {

        private int numImagen = -1;

        public PictureBoxForm()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            numImagen = (numImagen + 1) % 4;
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(basePath, "Imagenes", "imagen" + numImagen + ".png");

            if (File.Exists(imagePath))
            {
                pbImagen.Image = Image.FromFile(@"Imagenes\imagen" + numImagen + ".png");
            }
            else
            {
                MessageBox.Show("Ninguna imagen fue encontrada en la ruta: " + imagePath);
            }
        }
    }
}
