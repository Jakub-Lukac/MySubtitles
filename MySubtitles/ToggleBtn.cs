using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel;

namespace MySubtitles
{
    class ToggleBtn : CheckBox
    {
        private Color onBackColor;
        private Color onToggleColor;
        private Color offBackColor;
        private Color offToggleColor;
        private bool solidStyle = true;

        public Color OnBackColor { get => onBackColor; set => onBackColor = value; }
        public Color OnToggleColor { get => onToggleColor; set => onToggleColor = value; }
        public Color OffBackColor { get => offBackColor; set => offBackColor = value; }
        public Color OffToggleColor { get => offToggleColor; set => offToggleColor = value; }
        public bool SolidStyle { get => solidStyle; set => solidStyle = value; }

        public ToggleBtn()
        {
            this.MinimumSize = new Size(45, 22);
        }

        private GraphicsPath ZmenTvar()
        {
            int velkostObluka = this.Height - 1;
            Rectangle lavyObluk = new Rectangle(0,0,velkostObluka,velkostObluka);
            Rectangle pravyObluk = new Rectangle(this.Width - velkostObluka - 2, 0, velkostObluka, velkostObluka);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(lavyObluk,90,180);
            path.AddArc(pravyObluk,270,180);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent) // prepisanie povodneho tvaru buttonu na custom
        {
            int velkostToggle = this.Height - 10;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //pevent.Graphics.Clear(this.Parent.BackColor); // zmeni plochu obdlznika kde nie je spirala na pozadie Formy Nastavenia
            if (this.Parent.BackColor == Color.FromArgb(46, 51, 73))
            {
                pevent.Graphics.Clear(Color.FromArgb(35, 40, 62));
            }
            else
            {
                pevent.Graphics.Clear(Color.FromArgb(60, 150, 138));
            }


            if(this.Checked)
            {
                if(solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), ZmenTvar());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), ZmenTvar());
                }
                pevent.Graphics.FillEllipse(new SolidBrush(OnToggleColor), new Rectangle(this.Width - this.Height - 1,4,velkostToggle,velkostToggle));

            }
            else
            {
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), ZmenTvar());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), ZmenTvar());
                }
                pevent.Graphics.FillEllipse(new SolidBrush(OffToggleColor), new Rectangle(6, 4, velkostToggle, velkostToggle));
            }
               
        }

    }
}
