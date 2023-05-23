using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIProject.shapes
{
    class Envelope : Shape
    {
        Color fillColor = new Color();
        public Envelope(int X, int Y, int Width, int Height, Color C, Color fillColor) : base(X, Y, C)
        {
            this.fillColor = fillColor;
            setWidth(Width);
            setHeight(Height);
            center = new Point(getX() + getWidth() / 2, getY() + getHeight() / 2);
        }
        public Envelope()
        {
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(getColor());
            PointF[] points = GetAllPoints().ToArray();
            g.Transform = Rotate(getAngle(), points, center);
            g.DrawPolygon(pen, points);
            g.DrawLine(pen, points[0], getCenter());
            g.DrawLine(pen, points[1], getCenter());
        }

        public override bool Contains(PointF point)
        {
            if ((point.X >= getX() && point.X <= getX() + getWidth()) && (point.Y >= getY() && point.Y <= getY() + getHeight())) return true;
            return false;
        }

        public override Matrix Rotate(int angle, PointF[] Points, Point center)
        {
            Matrix result = new Matrix();
            result.RotateAt(angle, center);
            //result.TransformPoints(Points);
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
            return ShapeTypeEnum.Envelope;
        }
    }
}
