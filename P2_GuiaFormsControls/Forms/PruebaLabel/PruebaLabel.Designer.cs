namespace P2_GuiaFormsControls.Forms.PruebaLabel
{
    partial class PruebaLabel
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
            this.btnMostrarClave = new System.Windows.Forms.Button();
            this.txtDigitarClave = new System.Windows.Forms.TextBox();
            this.lblVerClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarClave
            // 
            this.btnMostrarClave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarClave.Location = new System.Drawing.Point(197, 363);
            this.btnMostrarClave.Name = "btnMostrarClave";
            this.btnMostrarClave.Size = new System.Drawing.Size(228, 57);
            this.btnMostrarClave.TabIndex = 0;
            this.btnMostrarClave.Text = "Mostrar Clave";
            this.btnMostrarClave.UseVisualStyleBackColor = true;
            this.btnMostrarClave.Click += new System.EventHandler(this.btnMostrarClave_Click);
            // 
            // txtDigitarClave
            // 
            this.txtDigitarClave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigitarClave.Location = new System.Drawing.Point(137, 153);
            this.txtDigitarClave.Name = "txtDigitarClave";
            this.txtDigitarClave.PasswordChar = '*';
            this.txtDigitarClave.Size = new System.Drawing.Size(374, 35);
            this.txtDigitarClave.TabIndex = 1;
            // 
            // lblVerClave
            // 
            this.lblVerClave.AutoSize = true;
            this.lblVerClave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerClave.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblVerClave.Location = new System.Drawing.Point(203, 204);
            this.lblVerClave.Name = "lblVerClave";
            this.lblVerClave.Size = new System.Drawing.Size(234, 23);
            this.lblVerClave.TabIndex = 2;
            this.lblVerClave.Text = "Aquí se mostrará la clave";
            this.lblVerClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PruebaLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 478);
            this.Controls.Add(this.lblVerClave);
            this.Controls.Add(this.txtDigitarClave);
            this.Controls.Add(this.btnMostrarClave);
            this.Name = "PruebaLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PruebaLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarClave;
        private System.Windows.Forms.TextBox txtDigitarClave;
        private System.Windows.Forms.Label lblVerClave;
    }
}