using GUIProject.shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUIProject
{
    public abstract class Shape : IShape
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public Color c;
        public string name;
        public int angle;

        public int thickness { get; set; }
        public List<Point> Points = new List<Point>();
        
        public int groupId { get; set; }
        public Point center;

        public Shape(int X, int Y, Color C)
        {
            x = X; 
            y = Y;
            c = C;
            
        }
        public Shape()
        {
        }

        #region getters/setters
        public int getX() { return x; }
        public void setX(int X) { x = X; }

        public void setX(double X) { x = (int)X; }

        public int getY() { return y; }
        public void setY(int Y) { y = Y; }

        public void setY(double Y) { y = (int)Y; }

        public int getWidth() { return width; }
        public void setWidth(int Width) { width = Width; }

        public int getHeight() { return height; }
        public void setHeight(int Height) { height = Height; }

        public Color getColor() { return c; }
        public void setColor(Color C) { c = C; }

        public int getAngle() { return angle; }
        public void setAngle(int Angle) { angle = Angle; }

        public string getName() { return name; }
        public void setName(string Name) { name = Name; }
        #endregion

        #region methods
        public abstract void Draw(Graphics g);
        public abstract Matrix Rotate(Graphics g, int angle, PointF[] Points, Point center);
        public abstract List<PointF> GetAllPoints();
        public abstract bool Contains(PointF point);

        public virtual void RecalcCenter()
        {
            center = new Point(x + getWidth() / 2, y + getHeight() / 2);
        }

        public virtual void Move(double x, double y)
        {
            this.x -= (int)x;
            this.y -= (int)y;
        }
        public virtual void Scale(int Width, int Height)
        {
            width = Width;
            height = Height;
        }
       
        public abstract ShapeTypeEnum GetShapeType();

        public int getGroupId()
        {
            return groupId;
        }

        public void setGroupId(int groupId)
        {
            this.groupId = groupId;
        }

        public Point getCenter()
        {
            return center;
        }

        public void setCenter(Point Center)
        {
            center = Center;
        }

        public int getThickness()
        {
            return thickness;
        }

        public void setThickness(int Thickness)
        {
            thickness = Thickness;
        }
        #endregion
    }
}