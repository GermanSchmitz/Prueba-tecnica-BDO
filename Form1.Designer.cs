
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.identificar1 = new System.Windows.Forms.Button();
            this.identificar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.numero3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // identificar1
            // 
            this.identificar1.Location = new System.Drawing.Point(256, 198);
            this.identificar1.Name = "identificar1";
            this.identificar1.Size = new System.Drawing.Size(85, 46);
            this.identificar1.TabIndex = 3;
            this.identificar1.Text = "identificar1";
            this.identificar1.UseVisualStyleBackColor = true;
            this.identificar1.Click += new System.EventHandler(this.identificar1_Click);
            // 
            // identificar2
            // 
            this.identificar2.Location = new System.Drawing.Point(403, 198);
            this.identificar2.Name = "identificar2";
            this.identificar2.Size = new System.Drawing.Size(80, 46);
            this.identificar2.TabIndex = 4;
            this.identificar2.Text = "identificar2";
            this.identificar2.UseVisualStyleBackColor = true;
            this.identificar2.Click += new System.EventHandler(this.identificar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero 3";
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(325, 92);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(158, 20);
            this.numero1.TabIndex = 8;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(325, 118);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(158, 20);
            this.numero2.TabIndex = 9;
            // 
            // numero3
            // 
            this.numero3.Location = new System.Drawing.Point(325, 144);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(158, 20);
            this.numero3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.identificar2);
            this.Controls.Add(this.identificar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button identificar1;
        private System.Windows.Forms.Button identificar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox numero3;
    }
}

