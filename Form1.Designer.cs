namespace Ciber_Infrestructura_2026_A_HolaMundo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttValidar = new System.Windows.Forms.Button();
            this.textPassword1 = new System.Windows.Forms.TextBox();
            this.textPassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repite Contraseña:";
            // 
            // bttValidar
            // 
            this.bttValidar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttValidar.Location = new System.Drawing.Point(288, 119);
            this.bttValidar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttValidar.Name = "bttValidar";
            this.bttValidar.Size = new System.Drawing.Size(122, 28);
            this.bttValidar.TabIndex = 2;
            this.bttValidar.Text = "VALIDAR";
            this.bttValidar.UseVisualStyleBackColor = true;
            this.bttValidar.Click += new System.EventHandler(this.bttValidar_Click);
            // 
            // textPassword1
            // 
            this.textPassword1.Location = new System.Drawing.Point(173, 20);
            this.textPassword1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPassword1.Name = "textPassword1";
            this.textPassword1.Size = new System.Drawing.Size(238, 20);
            this.textPassword1.TabIndex = 3;
            // 
            // textPassword2
            // 
            this.textPassword2.Location = new System.Drawing.Point(173, 58);
            this.textPassword2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.Size = new System.Drawing.Size(238, 20);
            this.textPassword2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 173);
            this.Controls.Add(this.textPassword2);
            this.Controls.Add(this.textPassword1);
            this.Controls.Add(this.bttValidar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Hola Mundo";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttValidar;
        private System.Windows.Forms.TextBox textPassword1;
        private System.Windows.Forms.TextBox textPassword2;
    }
}

