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
    public partial class FormKontakt : Form
    {
        string f;

        public FormKontakt()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormKontakt_Load(object sender, EventArgs e)
        {
            f = Settings.Default["Farba"].ToString();
            if (f == "z")
            {
                this.BackColor = Color.FromArgb(0, 125, 113);
                picBoxEmail.BackColor = Color.FromArgb(60, 150, 138);
                picBoxFacebook.BackColor = Color.FromArgb(60, 150, 138);
                picBoxInstagram.BackColor = Color.FromArgb(60, 150, 138);
                lblEmail.BackColor = Color.FromArgb(60, 150, 138);
                lblFacebook.BackColor = Color.FromArgb(60, 150, 138);
                lblInstagram.BackColor = Color.FromArgb(60, 150, 138);
                txtPopis.BackColor = Color.FromArgb(0, 125, 113);
                lblEmail.ForeColor = Color.FromArgb(92, 225, 165);
                lblFacebook.ForeColor = Color.FromArgb(92, 225, 165);
                lblInstagram.ForeColor = Color.FromArgb(92, 225, 165);
                picBoxEmail.Image = Zelene.email_green;
                picBoxFacebook.Image = Zelene.facebook_green;
                picBoxInstagram.Image = Zelene.instagram_green;
                picBoxSupport.Image = Zelene.support_zelene;
            }
        }
    }
}