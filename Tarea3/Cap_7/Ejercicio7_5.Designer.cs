
namespace Tarea2.Cap_7
{
    partial class Ejercicio7_5
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.buscarLabel = new System.Windows.Forms.Label();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel.Location = new System.Drawing.Point(125, 36);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(69, 21);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Agenda";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(77, 86);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(54, 15);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(79, 130);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 15);
            this.telefonoLabel.TabIndex = 2;
            this.telefonoLabel.Text = "Teléfono";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(137, 83);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.nombreTextBox.TabIndex = 3;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(137, 127);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 23);
            this.telefonoTextBox.TabIndex = 4;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(162, 173);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(434, 173);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 6;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Location = new System.Drawing.Point(301, 34);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(42, 15);
            this.buscarLabel.TabIndex = 7;
            this.buscarLabel.Text = "Buscar";
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(349, 31);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(79, 23);
            this.buscarTextBox.TabIndex = 8;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(434, 31);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 9;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(349, 74);
            this.resultadoTextBox.Multiline = true;
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.Size = new System.Drawing.Size(160, 93);
            this.resultadoTextBox.TabIndex = 10;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(349, 173);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // Ejercicio7_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 227);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.buscarTextBox);
            this.Controls.Add(this.buscarLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Ejercicio7_5";
            this.Text = "Ejercicio7_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.Button LimpiarButton;
    }
}