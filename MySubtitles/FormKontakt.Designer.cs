namespace MySubtitles
{
    partial class FormKontakt
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
            this.lblKontakt = new System.Windows.Forms.Label();
            this.txtPopis = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.picBoxSupport = new System.Windows.Forms.PictureBox();
            this.picBoxInstagram = new System.Windows.Forms.PictureBox();
            this.picBoxFacebook = new System.Windows.Forms.PictureBox();
            this.picBoxEmail = new System.Windows.Forms.PictureBox();
            this.panel_Email2 = new MySubtitles.Panel_Email();
            this.panel_Email1 = new MySubtitles.Panel_Email();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKontakt
            // 
            this.lblKontakt.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontakt.ForeColor = System.Drawing.Color.White;
            this.lblKontakt.Location = new System.Drawing.Point(59, 40);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(207, 48);
            this.lblKontakt.TabIndex = 0;
            this.lblKontakt.Text = "Kontaktujte nás";
            // 
            // txtPopis
            // 
            this.txtPopis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPopis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPopis.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPopis.ForeColor = System.Drawing.Color.White;
            this.txtPopis.Location = new System.Drawing.Point(64, 106);
            this.txtPopis.Multiline = true;
            this.txtPopis.Name = "txtPopis";
            this.txtPopis.Size = new System.Drawing.Size(264, 107);
            this.txtPopis.TabIndex = 1;
            this.txtPopis.Text = "Ak máte nejaké otázky alebo v prípade, že sa vyskytne nejaký problém, tak nás nev" +
    "áhajte kontaktovať. Náš tím sa vám pokúsi čo najskôr odpovedať, najneskôr do dvo" +
    "ch pracovných dní.";
            this.txtPopis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblEmail.Location = new System.Drawing.Point(128, 293);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 22);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "mojetitulky@gmail.com";
            // 
            // lblFacebook
            // 
            this.lblFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblFacebook.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblFacebook.Location = new System.Drawing.Point(128, 357);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(101, 25);
            this.lblFacebook.TabIndex = 13;
            this.lblFacebook.Text = "Moje Titulky";
            // 
            // lblInstagram
            // 
            this.lblInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblInstagram.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblInstagram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblInstagram.Location = new System.Drawing.Point(128, 423);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(101, 25);
            this.lblInstagram.TabIndex = 15;
            this.lblInstagram.Text = "@moje.titulky";
            // 
            // picBoxSupport
            // 
            this.picBoxSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picBoxSupport.Image = global::MySubtitles.Properties.Resources.support;
            this.picBoxSupport.Location = new System.Drawing.Point(377, 66);
            this.picBoxSupport.Name = "picBoxSupport";
            this.picBoxSupport.Size = new System.Drawing.Size(360, 400);
            this.picBoxSupport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSupport.TabIndex = 17;
            this.picBoxSupport.TabStop = false;
            // 
            // picBoxInstagram
            // 
            this.picBoxInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.picBoxInstagram.Image = global::MySubtitles.Properties.Resources.instagram_blue;
            this.picBoxInstagram.Location = new System.Drawing.Point(73, 416);
            this.picBoxInstagram.Name = "picBoxInstagram";
            this.picBoxInstagram.Size = new System.Drawing.Size(43, 32);
            this.picBoxInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxInstagram.TabIndex = 14;
            this.picBoxInstagram.TabStop = false;
            // 
            // picBoxFacebook
            // 
            this.picBoxFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.picBoxFacebook.Image = global::MySubtitles.Properties.Resources.facebook_blue;
            this.picBoxFacebook.Location = new System.Drawing.Point(73, 350);
            this.picBoxFacebook.Name = "picBoxFacebook";
            this.picBoxFacebook.Size = new System.Drawing.Size(43, 32);
            this.picBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxFacebook.TabIndex = 12;
            this.picBoxFacebook.TabStop = false;
            // 
            // picBoxEmail
            // 
            this.picBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.picBoxEmail.Image = global::MySubtitles.Properties.Resources.email_blue;
            this.picBoxEmail.Location = new System.Drawing.Point(73, 287);
            this.picBoxEmail.Name = "picBoxEmail";
            this.picBoxEmail.Size = new System.Drawing.Size(43, 32);
            this.picBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxEmail.TabIndex = 10;
            this.picBoxEmail.TabStop = false;
            // 
            // panel_Email2
            // 
            this.panel_Email2.Location = new System.Drawing.Point(362, 40);
            this.panel_Email2.Name = "panel_Email2";
            this.panel_Email2.Pozadie_Zelena1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_Email2.Pozadie1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_Email2.Size = new System.Drawing.Size(391, 448);
            this.panel_Email2.TabIndex = 16;
            this.panel_Email2.Text = "panel_Email2";
            this.panel_Email2.UseVisualStyleBackColor = true;
            // 
            // panel_Email1
            // 
            this.panel_Email1.Location = new System.Drawing.Point(53, 253);
            this.panel_Email1.Name = "panel_Email1";
            this.panel_Email1.Pozadie_Zelena1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.panel_Email1.Pozadie1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.panel_Email1.Size = new System.Drawing.Size(275, 235);
            this.panel_Email1.TabIndex = 9;
            this.panel_Email1.Text = "panel_Email1";
            this.panel_Email1.UseVisualStyleBackColor = true;
            // 
            // FormKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(799, 552);
            this.Controls.Add(this.picBoxSupport);
            this.Controls.Add(this.panel_Email2);
            this.Controls.Add(this.lblInstagram);
            this.Controls.Add(this.picBoxInstagram);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.picBoxFacebook);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picBoxEmail);
            this.Controls.Add(this.panel_Email1);
            this.Controls.Add(this.txtPopis);
            this.Controls.Add(this.lblKontakt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKontakt";
            this.Text = "FormKontakt";
            this.Load += new System.EventHandler(this.FormKontakt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.TextBox txtPopis;
        private Panel_Email panel_Email1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picBoxEmail;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.PictureBox picBoxFacebook;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.PictureBox picBoxInstagram;
        private Panel_Email panel_Email2;
        private System.Windows.Forms.PictureBox picBoxSupport;
    }
}