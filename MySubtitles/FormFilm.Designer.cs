namespace MySubtitles
{
    partial class FormFilm
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
            this.lblNazovFilmu = new System.Windows.Forms.Label();
            this.lblDestPath = new System.Windows.Forms.Label();
            this.txtNazov = new System.Windows.Forms.TextBox();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.btnPrehladavat = new MySubtitles.Custom_Button();
            this.btn_Premenovat = new MySubtitles.Custom_Button();
            this.btn_Stiahnut = new MySubtitles.Custom_Button();
            this.panel_Film = new MySubtitles.Panel_Email();
            this.SuspendLayout();
            // 
            // lblNazovFilmu
            // 
            this.lblNazovFilmu.AutoSize = true;
            this.lblNazovFilmu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblNazovFilmu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNazovFilmu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblNazovFilmu.Location = new System.Drawing.Point(61, 196);
            this.lblNazovFilmu.Name = "lblNazovFilmu";
            this.lblNazovFilmu.Size = new System.Drawing.Size(93, 17);
            this.lblNazovFilmu.TabIndex = 10;
            this.lblNazovFilmu.Text = "Názov Filmu :";
            // 
            // lblDestPath
            // 
            this.lblDestPath.AutoSize = true;
            this.lblDestPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblDestPath.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDestPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblDestPath.Location = new System.Drawing.Point(29, 265);
            this.lblDestPath.Name = "lblDestPath";
            this.lblDestPath.Size = new System.Drawing.Size(125, 17);
            this.lblDestPath.TabIndex = 11;
            this.lblDestPath.Text = "Cieľový priečinok :";
            // 
            // txtNazov
            // 
            this.txtNazov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtNazov.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNazov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtNazov.Location = new System.Drawing.Point(191, 193);
            this.txtNazov.Name = "txtNazov";
            this.txtNazov.Size = new System.Drawing.Size(474, 25);
            this.txtNazov.TabIndex = 12;
            this.txtNazov.TextChanged += new System.EventHandler(this.txtNazov_TextChanged);
            this.txtNazov.Enter += new System.EventHandler(this.txtNazov_Enter);
            this.txtNazov.Leave += new System.EventHandler(this.txtNazov_Leave);
            // 
            // txtDP
            // 
            this.txtDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtDP.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtDP.Location = new System.Drawing.Point(191, 262);
            this.txtDP.Name = "txtDP";
            this.txtDP.ReadOnly = true;
            this.txtDP.Size = new System.Drawing.Size(474, 25);
            this.txtDP.TabIndex = 13;
            this.txtDP.TextChanged += new System.EventHandler(this.txtDP_TextChanged);
            // 
            // btnPrehladavat
            // 
            this.btnPrehladavat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPrehladavat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrehladavat.FlatAppearance.BorderSize = 0;
            this.btnPrehladavat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrehladavat.Image = global::MySubtitles.Properties.Resources.Bodky_blue;
            this.btnPrehladavat.Location = new System.Drawing.Point(687, 255);
            this.btnPrehladavat.Name = "btnPrehladavat";
            this.btnPrehladavat.Radius = 40;
            this.btnPrehladavat.Size = new System.Drawing.Size(60, 38);
            this.btnPrehladavat.TabIndex = 19;
            this.btnPrehladavat.UseVisualStyleBackColor = false;
            this.btnPrehladavat.Click += new System.EventHandler(this.btnPrehladavat_Click);
            // 
            // btn_Premenovat
            // 
            this.btn_Premenovat.BackColor = System.Drawing.Color.White;
            this.btn_Premenovat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Premenovat.Enabled = false;
            this.btn_Premenovat.FlatAppearance.BorderSize = 0;
            this.btn_Premenovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Premenovat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Premenovat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btn_Premenovat.Image = global::MySubtitles.Properties.Resources.Premenovanie_blue2;
            this.btn_Premenovat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Premenovat.Location = new System.Drawing.Point(524, 312);
            this.btn_Premenovat.Name = "btn_Premenovat";
            this.btn_Premenovat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Premenovat.Radius = 40;
            this.btn_Premenovat.Size = new System.Drawing.Size(141, 52);
            this.btn_Premenovat.TabIndex = 18;
            this.btn_Premenovat.Text = "Premenovať";
            this.btn_Premenovat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Premenovat.UseVisualStyleBackColor = false;
            this.btn_Premenovat.Click += new System.EventHandler(this.btn_Premenovat_Click);
            // 
            // btn_Stiahnut
            // 
            this.btn_Stiahnut.BackColor = System.Drawing.Color.White;
            this.btn_Stiahnut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stiahnut.Enabled = false;
            this.btn_Stiahnut.FlatAppearance.BorderSize = 0;
            this.btn_Stiahnut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stiahnut.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_Stiahnut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btn_Stiahnut.Image = global::MySubtitles.Properties.Resources.download_blue;
            this.btn_Stiahnut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stiahnut.Location = new System.Drawing.Point(191, 315);
            this.btn_Stiahnut.Name = "btn_Stiahnut";
            this.btn_Stiahnut.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Stiahnut.Radius = 40;
            this.btn_Stiahnut.Size = new System.Drawing.Size(118, 52);
            this.btn_Stiahnut.TabIndex = 17;
            this.btn_Stiahnut.Text = "Stiahnúť";
            this.btn_Stiahnut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Stiahnut.UseVisualStyleBackColor = false;
            this.btn_Stiahnut.Click += new System.EventHandler(this.btn_Stiahnut_Click);
            // 
            // panel_Film
            // 
            this.panel_Film.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.panel_Film.FlatAppearance.BorderSize = 5;
            this.panel_Film.Location = new System.Drawing.Point(12, 154);
            this.panel_Film.Name = "panel_Film";
            this.panel_Film.Pozadie_Zelena1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.panel_Film.Pozadie1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.panel_Film.Size = new System.Drawing.Size(766, 233);
            this.panel_Film.TabIndex = 9;
            this.panel_Film.Tag = "60; 150; 138";
            this.panel_Film.Text = "panel_Email2";
            this.panel_Film.UseVisualStyleBackColor = true;
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(799, 552);
            this.Controls.Add(this.btnPrehladavat);
            this.Controls.Add(this.btn_Premenovat);
            this.Controls.Add(this.btn_Stiahnut);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.txtNazov);
            this.Controls.Add(this.lblDestPath);
            this.Controls.Add(this.lblNazovFilmu);
            this.Controls.Add(this.panel_Film);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFilm";
            this.Text = "FormFilm";
            this.Load += new System.EventHandler(this.FormFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel_Email panel_Film;
        private System.Windows.Forms.Label lblNazovFilmu;
        private System.Windows.Forms.Label lblDestPath;
        private System.Windows.Forms.TextBox txtNazov;
        private System.Windows.Forms.TextBox txtDP;
        private Custom_Button btn_Stiahnut;
        private Custom_Button btn_Premenovat;
        private Custom_Button btnPrehladavat;
    }
}