
namespace Tarea2.Cap_6
{
    partial class Ejercicio6_1
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
            this.salonesTextBox = new System.Windows.Forms.TextBox();
            this.alumnosLabel = new System.Windows.Forms.Label();
            this.calificacionLabel = new System.Windows.Forms.Label();
            this.califListBox = new System.Windows.Forms.ListBox();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.AñadirButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salonesLabel
            // 
            this.salonesLabel.AutoSize = true;
            this.salonesLabel.Location = new System.Drawing.Point(37, 74);
            this.salonesLabel.Name = "salonesLabel";
            this.salonesLabel.Size = new System.Drawing.Size(116, 15);
            this.salonesLabel.TabIndex = 0;
            this.salonesLabel.Text = "Cantidad de salones:";
            // 
            // salonesTextBox
            // 
            this.salonesTextBox.Location = new System.Drawing.Point(159, 71);
            this.salonesTextBox.Name = "salonesTextBox";
            this.salonesTextBox.Size = new System.Drawing.Size(100, 23);
            this.salonesTextBox.TabIndex = 1;
            // 
            // alumnosLabel
            // 
            this.alumnosLabel.AutoSize = true;
            this.alumnosLabel.Location = new System.Drawing.Point(265, 74);
            this.alumnosLabel.Name = "alumnosLabel";
            this.alumnosLabel.Size = new System.Drawing.Size(175, 15);
            this.alumnosLabel.TabIndex = 2;
            this.alumnosLabel.Text = "Cantidad de alumnos por salón:";
            // 
            // calificacionLabel
            // 
            this.calificacionLabel.AutoSize = true;
            this.calificacionLabel.Location = new System.Drawing.Point(81, 117);
            this.calificacionLabel.Name = "calificacionLabel";
            this.calificacionLabel.Size = new System.Drawing.Size(72, 15);
            this.calificacionLabel.TabIndex = 7;
            this.calificacionLabel.Text = "Calificación:";
            // 
            // califListBox
            // 
            this.califListBox.FormattingEnabled = true;
            this.califListBox.ItemHeight = 15;
            this.califListBox.Location = new System.Drawing.Point(81, 156);
            this.califListBox.Name = "califListBox";
            this.califListBox.Size = new System.Drawing.Size(332, 169);
            this.califListBox.TabIndex = 11;
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promedioLabel.Location = new System.Drawing.Point(265, 112);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(77, 20);
            this.promedioLabel.TabIndex = 12;
            this.promedioLabel.Text = "Promedio:";
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(340, 113);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.Size = new System.Drawing.Size(73, 23);
            this.promedioTextBox.TabIndex = 15;
            // 
            // AñadirButton
            // 
            this.AñadirButton.Location = new System.Drawing.Point(446, 71);
            this.AñadirButton.Name = "AñadirButton";
            this.AñadirButton.Size = new System.Drawing.Size(75, 23);
            this.AñadirButton.TabIndex = 16;
            this.AñadirButton.Text = "Añadir";
            this.AñadirButton.UseVisualStyleBackColor = true;
            this.AñadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(159, 113);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 17;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(105, 21);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(308, 17);
            this.tituloLabel.TabIndex = 18;
            this.tituloLabel.Text = "Promedio de calificaciones usando arreglo jadded";
            // 
            // Ejercicio6_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 362);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.AñadirButton);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.promedioLabel);
            this.Controls.Add(this.califListBox);
            this.Controls.Add(this.calificacionLabel);
            this.Controls.Add(this.alumnosLabel);
            this.Controls.Add(this.salonesTextBox);
            this.Controls.Add(this.salonesLabel);
            this.Name = "Ejercicio6_1";
            this.Text = "Ejercicio6_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salonesLabel;
        private System.Windows.Forms.TextBox salonesTextBox;
        private System.Windows.Forms.Label alumnosLabel;
        private System.Windows.Forms.Label calificacionLabel;
        private System.Windows.Forms.ListBox califListBox;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.Button AñadirButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label tituloLabel;
    }
}