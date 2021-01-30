
namespace Tarea2
{
    partial class Ejercicio4_1
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
            this.numTablaLabel = new System.Windows.Forms.Label();
            this.numTablaTextBox = new System.Windows.Forms.TextBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.tablaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numTablaLabel
            // 
            this.numTablaLabel.AutoSize = true;
            this.numTablaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numTablaLabel.Location = new System.Drawing.Point(36, 52);
            this.numTablaLabel.Name = "numTablaLabel";
            this.numTablaLabel.Size = new System.Drawing.Size(143, 21);
            this.numTablaLabel.TabIndex = 0;
            this.numTablaLabel.Text = "Número de tabla:";
            // 
            // numTablaTextBox
            // 
            this.numTablaTextBox.Location = new System.Drawing.Point(185, 54);
            this.numTablaTextBox.Name = "numTablaTextBox";
            this.numTablaTextBox.Size = new System.Drawing.Size(100, 23);
            this.numTablaTextBox.TabIndex = 1;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(306, 54);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 2;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // tablaListBox
            // 
            this.tablaListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tablaListBox.FormattingEnabled = true;
            this.tablaListBox.ItemHeight = 30;
            this.tablaListBox.Location = new System.Drawing.Point(36, 102);
            this.tablaListBox.Name = "tablaListBox";
            this.tablaListBox.Size = new System.Drawing.Size(345, 304);
            this.tablaListBox.TabIndex = 3;
            // 
            // Ejercicio4AForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.tablaListBox);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.numTablaTextBox);
            this.Controls.Add(this.numTablaLabel);
            this.Name = "Ejercicio4AForm";
            this.Text = "Ejercicio 4.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numTablaLabel;
        private System.Windows.Forms.TextBox numTablaTextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.ListBox tablaListBox;
    }
}