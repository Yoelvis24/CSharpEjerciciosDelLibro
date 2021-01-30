
namespace Tarea2.Cap_7
{
    partial class Ejercicio7_2
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
            this.palabraLabel = new System.Windows.Forms.Label();
            this.palabraTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.significadoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(79, 42);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(188, 20);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Diccionario con Hashtable";
            // 
            // palabraLabel
            // 
            this.palabraLabel.AutoSize = true;
            this.palabraLabel.Location = new System.Drawing.Point(39, 103);
            this.palabraLabel.Name = "palabraLabel";
            this.palabraLabel.Size = new System.Drawing.Size(113, 15);
            this.palabraLabel.TabIndex = 1;
            this.palabraLabel.Text = "Ingrese una palabra:";
            // 
            // palabraTextBox
            // 
            this.palabraTextBox.Location = new System.Drawing.Point(158, 100);
            this.palabraTextBox.Name = "palabraTextBox";
            this.palabraTextBox.Size = new System.Drawing.Size(100, 23);
            this.palabraTextBox.TabIndex = 2;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(264, 100);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // significadoTextBox
            // 
            this.significadoTextBox.Location = new System.Drawing.Point(39, 160);
            this.significadoTextBox.Multiline = true;
            this.significadoTextBox.Name = "significadoTextBox";
            this.significadoTextBox.Size = new System.Drawing.Size(300, 133);
            this.significadoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Por defecto: carpeta";
            // 
            // Ejercicio7_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.significadoTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.palabraTextBox);
            this.Controls.Add(this.palabraLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Ejercicio7_2";
            this.Text = "Ejercicio7_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label palabraLabel;
        private System.Windows.Forms.TextBox palabraTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox significadoTextBox;
        private System.Windows.Forms.Label label1;
    }
}