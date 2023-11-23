namespace MySubtitles
{
    partial class ChyboveHlasenie
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
            this.ChyboveHlaseniePicture = new System.Windows.Forms.PictureBox();
            this.lbltextChyboveHlasenie = new System.Windows.Forms.Label();
            this.btnOK = new MySubtitles.Custom_Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChyboveHlaseniePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ChyboveHlaseniePicture
            // 
            this.ChyboveHlaseniePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChyboveHlaseniePicture.Image = global::MySubtitles.Properties.Resources.warning;
            this.ChyboveHlaseniePicture.Location = new System.Drawing.Point(49, 46);
            this.ChyboveHlaseniePicture.Name = "ChyboveHlaseniePicture";
            this.ChyboveHlaseniePicture.Size = new System.Drawing.Size(81, 68);
            this.ChyboveHlaseniePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ChyboveHlaseniePicture.TabIndex = 3;
            this.ChyboveHlaseniePicture.TabStop = false;
            // 
            // lbltextChyboveHlasenie
            // 
            this.lbltextChyboveHlasenie.AutoSize = true;
            this.lbltextChyboveHlasenie.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbltextChyboveHlasenie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lbltextChyboveHlasenie.Location = new System.Drawing.Point(167, 71);
            this.lbltextChyboveHlasenie.Name = "lbltextChyboveHlasenie";
            this.lbltextChyboveHlasenie.Size = new System.Drawing.Size(265, 17);
            this.lbltextChyboveHlasenie.TabIndex = 6;
            this.lbltextChyboveHlasenie.Text = "Premenovanie titulkov prebehlo úspešne.";
            this.lbltextChyboveHlasenie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnOK.Location = new System.Drawing.Point(213, 119);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 40;
            this.btnOK.Size = new System.Drawing.Size(102, 40);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChyboveHlasenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(521, 171);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbltextChyboveHlasenie);
            this.Controls.Add(this.ChyboveHlaseniePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChyboveHlasenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChyboveHlasenie";
            this.Load += new System.EventHandler(this.ChyboveHlasenie_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChyboveHlasenie_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ChyboveHlaseniePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ChyboveHlaseniePicture;
        private System.Windows.Forms.Label lbltextChyboveHlasenie;
        private Custom_Button btnOK;
    }
}