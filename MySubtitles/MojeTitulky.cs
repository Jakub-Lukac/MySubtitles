using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySubtitles.Properties;



namespace MySubtitles
{
    public partial class MojeTitulky : Form
    {
        private Button currentButton;
        private Panel leftBorderButton;
        private Form activeForm;
        string v = "m"; // musim dat na modru, aby ked zapnem program mi to nepadlo, lebo do Farba() príde null -- error
        public Button CurrentButton { get => currentButton; set => currentButton = value; }
        public Panel LeftBorderButton { get => leftBorderButton; set => leftBorderButton = value; }

        public MojeTitulky()
        {
            InitializeComponent();

            LeftBorderButton = new Panel();
            LeftBorderButton.Size = new Size(10, 60);
            panelMenu.Controls.Add(LeftBorderButton);
        }
       
        private void ActiveButton(object senderButton)
        {
            if (senderButton != null)
            {
                DisableButton();
                Color colorBlue = Color.FromArgb(68, 181, 254);
                Color colorGreen = Color.FromArgb(92, 225, 165);
                currentButton = (Button)senderButton;
                if(v == "z")
                {
                    currentButton.BackColor = Color.FromArgb(0, 100, 113);
                    LeftBorderButton.BackColor = colorGreen;
                }    
                else
                {
                    currentButton.BackColor = Color.FromArgb(46, 51, 73);
                    LeftBorderButton.BackColor = colorBlue;
                }
                LeftBorderButton.Location = new Point(0, currentButton.Location.Y);
                LeftBorderButton.Visible = true;
                LeftBorderButton.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                if (v == "z")
                {
                    currentButton.BackColor = Color.FromArgb(0, 100, 113);
                    currentButton.ForeColor = Color.FromArgb(92, 225, 165);
                }
                else
                {
                    currentButton.BackColor = Color.FromArgb(24, 30, 54);
                    currentButton.ForeColor = Color.FromArgb(68, 181, 254);
                }
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblUzivatel.Text = Settings.Default["Meno"].ToString();
            v = Settings.Default["Farba"].ToString();
            if (v == "z")
            {
                pictureUser.Image = Zelene.User_green;
                btnHome.Image = Zelene.Home_green;
                btnFilm.Image = Zelene.Play_green;
                btnSerial.Image = Zelene.Serial_green;
                btnContact.Image = Zelene.Kontakt_green;
                btnSetting.Image = Zelene.Nastavenia_green;
                btnClose.Image = Zelene.exit_green;
                btnMinimaze.Image = Zelene.Minimize_green;

                btnHome.ForeColor = Color.FromArgb(92, 225, 165);
                btnFilm.ForeColor = Color.FromArgb(92, 225, 165);
                btnSerial.ForeColor = Color.FromArgb(92, 225, 165);
                btnContact.ForeColor = Color.FromArgb(92, 225, 165);
                btnSetting.ForeColor = Color.FromArgb(92, 225, 165);

                btnMinimaze.BackColor = Color.FromArgb(0, 100, 113);
                btnClose.BackColor = Color.FromArgb(0, 100, 113);
                btnHome.BackColor = Color.FromArgb(0, 100, 113);
                btnFilm.BackColor = Color.FromArgb(0, 100, 113);
                btnSerial.BackColor = Color.FromArgb(0, 100, 113);
                btnContact.BackColor = Color.FromArgb(0, 100, 113);
                btnSetting.BackColor = Color.FromArgb(0, 100, 113);
                panelLogo.BackColor = Color.FromArgb(0, 100, 113);
                panelMenu.BackColor = Color.FromArgb(0, 100, 113);
                panelFillForm.BackColor = Color.FromArgb(0, 125, 113);
                this.BackColor = Color.FromArgb(0, 100, 113); // Form1 zmena farby

                lblUzivatel.ForeColor = Color.FromArgb(92, 225, 165);

                picBoxLogo.Image = Zelene.logo_green;
                this.Icon = Zelene.icon_green;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openPanelFillForm(new FormHome(), sender);
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            openPanelFillForm(new FormFilm(), sender);
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            openPanelFillForm(new FormSerial(), sender);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            openPanelFillForm(new FormKontakt(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            openPanelFillForm(new FormNastavenia(), sender);
        }
 
        private void openPanelFillForm(Form fillForm, object senderButton)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(senderButton);
            activeForm = fillForm;
            fillForm.TopLevel = false;
            fillForm.FormBorderStyle = FormBorderStyle.None;
            fillForm.Dock = DockStyle.Fill;
            panelFillForm.Controls.Add(fillForm);
            panelFillForm.Tag = fillForm;
            fillForm.BringToFront();
            fillForm.Show();
        }

        private void pictureUser_Click(object sender, EventArgs e)
        {
        }


        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblUzivatel_Click(object sender, EventArgs e)
        {

        }
        private void panelFillForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private Point _mouseLoc;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }
    }
}
