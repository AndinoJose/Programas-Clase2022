namespace Programacion3IPAC2022
{
    partial class Suma
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
            this.resultadotextBox = new System.Windows.Forms.TextBox();
            this.sumarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num2textBox = new System.Windows.Forms.TextBox();
            this.num1textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultadotextBox
            // 
            this.resultadotextBox.Location = new System.Drawing.Point(252, 234);
            this.resultadotextBox.Name = "resultadotextBox";
            this.resultadotextBox.Size = new System.Drawing.Size(100, 20);
            this.resultadotextBox.TabIndex = 0;
            // 
            // sumarbutton
            // 
            this.sumarbutton.Location = new System.Drawing.Point(108, 234);
            this.sumarbutton.Name = "sumarbutton";
            this.sumarbutton.Size = new System.Drawing.Size(75, 23);
            this.sumarbutton.TabIndex = 1;
            this.sumarbutton.Text = "Sumar";
            this.sumarbutton.UseVisualStyleBackColor = true;
            this.sumarbutton.Click += new System.EventHandler(this.sumarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primer Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Numero";
            // 
            // num2textBox
            // 
            this.num2textBox.Location = new System.Drawing.Point(252, 167);
            this.num2textBox.Name = "num2textBox";
            this.num2textBox.Size = new System.Drawing.Size(100, 20);
            this.num2textBox.TabIndex = 5;
            // 
            // num1textBox
            // 
            this.num1textBox.Location = new System.Drawing.Point(252, 96);
            this.num1textBox.Name = "num1textBox";
            this.num1textBox.Size = new System.Drawing.Size(100, 20);
            this.num1textBox.TabIndex = 6;
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 345);
            this.Controls.Add(this.num1textBox);
            this.Controls.Add(this.num2textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumarbutton);
            this.Controls.Add(this.resultadotextBox);
            this.Name = "Suma";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultadotextBox;
        private System.Windows.Forms.Button sumarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num2textBox;
        private System.Windows.Forms.TextBox num1textBox;
    }
}