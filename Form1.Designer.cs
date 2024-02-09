namespace Figuras
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
            this.buttonF2 = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonF2
            // 
            this.buttonF2.BackColor = System.Drawing.SystemColors.Info;
            this.buttonF2.Location = new System.Drawing.Point(269, 55);
            this.buttonF2.Name = "buttonF2";
            this.buttonF2.Size = new System.Drawing.Size(166, 39);
            this.buttonF2.TabIndex = 0;
            this.buttonF2.Text = "Figura2D";
            this.buttonF2.UseVisualStyleBackColor = false;
            this.buttonF2.Click += new System.EventHandler(this.buttonF2_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(626, 383);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(113, 42);
            this.buttonS.TabIndex = 1;
            this.buttonS.Text = "Next";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonF2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonF2;
        private System.Windows.Forms.Button buttonS;
    }
}

