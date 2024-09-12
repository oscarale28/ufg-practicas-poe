namespace P2_GuiaFormsControls.Forms.CheckBox
{
    partial class CheckBoxForm
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
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.checkItalic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(44, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(475, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Observe cómo cambia el estilo de la fuente";
            // 
            // checkBold
            // 
            this.checkBold.AutoSize = true;
            this.checkBold.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBold.Location = new System.Drawing.Point(102, 96);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(115, 31);
            this.checkBold.TabIndex = 1;
            this.checkBold.Text = "Negrita";
            this.checkBold.UseVisualStyleBackColor = true;
            this.checkBold.CheckedChanged += new System.EventHandler(this.checkBold_CheckedChanged);
            // 
            // checkItalic
            // 
            this.checkItalic.AutoSize = true;
            this.checkItalic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkItalic.Location = new System.Drawing.Point(293, 96);
            this.checkItalic.Name = "checkItalic";
            this.checkItalic.Size = new System.Drawing.Size(118, 31);
            this.checkItalic.TabIndex = 2;
            this.checkItalic.Text = "Cursiva";
            this.checkItalic.UseVisualStyleBackColor = true;
            this.checkItalic.CheckedChanged += new System.EventHandler(this.checkItalic_CheckedChanged);
            // 
            // CheckBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 157);
            this.Controls.Add(this.checkItalic);
            this.Controls.Add(this.checkBold);
            this.Controls.Add(this.lblTitle);
            this.Name = "CheckBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBoxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox checkBold;
        private System.Windows.Forms.CheckBox checkItalic;
    }
}