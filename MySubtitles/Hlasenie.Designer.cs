namespace MySubtitles
{
    partial class Hlasenie
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
            this.hlaseniePicture = new System.Windows.Forms.PictureBox();
            this.btnOK = new MySubtitles.Custom_Button();
            this.lbltextHlasenie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hlaseniePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // hlaseniePicture
            // 
            this.hlaseniePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hlaseniePicture.Image = global::MySubtitles.Properties.Resources.check_blue;
            this.hlaseniePicture.Location = new System.Drawing.Point(60, 45);
            this.hlaseniePicture.Name = "hlaseniePicture";
            this.hlaseniePicture.Size = new System.Drawing.Size(81, 68);
            this.hlaseniePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hlaseniePicture.TabIndex = 2;
            this.hlaseniePicture.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnOK.Location = new System.Drawing.Point(216, 109);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 40;
            this.btnOK.Size = new System.Drawing.Size(102, 40);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbltextHlasenie
            // 
            this.lbltextHlasenie.AutoSize = true;
            this.lbltextHlasenie.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbltextHlasenie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lbltextHlasenie.Location = new System.Drawing.Point(173, 67);
            this.lbltextHlasenie.Name = "lbltextHlasenie";
            this.lbltextHlasenie.Size = new System.Drawing.Size(265, 17);
            this.lbltextHlasenie.TabIndex = 5;
            this.lbltextHlasenie.Text = "Premenovanie titulkov prebehlo úspešne.";
            this.lbltextHlasenie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hlasenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(521, 171);
            this.Controls.Add(this.lbltextHlasenie);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.hlaseniePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hlasenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hlasenie";
            this.Load += new System.EventHandler(this.Hlasenie_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Hlasenie_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.hlaseniePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hlaseniePicture;
        private Custom_Button btnOK;
        private System.Windows.Forms.Label lbltextHlasenie;
    }
}