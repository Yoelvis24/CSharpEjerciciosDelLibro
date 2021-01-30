
namespace Tarea2.Cap_4
{
    partial class Ejercicio4_2
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
            this.potenciaLabel = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.potenciatextBox = new System.Windows.Forms.TextBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(87, 30);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(322, 25);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Calcular la potencia de un número:";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numLabel.Location = new System.Drawing.Point(28, 113);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(135, 20);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "Número a ingresar:";
            // 
            // potenciaLabel
            // 
            this.potenciaLabel.AutoSize = true;
            this.potenciaLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potenciaLabel.Location = new System.Drawing.Point(302, 113);
            this.potenciaLabel.Name = "potenciaLabel";
            this.potenciaLabel.Size = new System.Drawing.Size(68, 20);
            this.potenciaLabel.TabIndex = 2;
            this.potenciaLabel.Text = "Potencia:";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultadoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resultadoLabel.Location = new System.Drawing.Point(191, 236);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(101, 25);
            this.resultadoLabel.TabIndex = 3;
            this.resultadoLabel.Text = "Resultado:";
            // 
            // numTextBox
            // 
            this.numTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTextBox.Location = new System.Drawing.Point(169, 110);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(123, 27);
            this.numTextBox.TabIndex = 4;
            // 
            // potenciatextBox
            // 
            this.potenciatextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potenciatextBox.Location = new System.Drawing.Point(376, 110);
            this.potenciatextBox.Name = "potenciatextBox";
            this.potenciatextBox.Size = new System.Drawing.Size(100, 27);
            this.potenciatextBox.TabIndex = 5;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AceptarButton.Location = new System.Drawing.Point(180, 157);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(127, 40);
            this.AceptarButton.TabIndex = 7;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.ItemHeight = 21;
            this.resultadoListBox.Location = new System.Drawing.Point(167, 274);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(151, 46);
            this.resultadoListBox.TabIndex = 8;
            // 
            // Ejercicio4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 361);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.potenciatextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.potenciaLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Ejercicio4_2";
            this.Text = "Ejercicio4_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label potenciaLabel;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox potenciatextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.ListBox resultadoListBox;
    }
}