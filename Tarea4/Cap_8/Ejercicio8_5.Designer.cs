
namespace Tarea2.Tarea4.Cap_8
{
    partial class Ejercicio8_5
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
            this.PrimeraCadenaLabel = new System.Windows.Forms.Label();
            this.CadenasListBox = new System.Windows.Forms.ListBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.PrimeraCadenaTextBox = new System.Windows.Forms.TextBox();
            this.SegundaCadenaLabel = new System.Windows.Forms.Label();
            this.SegundaCadenaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrimeraCadenaLabel
            // 
            this.PrimeraCadenaLabel.AutoSize = true;
            this.PrimeraCadenaLabel.Location = new System.Drawing.Point(12, 9);
            this.PrimeraCadenaLabel.Name = "PrimeraCadenaLabel";
            this.PrimeraCadenaLabel.Size = new System.Drawing.Size(145, 15);
            this.PrimeraCadenaLabel.TabIndex = 0;
            this.PrimeraCadenaLabel.Text = "Ingresa la primera cadena:";
            // 
            // CadenasListBox
            // 
            this.CadenasListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadenasListBox.FormattingEnabled = true;
            this.CadenasListBox.ItemHeight = 21;
            this.CadenasListBox.Location = new System.Drawing.Point(204, 12);
            this.CadenasListBox.Name = "CadenasListBox";
            this.CadenasListBox.Size = new System.Drawing.Size(215, 130);
            this.CadenasListBox.TabIndex = 1;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(82, 119);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // PrimeraCadenaTextBox
            // 
            this.PrimeraCadenaTextBox.Location = new System.Drawing.Point(12, 27);
            this.PrimeraCadenaTextBox.Name = "PrimeraCadenaTextBox";
            this.PrimeraCadenaTextBox.Size = new System.Drawing.Size(145, 23);
            this.PrimeraCadenaTextBox.TabIndex = 3;
            // 
            // SegundaCadenaLabel
            // 
            this.SegundaCadenaLabel.AutoSize = true;
            this.SegundaCadenaLabel.Location = new System.Drawing.Point(12, 63);
            this.SegundaCadenaLabel.Name = "SegundaCadenaLabel";
            this.SegundaCadenaLabel.Size = new System.Drawing.Size(149, 15);
            this.SegundaCadenaLabel.TabIndex = 4;
            this.SegundaCadenaLabel.Text = "Ingrese la segunda cadena:";
            // 
            // SegundaCadenaTextBox
            // 
            this.SegundaCadenaTextBox.Location = new System.Drawing.Point(12, 81);
            this.SegundaCadenaTextBox.Name = "SegundaCadenaTextBox";
            this.SegundaCadenaTextBox.Size = new System.Drawing.Size(145, 23);
            this.SegundaCadenaTextBox.TabIndex = 5;
            // 
            // Ejercicio8_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 160);
            this.Controls.Add(this.SegundaCadenaTextBox);
            this.Controls.Add(this.SegundaCadenaLabel);
            this.Controls.Add(this.PrimeraCadenaTextBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.CadenasListBox);
            this.Controls.Add(this.PrimeraCadenaLabel);
            this.Name = "Ejercicio8_5";
            this.Text = "Ejercicio8_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrimeraCadenaLabel;
        private System.Windows.Forms.ListBox CadenasListBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox PrimeraCadenaTextBox;
        private System.Windows.Forms.Label SegundaCadenaLabel;
        private System.Windows.Forms.TextBox SegundaCadenaTextBox;
    }
}