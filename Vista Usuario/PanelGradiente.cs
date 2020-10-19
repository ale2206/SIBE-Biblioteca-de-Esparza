using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Vistas
{
    public class PanelGradiente : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorBottom, this.ColorTop, 90F);
            //LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
        public void CreateDiagonalLinearGradients(PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
               new Point(0, 0),
               new Point(200, 100),
               Color.FromArgb(255, 0, 0, 255),   // opaque blue
               Color.FromArgb(255, 0, 255, 0));  // opaque green

            Pen pen = new Pen(linGrBrush, 10);

            e.Graphics.DrawLine(pen, 0, 0, 600, 300);
            e.Graphics.FillEllipse(linGrBrush, 10, 100, 200, 100);
        }
    }
}