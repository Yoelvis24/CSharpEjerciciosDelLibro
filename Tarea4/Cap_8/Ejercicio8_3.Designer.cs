
namespace Tarea2.Tarea4.Cap_8
{
    partial class Ejercicio8_3
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
            this.HoraLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.HoraListBox = new System.Windows.Forms.ListBox();
            this.FechaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HoraLabel.Location = new System.Drawing.Point(18, 28);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(94, 20);
            this.HoraLabel.TabIndex = 0;
            this.HoraLabel.Text = "Hora Actual:";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FechaLabel.Location = new System.Drawing.Point(12, 70);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(100, 20);
            this.FechaLabel.TabIndex = 1;
            this.FechaLabel.Text = "Fecha Actual:";
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(177, 108);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(81, 27);
            this.MostrarButton.TabIndex = 4;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // HoraListBox
            // 
            this.HoraListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraListBox.FormattingEnabled = true;
            this.HoraListBox.ItemHeight = 25;
            this.HoraListBox.Location = new System.Drawing.Point(134, 28);
            this.HoraListBox.Name = "HoraListBox";
            this.HoraListBox.Size = new System.Drawing.Size(124, 29);
            this.HoraListBox.TabIndex = 5;
            // 
            // FechaListBox
            // 
            this.FechaListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FechaListBox.FormattingEnabled = true;
            this.FechaListBox.ItemHeight = 25;
            this.FechaListBox.Location = new System.Drawing.Point(134, 63);
            this.FechaListBox.Name = "FechaListBox";
            this.FechaListBox.Size = new System.Drawing.Size(124, 29);
            this.FechaListBox.TabIndex = 6;
            // 
            // Ejercicio8_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 147);
            this.Controls.Add(this.FechaListBox);
            this.Controls.Add(this.HoraListBox);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.HoraLabel);
            this.Name = "Ejercicio8_3";
            this.Text = "Ejercicio8_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.ListBox HoraListBox;
        private System.Windows.Forms.ListBox FechaListBox;
    }
}