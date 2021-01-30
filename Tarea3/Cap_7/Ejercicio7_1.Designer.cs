
namespace Tarea2.Cap_7
{
    partial class Ejercicio7_1
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
            this.calificacionesLabel = new System.Windows.Forms.Label();
            this.promedioLabel = new System.Windows.Forms.Label();
            this.maximaLabel = new System.Windows.Forms.Label();
            this.minimaLabel = new System.Windows.Forms.Label();
            this.califTextBox = new System.Windows.Forms.TextBox();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.maximaTextBox = new System.Windows.Forms.TextBox();
            this.minimaTextBox = new System.Windows.Forms.TextBox();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(56, 24);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(540, 17);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Calcular promedio, calificación máxima y mínima de un salón de clases usando Arra" +
    "yList";
            // 
            // calificacionesLabel
            // 
            this.calificacionesLabel.AutoSize = true;
            this.calificacionesLabel.Location = new System.Drawing.Point(184, 99);
            this.calificacionesLabel.Name = "calificacionesLabel";
            this.calificacionesLabel.Size = new System.Drawing.Size(83, 15);
            this.calificacionesLabel.TabIndex = 2;
            this.calificacionesLabel.Text = "Calificaciones:";
            // 
            // promedioLabel
            // 
            this.promedioLabel.AutoSize = true;
            this.promedioLabel.Location = new System.Drawing.Point(240, 183);
            this.promedioLabel.Name = "promedioLabel";
            this.promedioLabel.Size = new System.Drawing.Size(62, 15);
            this.promedioLabel.TabIndex = 3;
            this.promedioLabel.Text = "Promedio:";
            // 
            // maximaLabel
            // 
            this.maximaLabel.AutoSize = true;
            this.maximaLabel.Location = new System.Drawing.Point(184, 221);
            this.maximaLabel.Name = "maximaLabel";
            this.maximaLabel.Size = new System.Drawing.Size(118, 15);
            this.maximaLabel.TabIndex = 4;
            this.maximaLabel.Text = "Calificación máxima:";
            // 
            // minimaLabel
            // 
            this.minimaLabel.AutoSize = true;
            this.minimaLabel.Location = new System.Drawing.Point(184, 255);
            this.minimaLabel.Name = "minimaLabel";
            this.minimaLabel.Size = new System.Drawing.Size(116, 15);
            this.minimaLabel.TabIndex = 5;
            this.minimaLabel.Text = "Calificación mínima:";
            // 
            // califTextBox
            // 
            this.califTextBox.Location = new System.Drawing.Point(271, 95);
            this.califTextBox.Name = "califTextBox";
            this.califTextBox.Size = new System.Drawing.Size(100, 23);
            this.califTextBox.TabIndex = 7;
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(308, 180);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.Size = new System.Drawing.Size(100, 23);
            this.promedioTextBox.TabIndex = 8;
            // 
            // maximaTextBox
            // 
            this.maximaTextBox.Location = new System.Drawing.Point(308, 218);
            this.maximaTextBox.Name = "maximaTextBox";
            this.maximaTextBox.Size = new System.Drawing.Size(100, 23);
            this.maximaTextBox.TabIndex = 9;
            // 
            // minimaTextBox
            // 
            this.minimaTextBox.Location = new System.Drawing.Point(308, 252);
            this.minimaTextBox.Name = "minimaTextBox";
            this.minimaTextBox.Size = new System.Drawing.Size(100, 23);
            this.minimaTextBox.TabIndex = 10;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultadoLabel.Location = new System.Drawing.Point(320, 143);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(74, 17);
            this.resultadoLabel.TabIndex = 11;
            this.resultadoLabel.Text = "Resultados";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(381, 95);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(308, 290);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(100, 36);
            this.CalcularButton.TabIndex = 13;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Ejercicio7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 358);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.minimaTextBox);
            this.Controls.Add(this.maximaTextBox);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.califTextBox);
            this.Controls.Add(this.minimaLabel);
            this.Controls.Add(this.maximaLabel);
            this.Controls.Add(this.promedioLabel);
            this.Controls.Add(this.calificacionesLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Ejercicio7_1";
            this.Text = "Ejercicio7_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label calificacionesLabel;
        private System.Windows.Forms.Label promedioLabel;
        private System.Windows.Forms.Label maximaLabel;
        private System.Windows.Forms.Label minimaLabel;
        private System.Windows.Forms.TextBox califTextBox;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.TextBox maximaTextBox;
        private System.Windows.Forms.TextBox minimaTextBox;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button CalcularButton;
    }
}