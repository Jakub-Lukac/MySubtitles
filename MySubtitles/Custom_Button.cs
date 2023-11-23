using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MySubtitles
{
    public class Custom_Button : Button
    {
        private int radius = 40; // musi mat default hodnotu, aby mi ho nakreslilo

        public int Radius { get => radius; set => radius = value; }

        public Custom_Button()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.FromArgb(24, 30, 54);
        }

        private GraphicsPath ZmenTvar(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle lavyHorny = new Rectangle(0, 0, radius, radius);
            Rectangle pravyHorny = new Rectangle(this.Width - radius, 0, radius, radius);
            Rectangle pravyDolny = new Rectangle(this.Width - radius, this.Height - radius, radius, radius);
            Rectangle lavyDolny = new Rectangle(0, this.Height - radius, radius, radius);
            path.StartFigure();
            path.AddArc(lavyHorny, 180, 90);
            path.AddArc(pravyHorny, 270, 90);
            path.AddArc(pravyDolny, 0, 90);
            path.AddArc(lavyDolny, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            using (GraphicsPath plochaObjektu = ZmenTvar(radius))
            using (Pen vyplnPlochy = new Pen(this.Parent.BackColor, 2))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                this.Region = new Region(plochaObjektu);
                pevent.Graphics.DrawPath(vyplnPlochy, plochaObjektu);
            }
        }
    }
}

