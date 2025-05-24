using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace PIA_1._0
{
    public class ArtanPanel : Panel
    {
        private int borderSize = 0;
        private int borderRadius = 0;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.FromArgb(14, 40, 65);
        private Color gradientBottomColor = Color.FromArgb(14, 40, 65);

        //Constructor
        public ArtanPanel()
        {
            BackColor = Color.FromArgb(14, 40, 65);
            Size = new Size(186, 604);
        }

        //Properties
        public int BorderRadius { get => borderRadius; set { borderRadius = value; Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; Invalidate(); } }
        public Color GradientTopColor { get => gradientTopColor; set { gradientTopColor = value; Invalidate(); } }
        public Color GradientBottomColor { get => gradientBottomColor; set { gradientBottomColor = value; Invalidate(); } }

        //Methods

        private GraphicsPath GetArtanPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        //override

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Configuración de suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Dibujar sombra
            int shadowOffsetX = 10; // Desplazamiento horizontal de la sombra
            int shadowOffsetY = 10; // Desplazamiento vertical de la sombra
            Color shadowColor = Color.FromArgb(60, 0, 0, 0); // Color de la sombra con transparencia
            Rectangle shadowRect = new Rectangle(shadowOffsetX, shadowOffsetY, Width, Height);

            if (borderRadius > 2)
            {
                using (GraphicsPath shadowPath = GetArtanPath(new RectangleF(shadowRect.X, shadowRect.Y, shadowRect.Width, shadowRect.Height), borderRadius))
                using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
                {
                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }
            }
            else
            {
                using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
                {
                    e.Graphics.FillRectangle(shadowBrush, shadowRect);
                }
            }

            // Dibujar gradiente
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, gradientTopColor, gradientBottomColor, gradientAngle);
            e.Graphics.FillRectangle(brush, ClientRectangle);

            // Dibujar borde redondeado
            RectangleF rectangleF = new RectangleF(0, 0, Width, Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {
                    Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else
            {
                Region = new Region(rectangleF);
            }
        }


    }
}