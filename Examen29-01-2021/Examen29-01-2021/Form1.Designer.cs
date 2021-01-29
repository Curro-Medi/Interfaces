
namespace Examen29_01_2021
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
            this.alta = new System.Windows.Forms.Button();
            this.alquilar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(509, 322);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(154, 41);
            this.alta.TabIndex = 0;
            this.alta.Text = "Devolver videojuego";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.devolver_Click);
            // 
            // alquilar
            // 
            this.alquilar.Location = new System.Drawing.Point(509, 213);
            this.alquilar.Name = "alquilar";
            this.alquilar.Size = new System.Drawing.Size(154, 41);
            this.alquilar.TabIndex = 1;
            this.alquilar.Text = "Alquilar videojuego";
            this.alquilar.UseVisualStyleBackColor = true;
            this.alquilar.Click += new System.EventHandler(this.alquilar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Alta de cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.alta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.alquilar);
            this.Controls.Add(this.alta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.Button alquilar;
        private System.Windows.Forms.Button button2;
    }
}

