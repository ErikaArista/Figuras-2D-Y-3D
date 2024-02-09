namespace Figuras
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
            this.buttonF3 = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonFn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonF3
            // 
            this.buttonF3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonF3.Location = new System.Drawing.Point(313, 12);
            this.buttonF3.Name = "buttonF3";
            this.buttonF3.Size = new System.Drawing.Size(141, 40);
            this.buttonF3.TabIndex = 0;
            this.buttonF3.Text = "Figurra3D";
            this.buttonF3.UseVisualStyleBackColor = false;
            this.buttonF3.Click += new System.EventHandler(this.buttonF3_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(683, 389);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(81, 37);
            this.buttonR.TabIndex = 1;
            this.buttonR.Text = "Rgresar";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonFn
            // 
            this.buttonFn.Location = new System.Drawing.Point(30, 389);
            this.buttonFn.Name = "buttonFn";
            this.buttonFn.Size = new System.Drawing.Size(65, 37);
            this.buttonFn.TabIndex = 2;
            this.buttonFn.Text = "Finalizar";
            this.buttonFn.UseVisualStyleBackColor = true;
            this.buttonFn.Click += new System.EventHandler(this.buttonFn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFn);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonF3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonF3;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonFn;
    }
}