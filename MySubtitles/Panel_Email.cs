using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace MySubtitles
{
    public class Panel_Email : CheckBox
    {
        private Color Pozadie; // pre modru
        private Color Pozadie_Zelena;
        public Panel_Email()
        {
            this.AutoSize = false;
        }

        public Color Pozadie1 { get => Pozadie; set => Pozadie = value; }
        public Color Pozadie_Zelena1 { get => Pozadie_Zelena; set => Pozadie_Zelena = value; }

        private GraphicsPath ZmenTvar()
        {
            int velkostObluka = 80; ;
            GraphicsPath path = new GraphicsPath();
            Rectangle lavyHorny = new Rectangle(0, 0, velkostObluka, velkostObluka);
            Rectangle pravyHorny = new Rectangle(this.Width - velkostObluka, 0, velkostObluka, velkostObluka);
            Rectangle pravyDolny = new Rectangle(this.Width - velkostObluka, this.Height - velkostObluka, velkostObluka, velkostObluka);
            Rectangle lavyDolny = new Rectangle(0, this.Height - velkostObluka, velkostObluka, velkostObluka);
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
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);
            if(this.Parent.BackColor == Color.FromArgb(46, 51, 73))
            {
                pevent.Graphics.FillPath(new SolidBrush(Pozadie), ZmenTvar());
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(Pozadie_Zelena), ZmenTvar());
            }
            
        }
    }
}
