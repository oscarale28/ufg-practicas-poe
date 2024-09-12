namespace P2_GuiaFormsControls.Forms.ComboBox
{
    partial class ComboBoxForm
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
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbShapes
            // 
            this.cmbShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShapes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Items.AddRange(new object[] {
            "Círculo",
            "Cuadrado",
            "Elipse",
            "Pastel",
            "Círculo relleno",
            "Cuadrado relleno",
            "Elipse relleno",
            "Pastel relleno"});
            this.cmbShapes.Location = new System.Drawing.Point(12, 12);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(393, 35);
            this.cmbShapes.TabIndex = 0;
            this.cmbShapes.SelectedIndexChanged += new System.EventHandler(this.cmbShapes_SelectedIndexChanged);
            // 
            // ComboBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 435);
            this.Controls.Add(this.cmbShapes);
            this.Name = "ComboBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBoxForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShapes;
    }
}