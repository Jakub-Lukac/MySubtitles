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
    public partial class FormHome : Form
    {
        string f;
        public FormHome()
        {
            InitializeComponent();
           /* btnInfo1.FlatStyle = FlatStyle.Popup;
            btnInfo2.FlatStyle = FlatStyle.Popup;
            btnInfo3.FlatStyle = FlatStyle.Popup;
            btnInfo4.FlatStyle = FlatStyle.Popup;
            btnInfo5.FlatStyle = FlatStyle.Popup;
            btnInfo6.FlatStyle = FlatStyle.Popup;

            btnText1.FlatStyle = FlatStyle.Popup;
            btnText2.FlatStyle = FlatStyle.Popup;
            btnText3.FlatStyle = FlatStyle.Popup;
            btnText4.FlatStyle = FlatStyle.Popup;
            btnText5.FlatStyle = FlatStyle.Popup;
            btnText6.FlatStyle = FlatStyle.Popup;*/
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            f = Settings.Default["Farba"].ToString();
            Settings.Default.Save();
            if (f == "z")
            {
                btnInfo1.Image = Zelene.Info_green;
                btnInfo2.Image = Zelene.Info_green;
                btnInfo3.Image = Zelene.Info_green;
                btnInfo4.Image = Zelene.Info_green;
                btnInfo5.Image = Zelene.Info_green;
                btnInfo6.Image = Zelene.Info_green;

                btnText1.ForeColor = Color.FromArgb(92, 225, 165);
                btnText2.ForeColor = Color.FromArgb(92, 225, 165);
                btnText3.ForeColor = Color.FromArgb(92, 225, 165);
                btnText4.ForeColor = Color.FromArgb(92, 225, 165);
                btnText5.ForeColor = Color.FromArgb(92, 225, 165);
                btnText6.ForeColor = Color.FromArgb(92, 225, 165);

                this.BackColor = Color.FromArgb(0, 125, 113);

                btnInfo1.BackColor = Color.FromArgb(0, 100, 113);
                btnInfo2.BackColor = Color.FromArgb(0, 100, 113);
                btnInfo3.BackColor = Color.FromArgb(0, 100, 113);
                btnInfo4.BackColor = Color.FromArgb(0, 100, 113);
                btnInfo5.BackColor = Color.FromArgb(0, 100, 113);
                btnInfo6.BackColor = Color.FromArgb(0, 100, 113);

                btnText1.BackColor = Color.FromArgb(0, 100, 113);
                btnText2.BackColor = Color.FromArgb(0, 100, 113);
                btnText3.BackColor = Color.FromArgb(0, 100, 113);
                btnText4.BackColor = Color.FromArgb(0, 100, 113);
                btnText5.BackColor = Color.FromArgb(0, 100, 113);
                btnText6.BackColor = Color.FromArgb(0, 100, 113);
            }
            
        }
        private void btnInfo1_Click(object sender, EventArgs e)
        {
            btnInfo1.Visible = false;
            btnText1.Visible = true;
        }

        private void btnText1_Click(object sender, EventArgs e)
        {
            btnText1.Visible = false;
            btnInfo1.Visible = true;
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            btnInfo2.Visible = false;
            btnText2.Visible = true;
        }

        private void btnText2_Click(object sender, EventArgs e)
        {
            btnText2.Visible = false;
            btnInfo2.Visible = true;
        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {
            btnInfo3.Visible = false;
            btnText3.Visible = true;
        }

        private void btnText3_Click(object sender, EventArgs e)
        {
            btnText3.Visible = false;
            btnInfo3.Visible = true;
        }

        private void btnInfo4_Click(object sender, EventArgs e)
        {
            btnInfo4.Visible = false;
            btnText4.Visible = true;
        }

        private void btnText4_Click(object sender, EventArgs e)
        {
            btnText4.Visible = false;
            btnInfo4.Visible = true;
        }

        private void btnInfo5_Click(object sender, EventArgs e)
        {
            btnInfo5.Visible = false;
            btnText5.Visible = true;
        }

        private void btnText5_Click(object sender, EventArgs e)
        {
            btnText5.Visible = false;
            btnInfo5.Visible = true;
        }

        private void btnInfo6_Click(object sender, EventArgs e)
        {
            btnInfo6.Visible = false;
            btnText6.Visible = true;
        }

        private void btnText6_Click(object sender, EventArgs e)
        {
            btnText6.Visible = false;
            btnInfo6.Visible = true;
        }
    }
}
