using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.ListBoxComboBox
{
    public partial class ListBoxComboBox : Form
    {
        public ListBoxComboBox()
        {
            InitializeComponent();
        }

        private void ListBoxComboBox_Load(object sender, EventArgs e)
        {
            cmbCategorias.Items.Add("Libros de programación");
            cmbCategorias.Items.Add("Libros de literatura");
            cmbCategorias.Items.Add("Comic Books");
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbLibros.Items.Clear();
            string option = cmbCategorias.SelectedItem.ToString();
            switch (option)
            {
                case "Libros de programación":
                    ltbLibros.Items.Add("Visual Basic 2010");
                    ltbLibros.Items.Add("Visual C# 2010");
                    ltbLibros.Items.Add("Visual C++");
                    break;
                case "Libros de literatura":
                    ltbLibros.Items.Add("La caída de los gigantes");
                    ltbLibros.Items.Add("Las legiones malditas");
                    ltbLibros.Items.Add("El sueño del celta");
                    break;
                case "Comic Books":
                    ltbLibros.Items.Add("Spiderman");
                    ltbLibros.Items.Add("Batman");
                    ltbLibros.Items.Add("Superman");
                    break;
            }
        }
    }
}
