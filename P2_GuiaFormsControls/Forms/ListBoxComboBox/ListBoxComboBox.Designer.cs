namespace P2_GuiaFormsControls.Forms.ListBoxComboBox
{
    partial class ListBoxComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.ltbLibros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(23, 59);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(378, 35);
            this.cmbCategorias.TabIndex = 0;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // ltbLibros
            // 
            this.ltbLibros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbLibros.FormattingEnabled = true;
            this.ltbLibros.ItemHeight = 27;
            this.ltbLibros.Location = new System.Drawing.Point(23, 117);
            this.ltbLibros.Name = "ltbLibros";
            this.ltbLibros.Size = new System.Drawing.Size(378, 247);
            this.ltbLibros.TabIndex = 1;
            // 
            // ListBoxComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 435);
            this.Controls.Add(this.ltbLibros);
            this.Controls.Add(this.cmbCategorias);
            this.Name = "ListBoxComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBoxComboBox";
            this.Load += new System.EventHandler(this.ListBoxComboBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.ListBox ltbLibros;
    }
}