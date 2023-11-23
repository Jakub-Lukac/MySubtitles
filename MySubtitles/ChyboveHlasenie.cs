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
    public partial class ChyboveHlasenie : Form
    {
        string f;
        public ChyboveHlasenie()
        {
            InitializeComponent();
        }
        public ChyboveHlasenie(string oznam) : this()
        {

            lbltextChyboveHlasenie.Text = oznam;
        }
        public void Farba(string farba)
        {
            f = farba.ToString();
        }


        private void ChyboveHlasenie_Load(object sender, EventArgs e)
        {
            if (f == "z")
            {
                btnOK.ForeColor = Color.FromArgb(92, 225, 165);
                btnOK.BackColor = Color.FromArgb(0, 100, 113);
                lbltextChyboveHlasenie.ForeColor = Color.FromArgb(92, 225, 165);
                this.BackColor = Color.FromArgb(0, 125, 113);
                ChyboveHlaseniePicture.Image = Zelene.warning_green;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChyboveHlasenie_Paint(object sender, PaintEventArgs e)
        {
            Rectangle obrys = new Rectangle(0, 0, this.Width, this.Height);
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.White, 5), obrys);
        }
    }
}
