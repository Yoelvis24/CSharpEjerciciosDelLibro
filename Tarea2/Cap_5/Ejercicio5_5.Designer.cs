
namespace Tarea2.Cap_5
{
    partial class Ejercicio5_5
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(12, 33);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(493, 25);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Al digitar un número el programa imprime su nombre";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numLabel.Location = new System.Drawing.Point(37, 134);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(201, 20);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "Digite un número del 0 al 10:";
            // 
            // numTextBox
            // 
            this.numTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numTextBox.Location = new System.Drawing.Point(244, 121);
            this.numTextBox.Multiline = true;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(56, 48);
            this.numTextBox.TabIndex = 2;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultadoLabel.Location = new System.Drawing.Point(215, 211);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(0, 32);
            this.resultadoLabel.TabIndex = 3;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AceptarButton.Location = new System.Drawing.Point(326, 122);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(78, 46);
            this.AceptarButton.TabIndex = 4;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // Ejercicio5_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 318);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Ejercicio5_5";
            this.Text = "Ejercicio5_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button AceptarButton;
    }
}