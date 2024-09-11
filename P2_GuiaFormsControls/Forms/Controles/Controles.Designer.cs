namespace P2_GuiaFormsControls.Forms.Controles
{
    partial class Controles
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
            this.btnDisplayTextboxes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayTextboxes
            // 
            this.btnDisplayTextboxes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayTextboxes.Location = new System.Drawing.Point(155, 302);
            this.btnDisplayTextboxes.Name = "btnDisplayTextboxes";
            this.btnDisplayTextboxes.Size = new System.Drawing.Size(231, 63);
            this.btnDisplayTextboxes.TabIndex = 0;
            this.btnDisplayTextboxes.Text = "Agregar textboxes";
            this.btnDisplayTextboxes.UseVisualStyleBackColor = true;
            this.btnDisplayTextboxes.Click += new System.EventHandler(this.btnDisplayTextboxes_Click);
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 392);
            this.Controls.Add(this.btnDisplayTextboxes);
            this.Name = "Controles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayTextboxes;
    }
}