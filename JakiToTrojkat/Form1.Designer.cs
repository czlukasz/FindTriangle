namespace JakiToTrojkat
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSide0 = new System.Windows.Forms.TextBox();
            this.txtSide1 = new System.Windows.Forms.TextBox();
            this.txtSide2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckTriangle = new System.Windows.Forms.Button();
            this.lblSidesKind = new System.Windows.Forms.Label();
            this.lblAnglesKind = new System.Windows.Forms.Label();
            this.btnClearSides = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSide0
            // 
            this.txtSide0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSide0.Location = new System.Drawing.Point(239, 41);
            this.txtSide0.Name = "txtSide0";
            this.txtSide0.Size = new System.Drawing.Size(100, 34);
            this.txtSide0.TabIndex = 0;
            // 
            // txtSide1
            // 
            this.txtSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSide1.Location = new System.Drawing.Point(239, 123);
            this.txtSide1.Name = "txtSide1";
            this.txtSide1.Size = new System.Drawing.Size(100, 34);
            this.txtSide1.TabIndex = 1;
            // 
            // txtSide2
            // 
            this.txtSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSide2.Location = new System.Drawing.Point(239, 206);
            this.txtSide2.Name = "txtSide2";
            this.txtSide2.Size = new System.Drawing.Size(100, 34);
            this.txtSide2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Długość boku A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Długość boku B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(25, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Długość boku C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(395, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wynik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(395, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jakie ma boki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(395, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jakie ma kąty:";
            // 
            // btnCheckTriangle
            // 
            this.btnCheckTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckTriangle.Location = new System.Drawing.Point(30, 295);
            this.btnCheckTriangle.Name = "btnCheckTriangle";
            this.btnCheckTriangle.Size = new System.Drawing.Size(283, 71);
            this.btnCheckTriangle.TabIndex = 9;
            this.btnCheckTriangle.Text = "Sprawdź trójkąt";
            this.btnCheckTriangle.UseVisualStyleBackColor = true;
            this.btnCheckTriangle.Click += new System.EventHandler(this.btnCheckTriangle_Click);
            // 
            // lblSidesKind
            // 
            this.lblSidesKind.AutoSize = true;
            this.lblSidesKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSidesKind.Location = new System.Drawing.Point(395, 169);
            this.lblSidesKind.Name = "lblSidesKind";
            this.lblSidesKind.Size = new System.Drawing.Size(0, 29);
            this.lblSidesKind.TabIndex = 10;
            // 
            // lblAnglesKind
            // 
            this.lblAnglesKind.AutoSize = true;
            this.lblAnglesKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnglesKind.Location = new System.Drawing.Point(395, 255);
            this.lblAnglesKind.Name = "lblAnglesKind";
            this.lblAnglesKind.Size = new System.Drawing.Size(0, 29);
            this.lblAnglesKind.TabIndex = 11;
            // 
            // btnClearSides
            // 
            this.btnClearSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearSides.Location = new System.Drawing.Point(30, 373);
            this.btnClearSides.Name = "btnClearSides";
            this.btnClearSides.Size = new System.Drawing.Size(283, 49);
            this.btnClearSides.TabIndex = 12;
            this.btnClearSides.Text = "Wyczyść pola";
            this.btnClearSides.UseVisualStyleBackColor = true;
            this.btnClearSides.Click += new System.EventHandler(this.btnClearSides_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearSides);
            this.Controls.Add(this.lblAnglesKind);
            this.Controls.Add(this.lblSidesKind);
            this.Controls.Add(this.btnCheckTriangle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSide2);
            this.Controls.Add(this.txtSide1);
            this.Controls.Add(this.txtSide0);
            this.Name = "Form1";
            this.Text = "Jaki to trójkąt?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSide0;
        private System.Windows.Forms.TextBox txtSide1;
        private System.Windows.Forms.TextBox txtSide2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckTriangle;
        private System.Windows.Forms.Label lblSidesKind;
        private System.Windows.Forms.Label lblAnglesKind;
        private System.Windows.Forms.Button btnClearSides;
    }
}

