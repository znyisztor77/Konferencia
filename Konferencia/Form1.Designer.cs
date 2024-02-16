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
            this.buttonBalraranyil = new System.Windows.Forms.Button();
            this.panelErtekeles = new System.Windows.Forms.Panel();
            this.pictureBoxKolto = new System.Windows.Forms.PictureBox();
            this.buttonJobbranyil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBalraranyil
            // 
            this.buttonBalraranyil.BackgroundImage = global::Konferencia.Properties.Resources.bal;
            this.buttonBalraranyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBalraranyil.Location = new System.Drawing.Point(12, 77);
            this.buttonBalraranyil.Name = "buttonBalraranyil";
            this.buttonBalraranyil.Size = new System.Drawing.Size(81, 57);
            this.buttonBalraranyil.TabIndex = 0;
            this.buttonBalraranyil.UseVisualStyleBackColor = true;
            this.buttonBalraranyil.Click += new System.EventHandler(this.buttonBalraranyil_Click);
            // 
            // panelErtekeles
            // 
            this.panelErtekeles.Location = new System.Drawing.Point(459, 12);
            this.panelErtekeles.Name = "panelErtekeles";
            this.panelErtekeles.Size = new System.Drawing.Size(494, 346);
            this.panelErtekeles.TabIndex = 2;
            // 
            // pictureBoxKolto
            // 
            this.pictureBoxKolto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKolto.Location = new System.Drawing.Point(99, 12);
            this.pictureBoxKolto.Name = "pictureBoxKolto";
            this.pictureBoxKolto.Size = new System.Drawing.Size(257, 346);
            this.pictureBoxKolto.TabIndex = 3;
            this.pictureBoxKolto.TabStop = false;
            // 
            // buttonJobbranyil
            // 
            this.buttonJobbranyil.BackgroundImage = global::Konferencia.Properties.Resources.jobb;
            this.buttonJobbranyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJobbranyil.Location = new System.Drawing.Point(362, 77);
            this.buttonJobbranyil.Name = "buttonJobbranyil";
            this.buttonJobbranyil.Size = new System.Drawing.Size(75, 57);
            this.buttonJobbranyil.TabIndex = 1;
            this.buttonJobbranyil.UseVisualStyleBackColor = true;
            this.buttonJobbranyil.Click += new System.EventHandler(this.buttonJobbranyil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.pictureBoxKolto);
            this.Controls.Add(this.panelErtekeles);
            this.Controls.Add(this.buttonJobbranyil);
            this.Controls.Add(this.buttonBalraranyil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBalraranyil;
        private System.Windows.Forms.Button buttonJobbranyil;
        private System.Windows.Forms.Panel panelErtekeles;
        private System.Windows.Forms.PictureBox pictureBoxKolto;
    }
}

