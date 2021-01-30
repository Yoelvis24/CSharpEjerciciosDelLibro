
namespace Tarea2.Cap_6
{
    partial class Ejercicio6_4
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
            this.AgregarButton = new System.Windows.Forms.Button();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.califListBox = new System.Windows.Forms.ListBox();
            this.calificacionLabel = new System.Windows.Forms.Label();
            this.alumnosLabel = new System.Windows.Forms.Label();
            this.salonesTextBox = new System.Windows.Forms.TextBox();
            this.salonesLabel = new System.Windows.Forms.Label();
            this.menorLabel = new System.Windows.Forms.Label();
            this.menorTextBox = new System.Windows.Forms.TextBox();
            this.mayorLabel = new System.Windows.Forms.Label();
            this.mayorTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(533, 82);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 26;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // AñadirButton
            // 
            this.AñadirButton.Location = new System.Drawing.Point(374, 82);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(75, 23);
            this.AñadirButton.TabIndex = 25;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(155, 125);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.Size = new System.Drawing.Size(53, 23);
            this.promedioTextBox.TabIndex = 24;
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promedioLabel.Location = new System.Drawing.Point(87, 128);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(62, 15);
            this.promedioLabel.TabIndex = 23;
            this.promedioLabel.Text = "Promedio:";
            // 
            // califListBox
            // 
            this.califListBox.FormattingEnabled = true;
            this.califListBox.ItemHeight = 15;
            this.califListBox.Location = new System.Drawing.Point(87, 167);
            this.califListBox.Name = "califListBox";
            this.califListBox.Size = new System.Drawing.Size(440, 169);
            this.califListBox.TabIndex = 22;
            // 
            // calificacionLabel
            // 
            this.calificacionLabel.AutoSize = true;
            this.calificacionLabel.Location = new System.Drawing.Point(455, 85);
            this.calificacionLabel.Name = "calificacionLabel";
            this.calificacionLabel.Size = new System.Drawing.Size(72, 15);
            this.calificacionLabel.TabIndex = 21;
            this.calificacionLabel.Text = "Calificación:";
            // 
            // alumnosLabel
            // 
            this.alumnosLabel.AutoSize = true;
            this.alumnosLabel.Location = new System.Drawing.Point(193, 85);
            this.alumnosLabel.Name = "alumnosLabel";
            this.alumnosLabel.Size = new System.Drawing.Size(175, 15);
            this.alumnosLabel.TabIndex = 20;
            this.alumnosLabel.Text = "Cantidad de alumnos por salón:";
            // 
            // salonesTextBox
            // 
            this.salonesTextBox.Location = new System.Drawing.Point(134, 82);
            this.salonesTextBox.Name = "salonesTextBox";
            this.salonesTextBox.Size = new System.Drawing.Size(53, 23);
            this.salonesTextBox.TabIndex = 19;
            // 
            // salonesLabel
            // 
            this.salonesLabel.AutoSize = true;
            this.salonesLabel.Location = new System.Drawing.Point(12, 85);
            this.salonesLabel.Name = "salonesLabel";
            this.salonesLabel.Size = new System.Drawing.Size(116, 15);
            this.salonesLabel.TabIndex = 18;
            this.salonesLabel.Text = "Cantidad de salones:";
            // 
            // menorLabel
            // 
            this.menorLabel.AutoSize = true;
            this.menorLabel.Location = new System.Drawing.Point(214, 128);
            this.menorLabel.Name = "menorLabel";
            this.menorLabel.Size = new System.Drawing.Size(108, 15);
            this.menorLabel.TabIndex = 27;
            this.menorLabel.Text = "Menor calificación:";
            // 
            // menorTextBox
            // 
            this.menorTextBox.Location = new System.Drawing.Point(328, 125);
            this.menorTextBox.Name = "menorTextBox";
            this.menorTextBox.Size = new System.Drawing.Size(35, 23);
            this.menorTextBox.TabIndex = 28;
            // 
            // mayorLabel
            // 
            this.mayorLabel.AutoSize = true;
            this.mayorLabel.Location = new System.Drawing.Point(377, 128);
            this.mayorLabel.Name = "mayorLabel";
            this.mayorLabel.Size = new System.Drawing.Size(107, 15);
            this.mayorLabel.TabIndex = 29;
            this.mayorLabel.Text = "Mayor calificación:";
            // 
            // mayorTextBox
            // 
            this.mayorTextBox.Location = new System.Drawing.Point(490, 125);
            this.mayorTextBox.Name = "mayorTextBox";
            this.mayorTextBox.Size = new System.Drawing.Size(37, 23);
            this.mayorTextBox.TabIndex = 30;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(154, 20);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(330, 17);
            this.tituloLabel.TabIndex = 31;
            this.tituloLabel.Text = "Calificaciones con arreglo jagged utilizando funciones";
            // 
            // Ejercicio6_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 369);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.mayorTextBox);
            this.Controls.Add(this.mayorLabel);
            this.Controls.Add(this.menorTextBox);
            this.Controls.Add(this.menorLabel);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.promedioLabel);
            this.Controls.Add(this.califListBox);
            this.Controls.Add(this.calificacionLabel);
            this.Controls.Add(this.alumnosLabel);
            this.Controls.Add(this.salonesTextBox);
            this.Controls.Add(this.salonesLabel);
            this.Name = "Ejercicio6_4";
            this.Text = "Ejercicio6_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.ListBox califListBox;
        private System.Windows.Forms.Label calificacionLabel;
        private System.Windows.Forms.Label alumnosLabel;
        private System.Windows.Forms.TextBox salonesTextBox;
        private System.Windows.Forms.Label salonesLabel;
        private System.Windows.Forms.Label menorLabel;
        private System.Windows.Forms.TextBox menorTextBox;
        private System.Windows.Forms.Label mayorLabel;
        private System.Windows.Forms.TextBox mayorTextBox;
        private System.Windows.Forms.Label tituloLabel;
    }
}