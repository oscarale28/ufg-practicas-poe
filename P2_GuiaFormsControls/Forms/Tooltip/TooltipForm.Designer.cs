namespace P2_GuiaFormsControls.Forms.Tooltip
{
    partial class TooltipForm
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
            this.components = new System.ComponentModel.Container();
            this.lblEtiqueta1 = new System.Windows.Forms.Label();
            this.lblEtiqueta2 = new System.Windows.Forms.Label();
            this.tlpEtiquetas = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta1.Location = new System.Drawing.Point(78, 88);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(233, 27);
            this.lblEtiqueta1.TabIndex = 0;
            this.lblEtiqueta1.Text = "Esta es una etiqueta";
            this.tlpEtiquetas.SetToolTip(this.lblEtiqueta1, "Primera etiqueta");
            // 
            // lblEtiqueta2
            // 
            this.lblEtiqueta2.AutoSize = true;
            this.lblEtiqueta2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta2.Location = new System.Drawing.Point(78, 170);
            this.lblEtiqueta2.Name = "lblEtiqueta2";
            this.lblEtiqueta2.Size = new System.Drawing.Size(233, 27);
            this.lblEtiqueta2.TabIndex = 1;
            this.lblEtiqueta2.Text = "Esta es otra etiqueta";
            this.tlpEtiquetas.SetToolTip(this.lblEtiqueta2, "Segunda etiqueta");
            // 
            // TooltipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 292);
            this.Controls.Add(this.lblEtiqueta2);
            this.Controls.Add(this.lblEtiqueta1);
            this.Name = "TooltipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TooltipForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta1;
        private System.Windows.Forms.ToolTip tlpEtiquetas;
        private System.Windows.Forms.Label lblEtiqueta2;
    }
}