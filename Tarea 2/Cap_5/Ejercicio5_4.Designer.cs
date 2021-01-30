
namespace Tarea2.Cap_5
{
    partial class Ejercicio5_4
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
            this.resultado1Label = new System.Windows.Forms.Label();
            this.resultado2Label = new System.Windows.Forms.Label();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.resultado1TextBox = new System.Windows.Forms.TextBox();
            this.resultado2TextBox = new System.Windows.Forms.TextBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(102, 21);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(313, 25);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Calcular el factorial de un número";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numLabel.Location = new System.Drawing.Point(68, 98);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(135, 20);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "Ingrese un número:";
            // 
            // resultado1Label
            // 
            this.resultado1Label.AutoSize = true;
            this.resultado1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultado1Label.Location = new System.Drawing.Point(80, 180);
            this.resultado1Label.Name = "resultado1Label";
            this.resultado1Label.Size = new System.Drawing.Size(103, 21);
            this.resultado1Label.TabIndex = 2;
            this.resultado1Label.Text = "El factorial de";
            // 
            // resultado2Label
            // 
            this.resultado2Label.AutoSize = true;
            this.resultado2Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultado2Label.Location = new System.Drawing.Point(294, 180);
            this.resultado2Label.Name = "resultado2Label";
            this.resultado2Label.Size = new System.Drawing.Size(25, 21);
            this.resultado2Label.TabIndex = 3;
            this.resultado2Label.Text = "es";
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(209, 96);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(96, 23);
            this.numTextBox.TabIndex = 4;
            // 
            // resultado1TextBox
            // 
            this.resultado1TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado1TextBox.Location = new System.Drawing.Point(189, 177);
            this.resultado1TextBox.Name = "resultado1TextBox";
            this.resultado1TextBox.Size = new System.Drawing.Size(99, 29);
            this.resultado1TextBox.TabIndex = 5;
            // 
            // resultado2TextBox
            // 
            this.resultado2TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultado2TextBox.Location = new System.Drawing.Point(325, 177);
            this.resultado2TextBox.Name = "resultado2TextBox";
            this.resultado2TextBox.Size = new System.Drawing.Size(130, 29);
            this.resultado2TextBox.TabIndex = 6;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AceptarButton.Location = new System.Drawing.Point(311, 91);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(104, 33);
            this.AceptarButton.TabIndex = 7;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // Ejercicio5_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 274);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.resultado2TextBox);
            this.Controls.Add(this.resultado1TextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.resultado2Label);
            this.Controls.Add(this.resultado1Label);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Ejercicio5_4";
            this.Text = "Ejercicio5_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label resultado1Label;
        private System.Windows.Forms.Label resultado2Label;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox resultado1TextBox;
        private System.Windows.Forms.TextBox resultado2TextBox;
        private System.Windows.Forms.Button AceptarButton;
    }
}