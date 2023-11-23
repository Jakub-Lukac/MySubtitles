using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySubtitles
{
    public partial class Hlasenie : Form
    {
        string f;
        public Hlasenie()
        {
            InitializeComponent();
        }
        public Hlasenie(string oznam) : this()
        {

            lbltextHlasenie.Text = oznam;
        }

        public void Farba(string farba)
        {
            f = farba.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hlasenie_Load(object sender, EventArgs e)
        {
            if (f == "z")
            {
                btnOK.ForeColor = Color.FromArgb(92, 225, 165);
                btnOK.BackColor = Color.FromArgb(0, 100, 113);
                lbltextHlasenie.ForeColor = Color.FromArgb(92, 225, 165);
                this.BackColor = Color.FromArgb(0, 125, 113);
                hlaseniePicture.Image = Zelene.warning_green;
            }
        }

        private void Hlasenie_Paint(object sender, PaintEventArgs e)
        {
            Rectangle obrys = new Rectangle(0, 0, this.Width, this.Height);
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.White, 5), obrys);
        }
    }
}
