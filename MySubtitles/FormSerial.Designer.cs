namespace MySubtitles
{
    partial class FormSerial
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
            this.panel_Serial = new MySubtitles.Panel_Email();
            this.txtSE = new System.Windows.Forms.TextBox();
            this.lblSE = new System.Windows.Forms.Label();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.txtNazov = new System.Windows.Forms.TextBox();
            this.lblDestPath = new System.Windows.Forms.Label();
            this.lblNazovSerial = new System.Windows.Forms.Label();
            this.btnStiahnut = new MySubtitles.Custom_Button();
            this.btnPremenovat = new MySubtitles.Custom_Button();
            this.btnPrehladavat = new MySubtitles.Custom_Button();
            this.SuspendLayout();
            // 
            // panel_Serial
            // 
            this.panel_Serial.Location = new System.Drawing.Point(26, 127);
            this.panel_Serial.Name = "panel_Serial";
            this.panel_Serial.Pozadie_Zelena1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.panel_Serial.Pozadie1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.panel_Serial.Size = new System.Drawing.Size(746, 259);
            this.panel_Serial.TabIndex = 14;
            this.panel_Serial.Tag = "60; 150; 138";
            this.panel_Serial.Text = "panel_Email2";
            this.panel_Serial.UseVisualStyleBackColor = true;
            this.panel_Serial.CheckedChanged += new System.EventHandler(this.panel_Serial_CheckedChanged);
            // 
            // txtSE
            // 
            this.txtSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtSE.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtSE.Location = new System.Drawing.Point(190, 210);
            this.txtSE.Name = "txtSE";
            this.txtSE.Size = new System.Drawing.Size(474, 25);
            this.txtSE.TabIndex = 23;
            this.txtSE.TextChanged += new System.EventHandler(this.txtSE_TextChanged);
            // 
            // lblSE
            // 
            this.lblSE.AutoSize = true;
            this.lblSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblSE.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblSE.Location = new System.Drawing.Point(45, 213);
            this.lblSE.Name = "lblSE";
            this.lblSE.Size = new System.Drawing.Size(122, 17);
            this.lblSE.TabIndex = 22;
            this.lblSE.Text = "Sezóna a epizóda :";
            // 
            // txtDP
            // 
            this.txtDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtDP.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtDP.Location = new System.Drawing.Point(190, 256);
            this.txtDP.Name = "txtDP";
            this.txtDP.ReadOnly = true;
            this.txtDP.Size = new System.Drawing.Size(474, 25);
            this.txtDP.TabIndex = 18;
            this.txtDP.TextChanged += new System.EventHandler(this.txtDP_TextChanged);
            // 
            // txtNazov
            // 
            this.txtNazov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtNazov.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNazov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtNazov.Location = new System.Drawing.Point(190, 160);
            this.txtNazov.Name = "txtNazov";
            this.txtNazov.Size = new System.Drawing.Size(474, 25);
            this.txtNazov.TabIndex = 17;
            this.txtNazov.TextChanged += new System.EventHandler(this.txtNazov_TextChanged);
            // 
            // lblDestPath
            // 
            this.lblDestPath.AutoSize = true;
            this.lblDestPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblDestPath.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDestPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblDestPath.Location = new System.Drawing.Point(42, 259);
            this.lblDestPath.Name = "lblDestPath";
            this.lblDestPath.Size = new System.Drawing.Size(125, 17);
            this.lblDestPath.TabIndex = 16;
            this.lblDestPath.Text = "Cieľový priečinok :";
            // 
            // lblNazovSerial
            // 
            this.lblNazovSerial.AutoSize = true;
            this.lblNazovSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblNazovSerial.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNazovSerial.Location = new System.Drawing.Point(67, 163);
            this.lblNazovSerial.Name = "lblNazovSerial";
            this.lblNazovSerial.Size = new System.Drawing.Size(100, 17);
            this.lblNazovSerial.TabIndex = 15;
            this.lblNazovSerial.Text = "Názov Seriálu :";
            // 
            // btnStiahnut
            // 
            this.btnStiahnut.BackColor = System.Drawing.Color.White;
            this.btnStiahnut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStiahnut.Enabled = false;
            this.btnStiahnut.FlatAppearance.BorderSize = 0;
            this.btnStiahnut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStiahnut.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStiahnut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnStiahnut.Image = global::MySubtitles.Properties.Resources.download_blue;
            this.btnStiahnut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStiahnut.Location = new System.Drawing.Point(190, 304);
            this.btnStiahnut.Name = "btnStiahnut";
            this.btnStiahnut.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStiahnut.Radius = 40;
            this.btnStiahnut.Size = new System.Drawing.Size(118, 52);
            this.btnStiahnut.TabIndex = 24;
            this.btnStiahnut.Text = "Stiahnúť";
            this.btnStiahnut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStiahnut.UseVisualStyleBackColor = false;
            this.btnStiahnut.Click += new System.EventHandler(this.btnStiahnut_Click);
            // 
            // btnPremenovat
            // 
            this.btnPremenovat.BackColor = System.Drawing.Color.White;
            this.btnPremenovat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPremenovat.Enabled = false;
            this.btnPremenovat.FlatAppearance.BorderSize = 0;
            this.btnPremenovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremenovat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPremenovat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnPremenovat.Image = global::MySubtitles.Properties.Resources.Premenovanie_blue2;
            this.btnPremenovat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPremenovat.Location = new System.Drawing.Point(523, 304);
            this.btnPremenovat.Name = "btnPremenovat";
            this.btnPremenovat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPremenovat.Radius = 40;
            this.btnPremenovat.Size = new System.Drawing.Size(141, 52);
            this.btnPremenovat.TabIndex = 25;
            this.btnPremenovat.Text = "Premenovať";
            this.btnPremenovat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPremenovat.UseVisualStyleBackColor = false;
            this.btnPremenovat.Click += new System.EventHandler(this.btnPremenovat_Click);
            // 
            // btnPrehladavat
            // 
            this.btnPrehladavat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPrehladavat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrehladavat.FlatAppearance.BorderSize = 0;
            this.btnPrehladavat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrehladavat.Image = global::MySubtitles.Properties.Resources.Bodky_blue;
            this.btnPrehladavat.Location = new System.Drawing.Point(690, 249);
            this.btnPrehladavat.Name = "btnPrehladavat";
            this.btnPrehladavat.Radius = 40;
            this.btnPrehladavat.Size = new System.Drawing.Size(60, 38);
            this.btnPrehladavat.TabIndex = 26;
            this.btnPrehladavat.UseVisualStyleBackColor = false;
            this.btnPrehladavat.Click += new System.EventHandler(this.btnPrehladavat_Click);
            // 
            // FormSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(799, 552);
            this.Controls.Add(this.btnPrehladavat);
            this.Controls.Add(this.btnPremenovat);
            this.Controls.Add(this.btnStiahnut);
            this.Controls.Add(this.txtSE);
            this.Controls.Add(this.lblSE);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.txtNazov);
            this.Controls.Add(this.lblDestPath);
            this.Controls.Add(this.lblNazovSerial);
            this.Controls.Add(this.panel_Serial);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSerial";
            this.Text = "FormSerial";
            this.Load += new System.EventHandler(this.FormSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel_Email panel_Serial;
        private System.Windows.Forms.TextBox txtSE;
        private System.Windows.Forms.Label lblSE;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.TextBox txtNazov;
        private System.Windows.Forms.Label lblDestPath;
        private System.Windows.Forms.Label lblNazovSerial;
        private Custom_Button btnStiahnut;
        private Custom_Button btnPremenovat;
        private Custom_Button btnPrehladavat;
    }
}