namespace P2_GuiaFormsControls.Forms.NumericUpDown
{
    partial class NumericUpDownForm
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblTasaInteres = new System.Windows.Forms.Label();
            this.lblAnios = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.nudAnios = new System.Windows.Forms.NumericUpDown();
            this.lblSaldoAnual = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(32, 41);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(112, 27);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal:";
            // 
            // lblTasaInteres
            // 
            this.lblTasaInteres.AutoSize = true;
            this.lblTasaInteres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasaInteres.Location = new System.Drawing.Point(32, 91);
            this.lblTasaInteres.Name = "lblTasaInteres";
            this.lblTasaInteres.Size = new System.Drawing.Size(147, 27);
            this.lblTasaInteres.TabIndex = 1;
            this.lblTasaInteres.Text = "Tasa interés:";
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnios.Location = new System.Drawing.Point(32, 138);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(73, 27);
            this.lblAnios.TabIndex = 2;
            this.lblAnios.Text = "Años:";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.Location = new System.Drawing.Point(189, 33);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(194, 35);
            this.txtPrincipal.TabIndex = 3;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaInteres.Location = new System.Drawing.Point(189, 83);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(194, 35);
            this.txtTasaInteres.TabIndex = 4;
            // 
            // nudAnios
            // 
            this.nudAnios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnios.Location = new System.Drawing.Point(189, 136);
            this.nudAnios.Name = "nudAnios";
            this.nudAnios.Size = new System.Drawing.Size(194, 35);
            this.nudAnios.TabIndex = 5;
            // 
            // lblSaldoAnual
            // 
            this.lblSaldoAnual.AutoSize = true;
            this.lblSaldoAnual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAnual.Location = new System.Drawing.Point(33, 231);
            this.lblSaldoAnual.Name = "lblSaldoAnual";
            this.lblSaldoAnual.Size = new System.Drawing.Size(288, 27);
            this.lblSaldoAnual.TabIndex = 6;
            this.lblSaldoAnual.Text = "Saldo anual de la cuenta:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(38, 270);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(500, 182);
            this.txtResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(404, 33);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // NumericUpDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 478);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblSaldoAnual);
            this.Controls.Add(this.nudAnios);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblAnios);
            this.Controls.Add(this.lblTasaInteres);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "NumericUpDownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumericUpDownForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblTasaInteres;
        private System.Windows.Forms.Label lblAnios;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.NumericUpDown nudAnios;
        private System.Windows.Forms.Label lblSaldoAnual;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}