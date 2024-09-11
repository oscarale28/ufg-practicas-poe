namespace P2_GuiaFormsControls
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEjemplo1 = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnDisplayPruebaLabel = new System.Windows.Forms.Button();
            this.btnDisplayListBoxComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(188, 101);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(588, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Guía Práctica  - Formularios y Controles";
            // 
            // btnEjemplo1
            // 
            this.btnEjemplo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplo1.Location = new System.Drawing.Point(35, 219);
            this.btnEjemplo1.Name = "btnEjemplo1";
            this.btnEjemplo1.Size = new System.Drawing.Size(215, 68);
            this.btnEjemplo1.TabIndex = 1;
            this.btnEjemplo1.Text = "1 - Controles";
            this.btnEjemplo1.UseVisualStyleBackColor = true;
            this.btnEjemplo1.Click += new System.EventHandler(this.btnEjemplo1_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(205, 138);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(555, 29);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Pulse el botón correspondiente para cada ejemplo";
            // 
            // btnDisplayPruebaLabel
            // 
            this.btnDisplayPruebaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayPruebaLabel.Location = new System.Drawing.Point(267, 219);
            this.btnDisplayPruebaLabel.Name = "btnDisplayPruebaLabel";
            this.btnDisplayPruebaLabel.Size = new System.Drawing.Size(215, 68);
            this.btnDisplayPruebaLabel.TabIndex = 3;
            this.btnDisplayPruebaLabel.Text = "2 - Label Clave";
            this.btnDisplayPruebaLabel.UseVisualStyleBackColor = true;
            this.btnDisplayPruebaLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisplayListBoxComboBox
            // 
            this.btnDisplayListBoxComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayListBoxComboBox.Location = new System.Drawing.Point(500, 219);
            this.btnDisplayListBoxComboBox.Name = "btnDisplayListBoxComboBox";
            this.btnDisplayListBoxComboBox.Size = new System.Drawing.Size(215, 68);
            this.btnDisplayListBoxComboBox.TabIndex = 4;
            this.btnDisplayListBoxComboBox.Text = "3 - List y Combo Box";
            this.btnDisplayListBoxComboBox.UseVisualStyleBackColor = true;
            this.btnDisplayListBoxComboBox.Click += new System.EventHandler(this.btnDisplayListBoxComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 560);
            this.Controls.Add(this.btnDisplayListBoxComboBox);
            this.Controls.Add(this.btnDisplayPruebaLabel);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnEjemplo1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEjemplo1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnDisplayPruebaLabel;
        private System.Windows.Forms.Button btnDisplayListBoxComboBox;
    }
}

