
namespace Tarea2.Cap_6
{
    partial class Ejercicio6_2
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
            this.salonesLabel = new System.Windows.Forms.Label();
            this.califLabel = new System.Windows.Forms.Label();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.menorLabel = new System.Windows.Forms.Label();
            this.salonesTextBox = new System.Windows.Forms.TextBox();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.menorTextBox = new System.Windows.Forms.TextBox();
            this.califListBox = new System.Windows.Forms.ListBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salonesLabel
            // 
            this.salonesLabel.AutoSize = true;
            this.salonesLabel.Location = new System.Drawing.Point(48, 73);
            this.salonesLabel.Name = "salonesLabel";
            this.salonesLabel.Size = new System.Drawing.Size(117, 15);
            this.salonesLabel.TabIndex = 0;
            this.salonesLabel.Text = "Cantidad de Salones:";
            // 
            // califLabel
            // 
            this.califLabel.AutoSize = true;
            this.califLabel.Location = new System.Drawing.Point(93, 132);
            this.califLabel.Name = "califLabel";
            this.califLabel.Size = new System.Drawing.Size(72, 15);
            this.califLabel.TabIndex = 1;
            this.califLabel.Text = "Calificación:";
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(277, 73);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(175, 15);
            this.cantidadLabel.TabIndex = 2;
            this.cantidadLabel.Text = "Cantidad de alumnos por salón:";
            // 
            // menorLabel
            // 
            this.menorLabel.AutoSize = true;
            this.menorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menorLabel.Location = new System.Drawing.Point(293, 131);
            this.menorLabel.Name = "menorLabel";
            this.menorLabel.Size = new System.Drawing.Size(134, 20);
            this.menorLabel.TabIndex = 3;
            this.menorLabel.Text = "Menor calificación:";
            // 
            // salonesTextBox
            // 
            this.salonesTextBox.Location = new System.Drawing.Point(171, 70);
            this.salonesTextBox.Name = "salonesTextBox";
            this.salonesTextBox.Size = new System.Drawing.Size(100, 23);
            this.salonesTextBox.TabIndex = 4;
            // 
            // AñadirButton
            // 
            this.AñadirButton.Location = new System.Drawing.Point(458, 69);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(75, 23);
            this.AñadirButton.TabIndex = 5;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(171, 128);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 6;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // menorTextBox
            // 
            this.menorTextBox.Location = new System.Drawing.Point(433, 128);
            this.menorTextBox.Name = "menorTextBox";
            this.menorTextBox.Size = new System.Drawing.Size(100, 23);
            this.menorTextBox.TabIndex = 7;
            // 
            // califListBox
            // 
            this.califListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.califListBox.FormattingEnabled = true;
            this.califListBox.ItemHeight = 20;
            this.califListBox.Location = new System.Drawing.Point(99, 184);
            this.califListBox.Name = "califListBox";
            this.califListBox.Size = new System.Drawing.Size(434, 184);
            this.califListBox.TabIndex = 8;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(170, 25);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(257, 17);
            this.tituloLabel.TabIndex = 9;
            this.tituloLabel.Text = "Menor calificación usando arreglo jadded";
            // 
            // Ejercicio6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 415);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.califListBox);
            this.Controls.Add(this.menorTextBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.salonesTextBox);
            this.Controls.Add(this.menorLabel);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.califLabel);
            this.Controls.Add(this.salonesLabel);
            this.Name = "Ejercicio6_2";
            this.Text = "Ejercicio6_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salonesLabel;
        private System.Windows.Forms.Label califLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label menorLabel;
        private System.Windows.Forms.TextBox salonesTextBox;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox menorTextBox;
        private System.Windows.Forms.ListBox califListBox;
        private System.Windows.Forms.Label tituloLabel;
    }
}