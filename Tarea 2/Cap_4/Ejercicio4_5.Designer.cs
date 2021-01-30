
namespace Tarea2.Cap_4
{
    partial class Ejercicio4_5
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
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.mayorLabel = new System.Windows.Forms.Label();
            this.menorLabel = new System.Windows.Forms.Label();
            this.edadesLabel = new System.Windows.Forms.Label();
            this.edadRestanteLabel = new System.Windows.Forms.Label();
            this.notaLabel = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.mayorTextBox = new System.Windows.Forms.TextBox();
            this.menorTextBox = new System.Windows.Forms.TextBox();
            this.edadesTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.contadorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(97, 35);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(346, 25);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Calcular el promedio de varias edades";
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidadLabel.Location = new System.Drawing.Point(22, 103);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(145, 20);
            this.cantidadLabel.TabIndex = 1;
            this.cantidadLabel.Text = "Cantidad de edades:";
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promedioLabel.Location = new System.Drawing.Point(90, 154);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(77, 20);
            this.promedioLabel.TabIndex = 2;
            this.promedioLabel.Text = "Promedio:";
            // 
            // mayorLabel
            // 
            this.mayorLabel.AutoSize = true;
            this.mayorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mayorLabel.Location = new System.Drawing.Point(39, 207);
            this.mayorLabel.Name = "mayorLabel";
            this.mayorLabel.Size = new System.Drawing.Size(128, 20);
            this.mayorLabel.TabIndex = 3;
            this.mayorLabel.Text = "Edad más grande:";
            // 
            // menorLabel
            // 
            this.menorLabel.AutoSize = true;
            this.menorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menorLabel.Location = new System.Drawing.Point(50, 259);
            this.menorLabel.Name = "menorLabel";
            this.menorLabel.Size = new System.Drawing.Size(117, 20);
            this.menorLabel.TabIndex = 4;
            this.menorLabel.Text = "Edad más joven:";
            // 
            // edadesLabel
            // 
            this.edadesLabel.AutoSize = true;
            this.edadesLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edadesLabel.Location = new System.Drawing.Point(329, 103);
            this.edadesLabel.Name = "edadesLabel";
            this.edadesLabel.Size = new System.Drawing.Size(60, 20);
            this.edadesLabel.TabIndex = 5;
            this.edadesLabel.Text = "Edades:";
            // 
            // edadRestanteLabel
            // 
            this.edadRestanteLabel.AutoSize = true;
            this.edadRestanteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edadRestanteLabel.ForeColor = System.Drawing.Color.Navy;
            this.edadRestanteLabel.Location = new System.Drawing.Point(563, 107);
            this.edadRestanteLabel.Name = "edadRestanteLabel";
            this.edadRestanteLabel.Size = new System.Drawing.Size(101, 17);
            this.edadRestanteLabel.TabIndex = 6;
            this.edadRestanteLabel.Text = "Falta por añadir";
            // 
            // notaLabel
            // 
            this.notaLabel.AutoSize = true;
            this.notaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notaLabel.Location = new System.Drawing.Point(329, 134);
            this.notaLabel.Name = "notaLabel";
            this.notaLabel.Size = new System.Drawing.Size(382, 15);
            this.notaLabel.TabIndex = 7;
            this.notaLabel.Text = "Nota: Haz click en \"Calcular\" una vez que esté en \"0\" en falta por añadir";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(173, 100);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(123, 23);
            this.cantidadTextBox.TabIndex = 8;
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(173, 151);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.Size = new System.Drawing.Size(123, 23);
            this.promedioTextBox.TabIndex = 9;
            // 
            // mayorTextBox
            // 
            this.mayorTextBox.Location = new System.Drawing.Point(173, 207);
            this.mayorTextBox.Name = "mayorTextBox";
            this.mayorTextBox.Size = new System.Drawing.Size(123, 23);
            this.mayorTextBox.TabIndex = 10;
            // 
            // menorTextBox
            // 
            this.menorTextBox.Location = new System.Drawing.Point(173, 259);
            this.menorTextBox.Name = "menorTextBox";
            this.menorTextBox.Size = new System.Drawing.Size(123, 23);
            this.menorTextBox.TabIndex = 11;
            // 
            // edadesTextBox
            // 
            this.edadesTextBox.Location = new System.Drawing.Point(395, 100);
            this.edadesTextBox.Multiline = true;
            this.edadesTextBox.Name = "edadesTextBox";
            this.edadesTextBox.Size = new System.Drawing.Size(71, 31);
            this.edadesTextBox.TabIndex = 12;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgregarButton.Location = new System.Drawing.Point(482, 100);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 31);
            this.AgregarButton.TabIndex = 13;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcularButton.Location = new System.Drawing.Point(395, 178);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(90, 37);
            this.CalcularButton.TabIndex = 14;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LimpiarButton.Location = new System.Drawing.Point(505, 178);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(90, 37);
            this.LimpiarButton.TabIndex = 15;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // contadorTextBox
            // 
            this.contadorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contadorTextBox.ForeColor = System.Drawing.Color.Navy;
            this.contadorTextBox.Location = new System.Drawing.Point(661, 106);
            this.contadorTextBox.Name = "contadorTextBox";
            this.contadorTextBox.Size = new System.Drawing.Size(21, 23);
            this.contadorTextBox.TabIndex = 16;
            // 
            // Ejercicio4_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 351);
            this.Controls.Add(this.contadorTextBox);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.edadesTextBox);
            this.Controls.Add(this.menorTextBox);
            this.Controls.Add(this.mayorTextBox);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.notaLabel);
            this.Controls.Add(this.edadRestanteLabel);
            this.Controls.Add(this.edadesLabel);
            this.Controls.Add(this.menorLabel);
            this.Controls.Add(this.mayorLabel);
            this.Controls.Add(this.promedioLabel);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Ejercicio4_5";
            this.Text = "Ejercicio4_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.Label mayorLabel;
        private System.Windows.Forms.Label menorLabel;
        private System.Windows.Forms.Label edadesLabel;
        private System.Windows.Forms.Label edadRestanteLabel;
        private System.Windows.Forms.Label notaLabel;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.TextBox mayorTextBox;
        private System.Windows.Forms.TextBox menorTextBox;
        private System.Windows.Forms.TextBox edadesTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.TextBox contadorTextBox;
    }
}