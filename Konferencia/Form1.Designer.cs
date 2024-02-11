namespace Konferencia
{
    partial class Form1
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
            this.buttonJobbranyil = new System.Windows.Forms.Button();
            this.buttonBalranyil = new System.Windows.Forms.Button();
            this.panelErtekeles = new System.Windows.Forms.Panel();
            this.pictureBoxKolto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJobbranyil
            // 
            this.buttonJobbranyil.Location = new System.Drawing.Point(12, 77);
            this.buttonJobbranyil.Name = "buttonJobbranyil";
            this.buttonJobbranyil.Size = new System.Drawing.Size(75, 23);
            this.buttonJobbranyil.TabIndex = 0;
            this.buttonJobbranyil.Text = "button1";
            this.buttonJobbranyil.UseVisualStyleBackColor = true;
            // 
            // buttonBalranyil
            // 
            this.buttonBalranyil.Location = new System.Drawing.Point(282, 77);
            this.buttonBalranyil.Name = "buttonBalranyil";
            this.buttonBalranyil.Size = new System.Drawing.Size(75, 23);
            this.buttonBalranyil.TabIndex = 1;
            this.buttonBalranyil.Text = "button2";
            this.buttonBalranyil.UseVisualStyleBackColor = true;
            // 
            // panelErtekeles
            // 
            this.panelErtekeles.Location = new System.Drawing.Point(459, 12);
            this.panelErtekeles.Name = "panelErtekeles";
            this.panelErtekeles.Size = new System.Drawing.Size(584, 272);
            this.panelErtekeles.TabIndex = 2;
            // 
            // pictureBoxKolto
            // 
            this.pictureBoxKolto.Location = new System.Drawing.Point(99, 12);
            this.pictureBoxKolto.Name = "pictureBoxKolto";
            this.pictureBoxKolto.Size = new System.Drawing.Size(168, 157);
            this.pictureBoxKolto.TabIndex = 3;
            this.pictureBoxKolto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.pictureBoxKolto);
            this.Controls.Add(this.panelErtekeles);
            this.Controls.Add(this.buttonBalranyil);
            this.Controls.Add(this.buttonJobbranyil);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonJobbranyil;
        private System.Windows.Forms.Button buttonBalranyil;
        private System.Windows.Forms.Panel panelErtekeles;
        private System.Windows.Forms.PictureBox pictureBoxKolto;
    }
}

