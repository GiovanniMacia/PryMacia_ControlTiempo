namespace PryMacia_ControlTiempo
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
            this.btnTrabajo = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrabajo
            // 
            this.btnTrabajo.Location = new System.Drawing.Point(73, 63);
            this.btnTrabajo.Name = "btnTrabajo";
            this.btnTrabajo.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajo.TabIndex = 0;
            this.btnTrabajo.Text = "Trabajo";
            this.btnTrabajo.UseVisualStyleBackColor = true;
            this.btnTrabajo.Click += new System.EventHandler(this.btnTrabajo_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(70, 133);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(10, 13);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = ".";
            this.lblTiempo.Click += new System.EventHandler(this.lblTiempo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 178);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnTrabajo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrabajo;
        private System.Windows.Forms.Label lblTiempo;
    }
}

