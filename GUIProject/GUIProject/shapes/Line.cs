using GUIProject.shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace GUIProject
{
    public class Line : Shape
    {
        public int x1;
        public int y1;
        public Line(int X, int Y, int Width, int Height, Color C, int Thickness) : base(X, Y, C)
        {
            setWidth(Width);
            x1 = X + Width;
            setHeight(Height);
            y1 = Y + Height;
            thickness = Thickness;
            center = new Point((getX() + x1) / 2, (getY() + y1) / 2);
        }


        public override void Draw(Graphics g)
        {
            PointF[] Points = GetAllPoints().ToArray();
            g.Transform = Rotate(getAngle(), Points, center);
            g.DrawLine(new Pen(new SolidBrush(getColor()), thickness), new PointF(getX(), getY()), new PointF(x1, y1));
        }

        public override bool Contains(PointF point)
        {
            var path = new GraphicsPath();
            var pen = new Pen(Brushes.Black, thickness);
            path.AddLine(new PointF(getX(), getY()),new PointF(x1, y1));
            return path.IsOutlineVisible(point, pen);
        }

        public override Matrix Rotate(int angle, PointF[] points, Point center)
        {  
            Matrix result = new Matrix();
            result.RotateAt(angle, center);
            result.TransformPoints(points);
            return result;
        }

        public override List<PointF> GetAllPoints()
        {
           List<PointF> Points = new List<PointF>();
            PointF point1 = new PointF(getX(), getY());
            PointF point2 = new PointF(x1, y1);
            Points.Add(point1);
            Points.Add(point2);
            return Points;
        }

        public override ShapeTypeEnum GetShapeType()
        {
            return ShapeTypeEnum.Line;
        }

        public override void Scale(int Width, int Height)
        {
            base.Scale(Width, Height);
            x1 = Width;
            y1 = Height;
        }
    }
}
