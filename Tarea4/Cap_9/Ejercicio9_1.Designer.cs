
namespace Tarea2.Tarea4.Cap_9
{
    partial class Ejercicio9_1
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
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ResultadoListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(11, 29);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(109, 15);
            this.NombreLabel.TabIndex = 0;
            this.NombreLabel.Text = "Ingresar el nombre:";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(12, 135);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(128, 15);
            this.DescripcionLabel.TabIndex = 1;
            this.DescripcionLabel.Text = "Ingresar la descripción:";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(12, 86);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(100, 15);
            this.PrecioLabel.TabIndex = 2;
            this.PrecioLabel.Text = "Ingresar el precio:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(12, 47);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(165, 23);
            this.NombreTextBox.TabIndex = 3;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(12, 153);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(241, 101);
            this.DescripcionTextBox.TabIndex = 4;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(12, 104);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(241, 23);
            this.PrecioTextBox.TabIndex = 5;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(178, 261);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 6;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(183, 47);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(70, 23);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.Text = "Mostrar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(12, 260);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ResultadoListBox
            // 
            this.ResultadoListBox.FormattingEnabled = true;
            this.ResultadoListBox.ItemHeight = 15;
            this.ResultadoListBox.Location = new System.Drawing.Point(275, 39);
            this.ResultadoListBox.Name = "ResultadoListBox";
            this.ResultadoListBox.Size = new System.Drawing.Size(432, 244);
            this.ResultadoListBox.TabIndex = 10;
            // 
            // Ejercicio9_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 296);
            this.Controls.Add(this.ResultadoListBox);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Name = "Ejercicio9_1";
            this.Text = "Ejercicio9_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ListBox ResultadoListBox;
    }
}