
namespace Refuerzo
{
    partial class Form2
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
            this.Textbo2 = new System.Windows.Forms.TextBox();
            this.Combobo2 = new System.Windows.Forms.ComboBox();
            this.Lista2 = new System.Windows.Forms.ListBox();
            this.btnConmutar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Textbo2
            // 
            this.Textbo2.Location = new System.Drawing.Point(932, 216);
            this.Textbo2.Name = "Textbo2";
            this.Textbo2.Size = new System.Drawing.Size(229, 22);
            this.Textbo2.TabIndex = 10;
            // 
            // Combobo2
            // 
            this.Combobo2.FormattingEnabled = true;
            this.Combobo2.Location = new System.Drawing.Point(18, 214);
            this.Combobo2.Name = "Combobo2";
            this.Combobo2.Size = new System.Drawing.Size(172, 24);
            this.Combobo2.TabIndex = 9;
            // 
            // Lista2
            // 
            this.Lista2.FormattingEnabled = true;
            this.Lista2.ItemHeight = 16;
            this.Lista2.Location = new System.Drawing.Point(303, 31);
            this.Lista2.Name = "Lista2";
            this.Lista2.Size = new System.Drawing.Size(521, 436);
            this.Lista2.TabIndex = 8;
            // 
            // btnConmutar2
            // 
            this.btnConmutar2.Location = new System.Drawing.Point(774, 526);
            this.btnConmutar2.Name = "btnConmutar2";
            this.btnConmutar2.Size = new System.Drawing.Size(96, 38);
            this.btnConmutar2.TabIndex = 7;
            this.btnConmutar2.Text = "Conmutar";
            this.btnConmutar2.UseVisualStyleBackColor = true;
            this.btnConmutar2.Click += new System.EventHandler(this.btnConmutar2_Click_1);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(260, 526);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(96, 38);
            this.btnAgregar2.TabIndex = 6;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(957, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(301, 216);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Ir a formulario 1";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 635);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Textbo2);
            this.Controls.Add(this.Combobo2);
            this.Controls.Add(this.Lista2);
            this.Controls.Add(this.btnConmutar2);
            this.Controls.Add(this.btnAgregar2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbo2;
        private System.Windows.Forms.ComboBox Combobo2;
        private System.Windows.Forms.ListBox Lista2;
        private System.Windows.Forms.Button btnConmutar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnSalir;
    }
}