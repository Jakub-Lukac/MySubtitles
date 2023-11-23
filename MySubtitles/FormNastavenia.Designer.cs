namespace MySubtitles
{
    partial class FormNastavenia
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
            this.lblPozadie = new System.Windows.Forms.Label();
            this.lblUdaje = new System.Windows.Forms.Label();
            this.txtMeno = new System.Windows.Forms.TextBox();
            this.lblMeno = new System.Windows.Forms.Label();
            this.txtHeslo = new System.Windows.Forms.TextBox();
            this.lblHeslo = new System.Windows.Forms.Label();
            this.lblChrome = new System.Windows.Forms.Label();
            this.txtCesta = new System.Windows.Forms.TextBox();
            this.btnUlozitDriver = new MySubtitles.Custom_Button();
            this.btnPrehladavat = new MySubtitles.Custom_Button();
            this.panel_Webdriver = new MySubtitles.Panel_Email();
            this.btnUlozit = new MySubtitles.Custom_Button();
            this.panel_Udaje = new MySubtitles.Panel_Email();
            this.toggleBtnGreen = new MySubtitles.ToggleBtn();
            this.toggleBtnBlue = new MySubtitles.ToggleBtn();
            this.panel_Pozadie = new MySubtitles.Panel_Email();
            this.lblDownload = new System.Windows.Forms.Label();
            this.txtDownloads = new System.Windows.Forms.TextBox();
            this.btnPrehladavatDownload = new MySubtitles.Custom_Button();
            this.btnUlozitDownload = new MySubtitles.Custom_Button();
            this.SuspendLayout();
            // 
            // lblPozadie
            // 
            this.lblPozadie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblPozadie.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozadie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblPozadie.Location = new System.Drawing.Point(118, 75);
            this.lblPozadie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPozadie.Name = "lblPozadie";
            this.lblPozadie.Size = new System.Drawing.Size(231, 34);
            this.lblPozadie.TabIndex = 14;
            this.lblPozadie.Text = "Farba Pozadia";
            // 
            // lblUdaje
            // 
            this.lblUdaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblUdaje.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUdaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblUdaje.Location = new System.Drawing.Point(681, 75);
            this.lblUdaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUdaje.Name = "lblUdaje";
            this.lblUdaje.Size = new System.Drawing.Size(309, 34);
            this.lblUdaje.TabIndex = 18;
            this.lblUdaje.Text = "Prihlasovacie údaje";
            // 
            // txtMeno
            // 
            this.txtMeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtMeno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtMeno.Location = new System.Drawing.Point(772, 158);
            this.txtMeno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMeno.Name = "txtMeno";
            this.txtMeno.Size = new System.Drawing.Size(322, 31);
            this.txtMeno.TabIndex = 20;
            this.txtMeno.TextChanged += new System.EventHandler(this.txtMeno_TextChanged);
            // 
            // lblMeno
            // 
            this.lblMeno.AutoSize = true;
            this.lblMeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblMeno.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMeno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblMeno.Location = new System.Drawing.Point(663, 160);
            this.lblMeno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeno.Name = "lblMeno";
            this.lblMeno.Size = new System.Drawing.Size(77, 28);
            this.lblMeno.TabIndex = 19;
            this.lblMeno.Text = "Meno :";
            // 
            // txtHeslo
            // 
            this.txtHeslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtHeslo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtHeslo.Location = new System.Drawing.Point(772, 240);
            this.txtHeslo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeslo.Name = "txtHeslo";
            this.txtHeslo.PasswordChar = '*';
            this.txtHeslo.Size = new System.Drawing.Size(322, 31);
            this.txtHeslo.TabIndex = 22;
            this.txtHeslo.TextChanged += new System.EventHandler(this.txtHeslo_TextChanged);
            // 
            // lblHeslo
            // 
            this.lblHeslo.AutoSize = true;
            this.lblHeslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblHeslo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblHeslo.Location = new System.Drawing.Point(663, 242);
            this.lblHeslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeslo.Name = "lblHeslo";
            this.lblHeslo.Size = new System.Drawing.Size(76, 28);
            this.lblHeslo.TabIndex = 21;
            this.lblHeslo.Text = "Heslo :";
            // 
            // lblChrome
            // 
            this.lblChrome.AutoSize = true;
            this.lblChrome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblChrome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChrome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblChrome.Location = new System.Drawing.Point(118, 528);
            this.lblChrome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChrome.Name = "lblChrome";
            this.lblChrome.Size = new System.Drawing.Size(255, 32);
            this.lblChrome.TabIndex = 26;
            this.lblChrome.Text = "Cesta ChromeDrivera";
            // 
            // txtCesta
            // 
            this.txtCesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCesta.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtCesta.Location = new System.Drawing.Point(125, 592);
            this.txtCesta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCesta.Name = "txtCesta";
            this.txtCesta.ReadOnly = true;
            this.txtCesta.Size = new System.Drawing.Size(445, 31);
            this.txtCesta.TabIndex = 29;
            this.txtCesta.TextChanged += new System.EventHandler(this.txtCesta_TextChanged);
            // 
            // btnUlozitDriver
            // 
            this.btnUlozitDriver.BackColor = System.Drawing.Color.White;
            this.btnUlozitDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUlozitDriver.Enabled = false;
            this.btnUlozitDriver.FlatAppearance.BorderSize = 0;
            this.btnUlozitDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlozitDriver.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUlozitDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnUlozitDriver.Location = new System.Drawing.Point(716, 570);
            this.btnUlozitDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUlozitDriver.Name = "btnUlozitDriver";
            this.btnUlozitDriver.Radius = 40;
            this.btnUlozitDriver.Size = new System.Drawing.Size(186, 72);
            this.btnUlozitDriver.TabIndex = 30;
            this.btnUlozitDriver.Text = "Uložiť zmeny";
            this.btnUlozitDriver.UseVisualStyleBackColor = false;
            this.btnUlozitDriver.Click += new System.EventHandler(this.btnUlozitDriver_Click);
            // 
            // btnPrehladavat
            // 
            this.btnPrehladavat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPrehladavat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrehladavat.FlatAppearance.BorderSize = 0;
            this.btnPrehladavat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrehladavat.Image = global::MySubtitles.Properties.Resources.Bodky_blue;
            this.btnPrehladavat.Location = new System.Drawing.Point(598, 578);
            this.btnPrehladavat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrehladavat.Name = "btnPrehladavat";
            this.btnPrehladavat.Radius = 40;
            this.btnPrehladavat.Size = new System.Drawing.Size(88, 60);
            this.btnPrehladavat.TabIndex = 27;
            this.btnPrehladavat.UseVisualStyleBackColor = false;
            this.btnPrehladavat.Click += new System.EventHandler(this.btnPrehladavat_Click);
            // 
            // panel_Webdriver
            // 
            this.panel_Webdriver.Location = new System.Drawing.Point(64, 495);
            this.panel_Webdriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Webdriver.Name = "panel_Webdriver";
            this.panel_Webdriver.Pozadie_Zelena1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.panel_Webdriver.Pozadie1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.panel_Webdriver.Size = new System.Drawing.Size(1030, 309);
            this.panel_Webdriver.TabIndex = 25;
            this.panel_Webdriver.Text = "panel_Email1";
            this.panel_Webdriver.UseVisualStyleBackColor = true;
            this.panel_Webdriver.CheckedChanged += new System.EventHandler(this.panel_Webdriver_CheckedChanged);
            // 
            // btnUlozit
            // 
            this.btnUlozit.BackColor = System.Drawing.Color.White;
            this.btnUlozit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUlozit.Enabled = false;
            this.btnUlozit.FlatAppearance.BorderSize = 0;
            this.btnUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlozit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUlozit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnUlozit.Location = new System.Drawing.Point(910, 311);
            this.btnUlozit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Radius = 40;
            this.btnUlozit.Size = new System.Drawing.Size(186, 72);
            this.btnUlozit.TabIndex = 24;
            this.btnUlozit.Text = "Uložiť zmeny";
            this.btnUlozit.UseVisualStyleBackColor = false;
            this.btnUlozit.Click += new System.EventHandler(this.btnUlozit_Click);
            // 
            // panel_Udaje
            // 
            this.panel_Udaje.Location = new System.Drawing.Point(624, 54);
            this.panel_Udaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Udaje.Name = "panel_Udaje";
            this.panel_Udaje.Pozadie_Zelena1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.panel_Udaje.Pozadie1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.panel_Udaje.Size = new System.Drawing.Size(508, 380);
            this.panel_Udaje.TabIndex = 17;
            this.panel_Udaje.Text = "panel_Email1";
            this.panel_Udaje.UseVisualStyleBackColor = true;
            // 
            // toggleBtnGreen
            // 
            this.toggleBtnGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleBtnGreen.Location = new System.Drawing.Point(124, 291);
            this.toggleBtnGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggleBtnGreen.MinimumSize = new System.Drawing.Size(68, 34);
            this.toggleBtnGreen.Name = "toggleBtnGreen";
            this.toggleBtnGreen.OffBackColor = System.Drawing.Color.Silver;
            this.toggleBtnGreen.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(225)))), ((int)(((byte)(165)))));
            this.toggleBtnGreen.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(113)))));
            this.toggleBtnGreen.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(225)))), ((int)(((byte)(165)))));
            this.toggleBtnGreen.Size = new System.Drawing.Size(172, 77);
            this.toggleBtnGreen.SolidStyle = true;
            this.toggleBtnGreen.TabIndex = 16;
            this.toggleBtnGreen.Text = "toggleBtn2";
            this.toggleBtnGreen.UseVisualStyleBackColor = true;
            this.toggleBtnGreen.Click += new System.EventHandler(this.toggleBtnGreen_Click);
            // 
            // toggleBtnBlue
            // 
            this.toggleBtnBlue.Checked = true;
            this.toggleBtnBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleBtnBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleBtnBlue.Location = new System.Drawing.Point(124, 158);
            this.toggleBtnBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toggleBtnBlue.MinimumSize = new System.Drawing.Size(68, 34);
            this.toggleBtnBlue.Name = "toggleBtnBlue";
            this.toggleBtnBlue.OffBackColor = System.Drawing.Color.Silver;
            this.toggleBtnBlue.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.toggleBtnBlue.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.toggleBtnBlue.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.toggleBtnBlue.Size = new System.Drawing.Size(172, 77);
            this.toggleBtnBlue.SolidStyle = true;
            this.toggleBtnBlue.TabIndex = 15;
            this.toggleBtnBlue.Text = "toggleBtn2";
            this.toggleBtnBlue.UseVisualStyleBackColor = true;
            this.toggleBtnBlue.CheckedChanged += new System.EventHandler(this.toggleBtnBlue_CheckedChanged_1);
            this.toggleBtnBlue.Click += new System.EventHandler(this.toggleBtnBlue_Click_1);
            // 
            // panel_Pozadie
            // 
            this.panel_Pozadie.Location = new System.Drawing.Point(64, 54);
            this.panel_Pozadie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Pozadie.Name = "panel_Pozadie";
            this.panel_Pozadie.Pozadie_Zelena1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.panel_Pozadie.Pozadie1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.panel_Pozadie.Size = new System.Drawing.Size(422, 380);
            this.panel_Pozadie.TabIndex = 13;
            this.panel_Pozadie.Text = "panel_Email1";
            this.panel_Pozadie.UseVisualStyleBackColor = true;
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.lblDownload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.lblDownload.Location = new System.Drawing.Point(119, 652);
            this.lblDownload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(326, 32);
            this.lblDownload.TabIndex = 31;
            this.lblDownload.Text = "Cesta Downloads priečinku";
            this.lblDownload.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDownloads
            // 
            this.txtDownloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtDownloads.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.txtDownloads.Location = new System.Drawing.Point(125, 706);
            this.txtDownloads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDownloads.Name = "txtDownloads";
            this.txtDownloads.ReadOnly = true;
            this.txtDownloads.Size = new System.Drawing.Size(445, 31);
            this.txtDownloads.TabIndex = 32;
            this.txtDownloads.TextChanged += new System.EventHandler(this.txtDownloads_TextChanged);
            // 
            // btnPrehladavatDownload
            // 
            this.btnPrehladavatDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPrehladavatDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrehladavatDownload.FlatAppearance.BorderSize = 0;
            this.btnPrehladavatDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrehladavatDownload.Image = global::MySubtitles.Properties.Resources.Bodky_blue;
            this.btnPrehladavatDownload.Location = new System.Drawing.Point(598, 693);
            this.btnPrehladavatDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrehladavatDownload.Name = "btnPrehladavatDownload";
            this.btnPrehladavatDownload.Radius = 40;
            this.btnPrehladavatDownload.Size = new System.Drawing.Size(88, 60);
            this.btnPrehladavatDownload.TabIndex = 33;
            this.btnPrehladavatDownload.UseVisualStyleBackColor = false;
            this.btnPrehladavatDownload.Click += new System.EventHandler(this.btnPrehladavatDownload_Click);
            // 
            // btnUlozitDownload
            // 
            this.btnUlozitDownload.BackColor = System.Drawing.Color.White;
            this.btnUlozitDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUlozitDownload.Enabled = false;
            this.btnUlozitDownload.FlatAppearance.BorderSize = 0;
            this.btnUlozitDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlozitDownload.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUlozitDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.btnUlozitDownload.Location = new System.Drawing.Point(716, 685);
            this.btnUlozitDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUlozitDownload.Name = "btnUlozitDownload";
            this.btnUlozitDownload.Radius = 40;
            this.btnUlozitDownload.Size = new System.Drawing.Size(186, 72);
            this.btnUlozitDownload.TabIndex = 34;
            this.btnUlozitDownload.Text = "Uložiť zmeny";
            this.btnUlozitDownload.UseVisualStyleBackColor = false;
            this.btnUlozitDownload.Click += new System.EventHandler(this.btnUlozitDownload_Click);
            // 
            // FormNastavenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1198, 849);
            this.Controls.Add(this.btnUlozitDownload);
            this.Controls.Add(this.btnPrehladavatDownload);
            this.Controls.Add(this.txtDownloads);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.btnUlozitDriver);
            this.Controls.Add(this.txtCesta);
            this.Controls.Add(this.btnPrehladavat);
            this.Controls.Add(this.lblChrome);
            this.Controls.Add(this.panel_Webdriver);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.txtHeslo);
            this.Controls.Add(this.lblHeslo);
            this.Controls.Add(this.txtMeno);
            this.Controls.Add(this.lblMeno);
            this.Controls.Add(this.lblUdaje);
            this.Controls.Add(this.panel_Udaje);
            this.Controls.Add(this.toggleBtnGreen);
            this.Controls.Add(this.toggleBtnBlue);
            this.Controls.Add(this.lblPozadie);
            this.Controls.Add(this.panel_Pozadie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNastavenia";
            this.Text = "FormNastavenia";
            this.Load += new System.EventHandler(this.FormNastavenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel_Email panel_Pozadie;
        private System.Windows.Forms.Label lblPozadie;
        private ToggleBtn toggleBtnBlue;
        private Panel_Email panel_Udaje;
        private System.Windows.Forms.Label lblUdaje;
        private System.Windows.Forms.TextBox txtMeno;
        private System.Windows.Forms.Label lblMeno;
        private ToggleBtn toggleBtnGreen;
        private System.Windows.Forms.TextBox txtHeslo;
        private System.Windows.Forms.Label lblHeslo;
        private Custom_Button btnUlozit;
        private Panel_Email panel_Webdriver;
        private System.Windows.Forms.Label lblChrome;
        private Custom_Button btnPrehladavat;
        private System.Windows.Forms.TextBox txtCesta;
        private Custom_Button btnUlozitDriver;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.TextBox txtDownloads;
        private Custom_Button btnPrehladavatDownload;
        private Custom_Button btnUlozitDownload;
    }
}