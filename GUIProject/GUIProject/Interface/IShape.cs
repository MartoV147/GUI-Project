using GUIProject.shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIProject
{
    public interface IShape
    {
        int getX();
        void setX(int X);

        void setX(double X);

        int getY();
        void setY(int Y);

        void setY(double Y);

        int getWidth();
        void setWidth(int Width);

        int getHeight();
        void setHeight(int Height);

        Color getColor();
        void setColor(Color C);

        int getAngle();
        void setAngle(int Angle);

        string getName();
        void setName(string Name);

        int getGroupId();
        void setGroupId(int groupId);

        Point getCenter();
        void setCenter(Point Center);

        int getThickness();
        void setThickness(int Thickness);


        void Draw(Graphics g);
        Matrix Rotate(int angle, PointF[] Points, Point center);
        List<PointF> GetAllPoints();
        bool Contains(PointF point);

        void RecalcCenter();

        void Move(double x, double y);

        void Scale(int Width, int Height);

       ShapeTypeEnum GetShapeType();
    }
}