
namespace Tarea2.Cap_6
{
    partial class Ejercicio6_5
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
            this.mayorTextBox = new System.Windows.Forms.TextBox();
            this.mayorLabel = new System.Windows.Forms.Label();
            this.menorTextBox = new System.Windows.Forms.TextBox();
            this.menorLabel = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.califListBox = new System.Windows.Forms.ListBox();
            this.salonesTextBox = new System.Windows.Forms.TextBox();
            this.salonesLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mayorTextBox
            // 
            this.mayorTextBox.Location = new System.Drawing.Point(514, 110);
            this.mayorTextBox.Name = "mayorTextBox";
            this.mayorTextBox.Size = new System.Drawing.Size(37, 23);
            this.mayorTextBox.TabIndex = 43;
            // 
            // mayorLabel
            // 
            this.mayorLabel.AutoSize = true;
            this.mayorLabel.Location = new System.Drawing.Point(401, 113);
            this.mayorLabel.Name = "mayorLabel";
            this.mayorLabel.Size = new System.Drawing.Size(107, 15);
            this.mayorLabel.TabIndex = 42;
            this.mayorLabel.Text = "Mayor calificación:";
            // 
            // menorTextBox
            // 
            this.menorTextBox.Location = new System.Drawing.Point(352, 110);
            this.menorTextBox.Name = "menorTextBox";
            this.menorTextBox.Size = new System.Drawing.Size(35, 23);
            this.menorTextBox.TabIndex = 41;
            // 
            // menorLabel
            // 
            this.menorLabel.AutoSize = true;
            this.menorLabel.Location = new System.Drawing.Point(238, 113);
            this.menorLabel.Name = "menorLabel";
            this.menorLabel.Size = new System.Drawing.Size(108, 15);
            this.menorLabel.TabIndex = 40;
            this.menorLabel.Text = "Menor calificación:";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(292, 63);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 39;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(179, 110);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.Size = new System.Drawing.Size(53, 23);
            this.promedioTextBox.TabIndex = 37;
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promedioLabel.Location = new System.Drawing.Point(111, 113);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(62, 15);
            this.promedioLabel.TabIndex = 36;
            this.promedioLabel.Text = "Promedio:";
            // 
            // califListBox
            // 
            this.califListBox.FormattingEnabled = true;
            this.califListBox.ItemHeight = 15;
            this.califListBox.Location = new System.Drawing.Point(111, 152);
            this.califListBox.Name = "califListBox";
            this.califListBox.Size = new System.Drawing.Size(440, 169);
            this.califListBox.TabIndex = 35;
            // 
            // salonesTextBox
            // 
            this.salonesTextBox.Location = new System.Drawing.Point(233, 64);
            this.salonesTextBox.Name = "salonesTextBox";
            this.salonesTextBox.Size = new System.Drawing.Size(53, 23);
            this.salonesTextBox.TabIndex = 32;
            // 
            // salonesLabel
            // 
            this.salonesLabel.AutoSize = true;
            this.salonesLabel.Location = new System.Drawing.Point(111, 67);
            this.salonesLabel.Name = "salonesLabel";
            this.salonesLabel.Size = new System.Drawing.Size(116, 15);
            this.salonesLabel.TabIndex = 31;
            this.salonesLabel.Text = "Cantidad de salones:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(130, 21);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(408, 17);
            this.tituloLabel.TabIndex = 44;
            this.tituloLabel.Text = "Calificaciones con Arreglo jagged como parámetro de una función";
            // 
            // Ejercicio6_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 388);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.mayorTextBox);
            this.Controls.Add(this.mayorLabel);
            this.Controls.Add(this.menorTextBox);
            this.Controls.Add(this.menorLabel);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.promedioLabel);
            this.Controls.Add(this.califListBox);
            this.Controls.Add(this.salonesTextBox);
            this.Controls.Add(this.salonesLabel);
            this.Name = "Ejercicio6_5";
            this.Text = "Ejercicio6_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mayorTextBox;
        private System.Windows.Forms.Label mayorLabel;
        private System.Windows.Forms.TextBox menorTextBox;
        private System.Windows.Forms.Label menorLabel;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.ListBox califListBox;
        private System.Windows.Forms.TextBox salonesTextBox;
        private System.Windows.Forms.Label salonesLabel;
        private System.Windows.Forms.Label tituloLabel;
    }
}