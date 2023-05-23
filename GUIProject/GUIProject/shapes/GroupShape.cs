using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject.shapes
{
    public class GroupShape : Shape
    {
        public List<IShape> groupedShapes;

        public float x1 { get; set; }
        public float y1 { get; set; }

        List<PointF> points = new List<PointF>();

        public GroupShape(List<IShape> GroupedShapes) 
        {
            groupedShapes = GroupedShapes;
            ReCalcSize();
        }
        public GroupShape()
        {
        }

        public void ReCalcSize()
        {
            points.Clear();
            foreach (var shape in groupedShapes)
            {
                points.AddRange(shape.GetAllPoints());
            }
            var sortedByX = points.OrderBy(x => x.X);
            var sortedByY = points.OrderBy(y => y.Y);

            setX((int)sortedByX.FirstOrDefault().X);
            setY((int)sortedByY.FirstOrDefault().Y);

            x1 = (int)sortedByX.LastOrDefault().X;
            y1 = (int)sortedByY.LastOrDefault().Y;

            setWidth(Math.Abs(Math.Max((int)x1, (int)getX()) - Math.Min((int)x1, (int)getX())));
            setHeight(Math.Abs(Math.Max((int)y1, (int)getY()) - Math.Min((int)y1, (int)getY())));
        }

        public override void Draw(Graphics g)
        {
            for (int i = 0; i < groupedShapes.Count; i++)
            {
                groupedShapes[i].Draw(g);
            }
            ReCalcSize();
        }

        public override void Move(double x, double y)
        {
            base.Move(x, y);
            for (int i = 0; i < groupedShapes.Count; i++)
            {
                groupedShapes[i].Move(x, y);
            }
        }

        public override void Scale(int Width, int Height)
        {
            int diffWidth = getWidth() - Width;
            int diffHeight = getHeight() - Height;

            int minHeight = getY() - Height;
            int minWidth = getX() - Width;

            base.Scale(Width, Height);

            for (int i = 0; i < groupedShapes.Count; i++)
            {
                if (diffWidth != 0)
                {
                    if (groupedShapes[i].getX() > minWidth)
                    {
                        groupedShapes[i].Move(-diffWidth, 0);
                    }
                }
                else if (diffHeight != 0)
                {
                    if (groupedShapes[i].getY() - groupedShapes[i].getHeight() > minHeight)
                    {
                        groupedShapes[i].Move(0, -diffHeight);
                    }
                }
                groupedShapes[i].Scale(Math.Abs(groupedShapes[i].getWidth() - diffWidth), Math.Abs(groupedShapes[i].getHeight() - diffHeight));
            }
            ReCalcSize();
        }


        public override List<PointF> GetAllPoints()
        {
            List<PointF> Points = new List<PointF>();
            for (int i = 0; i < groupedShapes.Count; i++)
            {
                points.AddRange(groupedShapes[i].GetAllPoints());
            }
            return Points;
        }

        public void Ungroup()
        {
            foreach (var item in groupedShapes)
            {
                item.setGroupId(0);

                item.setX(item.getX() + getX() - center.X * Math.Cos(item.getAngle()));
                item.setY(item.getY() + getY() - center.Y * Math.Sin(item.getAngle()));

                item.RecalcCenter();
            }
            groupedShapes.Clear();
        } 

        public override Matrix Rotate(int angle, PointF[] Points, Point center)
        {
            Matrix result = new Matrix();
            center = new Point(getX() + getWidth() / 2, getY() + getHeight() / 2);

            for (int i = 0; i < groupedShapes.Count; i++)
            {
                PointF[] points = groupedShapes[i].GetAllPoints().ToArray();

                groupedShapes[i].setCenter(center);
                groupedShapes[i].setAngle(groupedShapes[i].getAngle() + angle);
            }
            return result;
        }

        public override bool Contains(PointF point)
        {
            foreach (var item in groupedShapes)
            {
                if (item.Contains(point)) return true;
            }
            return false;
        }

        public override ShapeTypeEnum GetShapeType()
        {
            return ShapeTypeEnum.GroupShape;
        }
    }
}
