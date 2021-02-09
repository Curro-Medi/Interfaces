
namespace Refuerzo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConmutar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.Combobo = new System.Windows.Forms.ComboBox();
            this.Textbo = new System.Windows.Forms.TextBox();
            this.btnF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(334, 570);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConmutar
            // 
            this.btnConmutar.Location = new System.Drawing.Point(848, 570);
            this.btnConmutar.Name = "btnConmutar";
            this.btnConmutar.Size = new System.Drawing.Size(96, 38);
            this.btnConmutar.TabIndex = 1;
            this.btnConmutar.Text = "Conmutar";
            this.btnConmutar.UseVisualStyleBackColor = true;
            this.btnConmutar.Click += new System.EventHandler(this.btnConmutar_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 16;
            this.Lista.Location = new System.Drawing.Point(377, 75);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(521, 436);
            this.Lista.TabIndex = 2;
            // 
            // Combobo
            // 
            this.Combobo.FormattingEnabled = true;
            this.Combobo.Location = new System.Drawing.Point(92, 258);
            this.Combobo.Name = "Combobo";
            this.Combobo.Size = new System.Drawing.Size(172, 24);
            this.Combobo.TabIndex = 3;
            // 
            // Textbo
            // 
            this.Textbo.Location = new System.Drawing.Point(1006, 260);
            this.Textbo.Name = "Textbo";
            this.Textbo.Size = new System.Drawing.Size(229, 22);
            this.Textbo.TabIndex = 4;
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(1086, 434);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(241, 214);
            this.btnF2.TabIndex = 5;
            this.btnF2.Text = "Segundo Formulario";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 660);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.Textbo);
            this.Controls.Add(this.Combobo);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.btnConmutar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConmutar;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.ComboBox Combobo;
        private System.Windows.Forms.TextBox Textbo;
        private System.Windows.Forms.Button btnF2;
    }
}

