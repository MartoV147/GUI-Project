using GUIProject.shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace GUIProject
{
    public class Ellipse : Shape
    {
        public Ellipse(int X, int Y, int Width, int Height, Color C) : base(X, Y, C)
        {
            setWidth(Width);
            setHeight(Height);
            center = new Point(getX() + getWidth() / 2, getY() + getHeight() / 2);
        }

        public override void Draw(Graphics g)
        {
            PointF[] points = GetAllPoints().ToArray();
            g.Transform = Rotate(g, getAngle(), points, center);
            g.FillEllipse(new SolidBrush(getColor()), getX(), getY(), getWidth(), getHeight());
        }

        public override bool Contains(PointF point)
        {
            Rectangle rect = new Rectangle(getX(), getY(), getWidth(), getHeight(), getColor());
            PointF center = new Point();
            center.X = rect.getX() + getWidth() / 2;
            center.Y = rect.getY() + getHeight() / 2;
            if ((Math.Pow((point.X - center.X), 2) / Math.Pow(getWidth() / 2, 2)) + (Math.Pow((point.Y - center.Y), 2) / Math.Pow(getHeight() / 2, 2)) <= 1) return true;
            return false;
        }

        public override Matrix Rotate(Graphics g, int angle, PointF[] Points, Point center)
        { 
            Matrix result = new Matrix();
            result.RotateAt(angle, center);
            result.TransformPoints(Points);
            return result;
        }

        public override List<PointF> GetAllPoints()
        {
            List<PointF> Points = new List<PointF>();
            PointF point1 = new PointF(getX(), getY());
            PointF point2 = new PointF(getX() + getWidth(), getY());
            PointF point3 = new PointF(getX() + getWidth(), getY() + getHeight());
            PointF point4 = new PointF(getX(), getY() + getHeight());
            Points.Add(point1);
            Points.Add(point2);
            Points.Add(point3);
            Points.Add(point4);
            return Points;
        }

        public override ShapeTypeEnum GetShapeType()
        {
            return ShapeTypeEnum.Ellipse;
        }
    }
}
