using System.Windows.Forms;

namespace P2_GuiaFormsControls.Forms.RadioButton
{
    partial class RadioButtonForm
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

        private MessageBoxIcon tipoIcono;
        private MessageBoxButtons tipoBoton;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxButtonType = new System.Windows.Forms.GroupBox();
            this.rbtnRetryCancel = new System.Windows.Forms.RadioButton();
            this.rbtnYesNo = new System.Windows.Forms.RadioButton();
            this.rbtnYesNoCancel = new System.Windows.Forms.RadioButton();
            this.rbtnAbort = new System.Windows.Forms.RadioButton();
            this.rbtnAcceptCancel = new System.Windows.Forms.RadioButton();
            this.rbtnAccept = new System.Windows.Forms.RadioButton();
            this.gbxIcon = new System.Windows.Forms.GroupBox();
            this.rbtnWarning = new System.Windows.Forms.RadioButton();
            this.rbtnStop = new System.Windows.Forms.RadioButton();
            this.rbtnQuestion = new System.Windows.Forms.RadioButton();
            this.rbtnInfo = new System.Windows.Forms.RadioButton();
            this.rbtnHand = new System.Windows.Forms.RadioButton();
            this.rbtnExclamation = new System.Windows.Forms.RadioButton();
            this.rbtnError = new System.Windows.Forms.RadioButton();
            this.rbtnAsterisk = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbxButtonType.SuspendLayout();
            this.gbxIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxButtonType
            // 
            this.gbxButtonType.Controls.Add(this.rbtnRetryCancel);
            this.gbxButtonType.Controls.Add(this.rbtnYesNo);
            this.gbxButtonType.Controls.Add(this.rbtnYesNoCancel);
            this.gbxButtonType.Controls.Add(this.rbtnAbort);
            this.gbxButtonType.Controls.Add(this.rbtnAcceptCancel);
            this.gbxButtonType.Controls.Add(this.rbtnAccept);
            this.gbxButtonType.Location = new System.Drawing.Point(39, 50);
            this.gbxButtonType.Name = "gbxButtonType";
            this.gbxButtonType.Size = new System.Drawing.Size(327, 268);
            this.gbxButtonType.TabIndex = 0;
            this.gbxButtonType.TabStop = false;
            this.gbxButtonType.Text = "Tipo de botón";
            // 
            // rbtnRetryCancel
            // 
            this.rbtnRetryCancel.AutoSize = true;
            this.rbtnRetryCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRetryCancel.Location = new System.Drawing.Point(15, 219);
            this.rbtnRetryCancel.Name = "rbtnRetryCancel";
            this.rbtnRetryCancel.Size = new System.Drawing.Size(244, 31);
            this.rbtnRetryCancel.TabIndex = 5;
            this.rbtnRetryCancel.TabStop = true;
            this.rbtnRetryCancel.Text = "ReintentarCancelar";
            this.rbtnRetryCancel.UseVisualStyleBackColor = true;
            this.rbtnRetryCancel.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChange);
            // 
            // rbtnYesNo
            // 
            this.rbtnYesNo.AutoSize = true;
            this.rbtnYesNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYesNo.Location = new System.Drawing.Point(15, 182);
            this.rbtnYesNo.Name = "rbtnYesNo";
            this.rbtnYesNo.Size = new System.Drawing.Size(89, 31);
            this.rbtnYesNo.TabIndex = 4;
            this.rbtnYesNo.TabStop = true;
            this.rbtnYesNo.Text = "SíNo";
            this.rbtnYesNo.UseVisualStyleBackColor = true;
            this.rbtnYesNo.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChange);
            // 
            // rbtnYesNoCancel
            // 
            this.rbtnYesNoCancel.AutoSize = true;
            this.rbtnYesNoCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYesNoCancel.Location = new System.Drawing.Point(15, 145);
            this.rbtnYesNoCancel.Name = "rbtnYesNoCancel";
            this.rbtnYesNoCancel.Size = new System.Drawing.Size(185, 31);
            this.rbtnYesNoCancel.TabIndex = 3;
            this.rbtnYesNoCancel.TabStop = true;
            this.rbtnYesNoCancel.Text = "SíNoCancelar";
            this.rbtnYesNoCancel.UseVisualStyleBackColor = true;
            this.rbtnYesNoCancel.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChange);
            // 
            // rbtnAbort
            // 
            this.rbtnAbort.AutoSize = true;
            this.rbtnAbort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAbort.Location = new System.Drawing.Point(15, 108);
            this.rbtnAbort.Name = "rbtnAbort";
            this.rbtnAbort.Size = new System.Drawing.Size(302, 31);
            this.rbtnAbort.TabIndex = 2;
            this.rbtnAbort.TabStop = true;
            this.rbtnAbort.Text = "AbortarReintentarIgnorar";
            this.rbtnAbort.UseVisualStyleBackColor = true;
            this.rbtnAbort.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChange);
            // 
            // rbtnAcceptCancel
            // 
            this.rbtnAcceptCancel.AutoSize = true;
            this.rbtnAcceptCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAcceptCancel.Location = new System.Drawing.Point(15, 71);
            this.rbtnAcceptCancel.Name = "rbtnAcceptCancel";
            this.rbtnAcceptCancel.Size = new System.Drawing.Size(215, 31);
            this.rbtnAcceptCancel.TabIndex = 1;
            this.rbtnAcceptCancel.TabStop = true;
            this.rbtnAcceptCancel.Text = "AceptarCancelar";
            this.rbtnAcceptCancel.UseVisualStyleBackColor = true;
            this.rbtnAcceptCancel.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChange);
            // 
            // rbtnAccept
            // 
            this.rbtnAccept.AutoSize = true;
            this.rbtnAccept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAccept.Location = new System.Drawing.Point(15, 34);
            this.rbtnAccept.Name = "rbtnAccept";
            this.rbtnAccept.Size = new System.Drawing.Size(119, 31);
            this.rbtnAccept.TabIndex = 0;
            this.rbtnAccept.TabStop = true;
            this.rbtnAccept.Text = "Aceptar";
            this.rbtnAccept.UseVisualStyleBackColor = true;
            this.rbtnAccept.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckedChange);
            // 
            // gbxIcon
            // 
            this.gbxIcon.Controls.Add(this.rbtnWarning);
            this.gbxIcon.Controls.Add(this.rbtnStop);
            this.gbxIcon.Controls.Add(this.rbtnQuestion);
            this.gbxIcon.Controls.Add(this.rbtnInfo);
            this.gbxIcon.Controls.Add(this.rbtnHand);
            this.gbxIcon.Controls.Add(this.rbtnExclamation);
            this.gbxIcon.Controls.Add(this.rbtnError);
            this.gbxIcon.Controls.Add(this.rbtnAsterisk);
            this.gbxIcon.Location = new System.Drawing.Point(393, 50);
            this.gbxIcon.Name = "gbxIcon";
            this.gbxIcon.Size = new System.Drawing.Size(200, 333);
            this.gbxIcon.TabIndex = 1;
            this.gbxIcon.TabStop = false;
            this.gbxIcon.Text = "Icono";
            // 
            // rbtnWarning
            // 
            this.rbtnWarning.AutoSize = true;
            this.rbtnWarning.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnWarning.Location = new System.Drawing.Point(15, 284);
            this.rbtnWarning.Name = "rbtnWarning";
            this.rbtnWarning.Size = new System.Drawing.Size(162, 31);
            this.rbtnWarning.TabIndex = 13;
            this.rbtnWarning.TabStop = true;
            this.rbtnWarning.Text = "Advertencia";
            this.rbtnWarning.UseVisualStyleBackColor = true;
            this.rbtnWarning.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // rbtnStop
            // 
            this.rbtnStop.AutoSize = true;
            this.rbtnStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStop.Location = new System.Drawing.Point(15, 247);
            this.rbtnStop.Name = "rbtnStop";
            this.rbtnStop.Size = new System.Drawing.Size(78, 31);
            this.rbtnStop.TabIndex = 12;
            this.rbtnStop.TabStop = true;
            this.rbtnStop.Text = "Alto";
            this.rbtnStop.UseVisualStyleBackColor = true;
            this.rbtnStop.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // rbtnQuestion
            // 
            this.rbtnQuestion.AutoSize = true;
            this.rbtnQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQuestion.Location = new System.Drawing.Point(15, 210);
            this.rbtnQuestion.Name = "rbtnQuestion";
            this.rbtnQuestion.Size = new System.Drawing.Size(136, 31);
            this.rbtnQuestion.TabIndex = 11;
            this.rbtnQuestion.TabStop = true;
            this.rbtnQuestion.Text = "Pregunta";
            this.rbtnQuestion.UseVisualStyleBackColor = true;
            this.rbtnQuestion.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // rbtnInfo
            // 
            this.rbtnInfo.AutoSize = true;
            this.rbtnInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInfo.Location = new System.Drawing.Point(15, 173);
            this.rbtnInfo.Name = "rbtnInfo";
            this.rbtnInfo.Size = new System.Drawing.Size(162, 31);
            this.rbtnInfo.TabIndex = 10;
            this.rbtnInfo.TabStop = true;
            this.rbtnInfo.Text = "Información";
            this.rbtnInfo.UseVisualStyleBackColor = true;
            this.rbtnInfo.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // rbtnHand
            // 
            this.rbtnHand.AutoSize = true;
            this.rbtnHand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHand.Location = new System.Drawing.Point(15, 136);
            this.rbtnHand.Name = "rbtnHand";
            this.rbtnHand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnHand.Size = new System.Drawing.Size(96, 31);
            this.rbtnHand.TabIndex = 9;
            this.rbtnHand.TabStop = true;
            this.rbtnHand.Text = "Mano";
            this.rbtnHand.UseVisualStyleBackColor = true;
            this.rbtnHand.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // rbtnExclamation
            // 
            this.rbtnExclamation.AutoSize = true;
            this.rbtnExclamation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnExclamation.Location = new System.Drawing.Point(15, 99);
            this.rbtnExclamation.Name = "rbtnExclamation";
            this.rbtnExclamation.Size = new System.Drawing.Size(172, 31);
            this.rbtnExclamation.TabIndex = 8;
            this.rbtnExclamation.TabStop = true;
            this.rbtnExclamation.Text = "Exclamación";
            this.rbtnExclamation.UseVisualStyleBackColor = true;
            this.rbtnExclamation.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // rbtnError
            // 
            this.rbtnError.AutoSize = true;
            this.rbtnError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnError.Location = new System.Drawing.Point(15, 62);
            this.rbtnError.Name = "rbtnError";
            this.rbtnError.Size = new System.Drawing.Size(90, 31);
            this.rbtnError.TabIndex = 7;
            this.rbtnError.TabStop = true;
            this.rbtnError.Text = "Error";
            this.rbtnError.UseVisualStyleBackColor = true;
            this.rbtnError.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // rbtnAsterisk
            // 
            this.rbtnAsterisk.AutoSize = true;
            this.rbtnAsterisk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAsterisk.Location = new System.Drawing.Point(15, 25);
            this.rbtnAsterisk.Name = "rbtnAsterisk";
            this.rbtnAsterisk.Size = new System.Drawing.Size(134, 31);
            this.rbtnAsterisk.TabIndex = 6;
            this.rbtnAsterisk.TabStop = true;
            this.rbtnAsterisk.Text = "Asterisco";
            this.rbtnAsterisk.UseVisualStyleBackColor = true;
            this.rbtnAsterisk.CheckedChanged += new System.EventHandler(this.tipoIcono_CheckedChange);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(119, 331);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(150, 41);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Motrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(144, 380);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 23);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 437);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbxIcon);
            this.Controls.Add(this.gbxButtonType);
            this.Name = "RadioButtonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioButtonForm";
            this.gbxButtonType.ResumeLayout(false);
            this.gbxButtonType.PerformLayout();
            this.gbxIcon.ResumeLayout(false);
            this.gbxIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxButtonType;
        private System.Windows.Forms.GroupBox gbxIcon;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbtnRetryCancel;
        private System.Windows.Forms.RadioButton rbtnYesNo;
        private System.Windows.Forms.RadioButton rbtnYesNoCancel;
        private System.Windows.Forms.RadioButton rbtnAbort;
        private System.Windows.Forms.RadioButton rbtnAcceptCancel;
        private System.Windows.Forms.RadioButton rbtnAccept;
        private System.Windows.Forms.RadioButton rbtnAsterisk;
        private System.Windows.Forms.RadioButton rbtnWarning;
        private System.Windows.Forms.RadioButton rbtnStop;
        private System.Windows.Forms.RadioButton rbtnQuestion;
        private System.Windows.Forms.RadioButton rbtnInfo;
        private System.Windows.Forms.RadioButton rbtnHand;
        private System.Windows.Forms.RadioButton rbtnExclamation;
        private System.Windows.Forms.RadioButton rbtnError;
        private Label lblResult;
    }
}