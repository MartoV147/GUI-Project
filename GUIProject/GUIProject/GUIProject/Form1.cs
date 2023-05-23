using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using GUIProject.shapes;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace GUIProject
{
    public partial class KnockOffPhotoShop : Form
    {
        #region Variables 
        static Color paintColor = Color.FromArgb(255, 0, 0, 0);

        bool choose = false;
        bool draw = false;
        bool singleSelect = false;
        bool multSelect = false;

        string chosenLineWidth;

        int lineWidth = 1;
        int x, y, lx, ly = 0;
        int angle = 0;
        int selectedShapeIndex = 0;
        int counter = 0;

        long lastTick;

        Rectangle selectRec;

        Graphics g;

        public enum Tool
        {
            Draw, SingleSelect, MultipleSelect, Null
        }
        public enum Item
        {
            Rectangle, Ellipse, Line, Triangle, Point, GroupShape
        }
        public enum SelectChoice
        {
            SingleSelect, MultipleSelect
        }

        Tool chosenTool = Tool.Draw;
        Item chosenItem;

        public List<IShape> DrawnShapesDrawingBoard1 = new List<IShape>();
        public List<GroupShape> Groups = new List<GroupShape>();
        
        List<IShape> SelectedShapes = new List<IShape>();

        IShape SelectedShape;
        #endregion

        public KnockOffPhotoShop()
        {
            InitializeComponent();
        }

        #region Methods
        public void DrawAll(List<IShape> DrawnShapes, Graphics g)
        {
            g.Clear(Color.White);
            for (int i = 0; i < DrawnShapes.Count; i++)
            {
                DrawnShapes[i].Draw(g);
            }
        }

        private void KnockOffPhotoShop_SizeChanged(object sender, EventArgs e)
        {
            Graphics g = DrawingBoard1.CreateGraphics();
            DrawAll(DrawnShapesDrawingBoard1, g);
        }

        public bool DontFlicker()
        {
            var currentTick = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var tickDiff = currentTick - lastTick;
            if (tickDiff < 160)
            {
                return true;
            }
            lastTick = currentTick;
            return false;
        }

        public void ShowHideLabels(bool trigger)
        {
            X1Label.Visible = trigger;
            Y1Label.Visible = trigger;

            WidthLabel.Visible = !trigger;
            HeightLabel.Visible = !trigger;
        }

        private void ShowSelectedShapeProps()
        {
            XTBox.Text = SelectedShape.getX().ToString();
            YTBox.Text = SelectedShape.getY().ToString();
            AngleTBox.Text = SelectedShape.getAngle().ToString();
            ShapeNameTBox.Text = SelectedShape.getName();
            AngleTrackBar.Value = SelectedShape.getAngle();
            chosenColor.BackColor = SelectedShape.getColor();
            paintColor = SelectedShape.getColor();
            RSlideTracker.Value = SelectedShape.getColor().R;
            chosenColorRValue.Text = RSlideTracker.Value.ToString();
            GSlideTracker.Value = SelectedShape.getColor().G;
            chosenColorGValue.Text = GSlideTracker.Value.ToString();
            BSlideTracker.Value = SelectedShape.getColor().B;
            chosenColorBValue.Text = BSlideTracker.Value.ToString();
            ASlideTracker.Value = SelectedShape.getColor().A;
            chosenColorAValue.Text = ASlideTracker.Value.ToString();

            switch (SelectedShape.GetShapeType())
            {
                case ShapeTypeEnum.Rectangle:
                    {
                        ShowHideLabels(false);
                        WidthTBox.Text = ((Rectangle)SelectedShape).getWidth().ToString();
                        HeightTBox.Text = ((Rectangle)SelectedShape).getHeight().ToString();
                    }; break;
                case ShapeTypeEnum.Ellipse:
                    {
                        ShowHideLabels(false);
                        WidthTBox.Text = ((Ellipse)SelectedShape).getWidth().ToString();
                        HeightTBox.Text = ((Ellipse)SelectedShape).getHeight().ToString();
                    }; break;
                case ShapeTypeEnum.Line:
                    {
                        ShowHideLabels(true);
                        WidthTBox.Text = ((Line)SelectedShape).x1.ToString();
                        HeightTBox.Text = ((Line)SelectedShape).y1.ToString();
                    }; break;

                case ShapeTypeEnum.GroupShape:
                    {
                        ShowHideLabels(false);
                        WidthTBox.Text = ((GroupShape)SelectedShape).getWidth().ToString();
                        HeightTBox.Text = ((GroupShape)SelectedShape).getHeight().ToString();
                    }; break;
            }
        }

        public Shape CreateShape(int x1, int y1, int x2, int y2)
        {
            Shape shape = null;
            switch (chosenItem)
            {
                case Item.Rectangle: shape = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2- x1), Math.Abs(y2 - y1), paintColor); break;
                case Item.Ellipse: shape = new Ellipse(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1), paintColor); break;
                case Item.Line: shape = new Line(x1, y1, x2 - x1, y2 - y1, paintColor, lineWidth); break;
                case Item.Point: shape = new Ellipse(x1, y1, lineWidth, lineWidth, paintColor); break;
            }
            return shape;
        }

        public GroupShape SearchGroupsList(int id)
        {
            foreach (var item in Groups)
            {
                if (item.groupId == id) return item;
            }
            return null;
        }

        public void SetChosenItem(IShape shape)
        {
            switch (shape.GetShapeType())
            {
                case ShapeTypeEnum.Rectangle: chosenItem = Item.Rectangle; break;
                case ShapeTypeEnum.Ellipse: chosenItem = Item.Ellipse; break;
                case ShapeTypeEnum.Line: chosenItem = Item.Line; break;
            }
        }
        public void ClearTBoxes()
        {
            AngleTrackBar.Value = 0;
            AngleTBox.Text = "0";
            ShapeNameTBox.Text = "";
            XTBox.Text = "";
            YTBox.Text = "";
            WidthTBox.Text = "";
            HeightTBox.Text = "";
        }

        public void PickColor(int x, int y)
        {
            if (choose)
            {
                Bitmap bmp = (Bitmap)colorCircle.Image.Clone();
                try
                {
                    paintColor = bmp.GetPixel(x, y);
                }
                catch (ArgumentOutOfRangeException)
                {

                }

                RSlideTracker.Value = paintColor.R;
                chosenColorRValue.Text = RSlideTracker.Value.ToString();


                GSlideTracker.Value = paintColor.G;
                chosenColorGValue.Text = GSlideTracker.Value.ToString();


                BSlideTracker.Value = paintColor.B;
                chosenColorBValue.Text = BSlideTracker.Value.ToString();

                ASlideTracker.Value = paintColor.A;
                chosenColorAValue.Text = ASlideTracker.Value.ToString();

                chosenColor.BackColor = paintColor;
            }
        }
        #endregion

        #region Main Events
        private void DrawingBoard1_MouseDown(object sender, MouseEventArgs e)
        {
            if (chosenTool == Tool.Draw)
            {
                draw = true;
                singleSelect = false;
                multSelect = false;
            }

            if (chosenTool == Tool.SingleSelect)
            {
                draw = false;
                singleSelect = true;
                multSelect = false;
            }

            if (chosenTool == Tool.MultipleSelect)
            {
                draw = false;
                singleSelect = false;
                multSelect = true;
            }

            x = e.X;
            y = e.Y;
            lastTick = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        private void DrawingBoard1_MouseMove(object sender, MouseEventArgs e)
        {
            g = DrawingBoard1.CreateGraphics();
            if (DontFlicker()) return;

            lx = e.X;
            ly = e.Y;

            if (chosenTool == Tool.Draw && draw)
            {
                DrawAll(DrawnShapesDrawingBoard1, g);
                Shape shape = CreateShape(x, y, e.X, e.Y);
                shape.Draw(g);
            }
            if (chosenTool == Tool.MultipleSelect && multSelect)
            {
                g.Clear(Color.White);
                DrawAll(DrawnShapesDrawingBoard1, g);
                if (SelectedShape == null)
                {
                    selectRec = new Rectangle(x, y, Math.Abs(e.X - x), Math.Abs(e.Y - y), Color.FromArgb(50, 255, 0, 0));
                    selectRec.Draw(g);
                }
            }
            Invalidate();
        }

        private void DrawingBoard1_MouseUp(object sender, MouseEventArgs e)
        {
            g = DrawingBoard1.CreateGraphics();
            draw = false;
            singleSelect = false;
            multSelect = false;
            lx = e.X;
            ly = e.Y;

            if (chosenTool == Tool.Draw)
            {

                Shape shape = CreateShape(x, y, e.X, e.Y);
                DrawnShapesDrawingBoard1.Add(shape);
            }

            if (chosenTool == Tool.MultipleSelect)
            {
                selectRec = new Rectangle(x, y, Math.Abs(e.X - x), Math.Abs(e.Y - y), Color.FromArgb(0, 0, 0, 0));
                SelectedShapes = DrawnShapesDrawingBoard1.Where(s => s.GetAllPoints().All(p => selectRec.Contains(p))).ToList();
            }
            DrawAll(DrawnShapesDrawingBoard1, g);
        }

        private void DrawingBoard1_MouseClick(object sender, MouseEventArgs e)
        {
            g = DrawingBoard1.CreateGraphics();
            ClearTBoxes();
            if (chosenTool == Tool.SingleSelect)
            {
                SelectedShape = null;
                g.Clear(Color.White);
                for (int i = 0; i < DrawnShapesDrawingBoard1.Count; i++)
                {
                    if (DrawnShapesDrawingBoard1[i].Contains(new Point(e.X, e.Y)))
                    {
                        if (DrawnShapesDrawingBoard1[i].getGroupId() > 0)
                        {
                            SelectedShape = SearchGroupsList(DrawnShapesDrawingBoard1[i].getGroupId());
                        }
                        else
                        {
                            SelectedShape = DrawnShapesDrawingBoard1[i];
                            selectedShapeIndex = i;
                        }
                    }
                }

                if (SelectedShape != null)
                {
                    ShowSelectedShapeProps();
                    g.Clear(Color.White);
                    DrawAll(DrawnShapesDrawingBoard1, g);
                }
            }
        }
        #endregion

        #region Top Buttons
        private void DrawButton_Click(object sender, EventArgs e)
        {
            chosenTool = Tool.Draw;
            EditPanel.Visible = false;
            SearchPanel.Visible = false;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            chosenTool = Tool.SingleSelect;
            EditPanel.Visible = true;
            SearchPanel.Visible = false;
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            g = DrawingBoard1.CreateGraphics();
            if (SelectedShape != null)
            {
                SetChosenItem(SelectedShape);
                Shape copyShape = CreateShape(SelectedShape.getX(), SelectedShape.getY(), SelectedShape.getWidth() + SelectedShape.getX(), SelectedShape.getHeight() + SelectedShape.getY());
                copyShape.RecalcCenter();
                copyShape.setAngle(SelectedShape.getAngle());
                DrawnShapesDrawingBoard1.Add(copyShape);
                DrawAll(DrawnShapesDrawingBoard1, g);
                MessageBox.Show("Shape Copied Successfully :)");
            }
            else MessageBox.Show("No Shape is Selected :)");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            g = DrawingBoard1.CreateGraphics();
            if (SelectedShape == null)
            {
                MessageBox.Show("No Shape is Selected, bud ;)");
            }
            for (int i = 0; i < DrawnShapesDrawingBoard1.Count; i++)
            {
                if (SelectedShape == DrawnShapesDrawingBoard1[i])
                {
                    DrawnShapesDrawingBoard1.Remove(DrawnShapesDrawingBoard1[i]);
                }
            }
            SelectedShape = null;
            ClearTBoxes();
            DrawAll(DrawnShapesDrawingBoard1, g);
        }

        private void MultipleSelectButton_Click(object sender, EventArgs e)
        {
            chosenTool = Tool.MultipleSelect;
            SelectedShapes.Clear();
            EditPanel.Visible = false;
            SearchPanel.Visible = false;
            SelectedShape = null;
        }

        private void GroupBtn_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = false;
            GroupShape Group = new GroupShape(SelectedShapes);
            Group.groupId = counter + 1;
            foreach (var item in SelectedShapes)
            {
                item.setGroupId(Group.groupId);
            }
            counter++;
            Groups.Add(Group);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            var state = new FormStateContainer(this);
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            var jsonSave = JsonConvert.SerializeObject(state, settings);
            try
            {
                File.WriteAllText(dialog.FileName, jsonSave);
            }
            catch (Exception)
            {
            }
        }

        private void SaveAsPNGBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Convert.ToInt32(673), Convert.ToInt32(415), PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            DrawAll(DrawnShapesDrawingBoard1, g);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            try
            {
                bitmap.Save(dialog.FileName + ".png", ImageFormat.Png);
            }
            catch (Exception)
            {
            }

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            g = DrawingBoard1.CreateGraphics();
            DrawnShapesDrawingBoard1.Clear();
            SelectedShape = null;
            ClearTBoxes();
            Groups.Clear();
            SelectedShapes.Clear();
            g.Clear(Color.White);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Word in Progress, Loads only json files for now");

            g = DrawingBoard1.CreateGraphics();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog(); 

            try
            {
                var jsonLoad = File.ReadAllText(dialog.FileName);
                var settings = new JsonSerializerSettings
                {
                TypeNameHandling = TypeNameHandling.Auto
                };
                var state = JsonConvert.DeserializeObject<FormStateContainer>(jsonLoad, settings);

                Groups = state.Groups;
                DrawnShapesDrawingBoard1 = state.DrawnShapesDrawingBoard1;

                DrawAll(DrawnShapesDrawingBoard1, g);
            }
            catch (Exception)
            {
                MessageBox.Show("Ops, Something Went Wrong");
            }
            

        }

        private void UngroupBtn_Click(object sender, EventArgs e)
        {
            if (SelectedShape == null)
            {
                MessageBox.Show("No Shape is Selected, bud ;)");
                return;
            }
            if (SelectedShape.GetShapeType() != ShapeTypeEnum.GroupShape)
            {
                MessageBox.Show("The Selected Shape isn't a Group");
                return;
            }
            ((GroupShape)SelectedShape).Ungroup();
            Groups.Remove((GroupShape)SelectedShape);
            SelectedShape = null;
            ClearTBoxes();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
            SearchPanel.Visible = true;
        }
        #endregion

        #region Leftside Stuff
        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            Graphics g = DrawingBoard1.CreateGraphics();
            if (SelectedShape != null && int.Parse(WidthTBox.Text) > 0 && int.Parse(HeightTBox.Text) > 0)
            {
                try
                {
                    SelectedShape.Move(SelectedShape.getX() - int.Parse(XTBox.Text), SelectedShape.getY() - int.Parse(YTBox.Text));
                    SelectedShape.Scale(int.Parse(WidthTBox.Text), int.Parse(HeightTBox.Text));
                    SelectedShape.RecalcCenter();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Pretty Please, Write Valid Values :)");
                }
                SelectedShape.setColor(paintColor);
                SelectedShape.setThickness(lineWidth);
                SelectedShape.setName(ShapeNameTBox.Text);
                ShapeNameTBox.Text = "";
                XTBox.Text = "";
                YTBox.Text = "";
                WidthTBox.Text = "";
                HeightTBox.Text = "";

                DrawAll(DrawnShapesDrawingBoard1, g);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string shapeName = FindShapeByNameTBox.Text.ToString();

            for (int i = 0; i < DrawnShapesDrawingBoard1.Count; i++)
            {
                if (DrawnShapesDrawingBoard1[i].getName() == shapeName)
                {
                    SelectedShape = DrawnShapesDrawingBoard1[i];
                }
                break;
            }
            if (SelectedShape != null)
            {
                EditPanel.Visible = true;
                ShowSelectedShapeProps();
            }else MessageBox.Show("Sorry, I couldn't Find the Shape You Were Looking For T_T");

        }

        private void AngleTrackBar_Scroll(object sender, EventArgs e)
        {
            if (DontFlicker()) return;
            AngleTBox.Text = AngleTrackBar.Value.ToString();
            Graphics g = DrawingBoard1.CreateGraphics();
            angle = AngleTrackBar.Value;
            g.Clear(Color.White);
            if (SelectedShape != null && SelectedShape.GetShapeType() != ShapeTypeEnum.GroupShape)
            {
                SelectedShape.setAngle(angle);
            }
            if (SelectedShape != null && SelectedShape.GetShapeType() == ShapeTypeEnum.GroupShape)
            {
                PointF[] points = null;
                ((GroupShape)SelectedShape).Rotate(g, SelectedShape.getAngle() + angle, points, SelectedShape.getCenter());
            }

            DrawAll(DrawnShapesDrawingBoard1, g);
            angle = 0;
        }
        #endregion

        #region Shapes Buttons
        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            chosenItem = Item.Rectangle;
            label1.Visible = false;
            comboBox1.Visible = false;
        }
        private void LineBtn_Click(object sender, EventArgs e)
        {
            chosenItem = Item.Line;
            label1.Visible = true;
            comboBox1.Visible = true;
        }
        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            chosenItem = Item.Ellipse;
            label1.Visible = false;
            comboBox1.Visible = false;
        }
        private void PointBtn_Click(object sender, EventArgs e)
        {
            chosenItem = Item.Point;
            label1.Visible = true;
            comboBox1.Visible = true;
        }
        #endregion

        #region Line Width Change
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            chosenLineWidth = comboBox1.Text;
            switch (chosenLineWidth)
            {
                case "1 px": lineWidth = 1; break;
                case "3 px": lineWidth = 3; break;
                case "5 px": lineWidth = 5; break;
                case "8 px": lineWidth = 8; break;
            }
        }
        #endregion

        #region Color Select From The Color Range Pic
        private void colorCircle_MouseMove(object sender, MouseEventArgs e)
        {
            PickColor(e.X, e.Y);
        }

        private void colorCircle_MouseClick(object sender, MouseEventArgs e)
        {
            PickColor(e.X, e.Y);
        }

        private void colorCircle_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        private void colorCircle_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }
        #endregion

        #region ARGB Sliders
        private void RSlideTracker_Scroll(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(chosenColor.BackColor.A, RSlideTracker.Value, chosenColor.BackColor.G, chosenColor.BackColor.B);
            chosenColor.BackColor = c;
            chosenColorRValue.Text = RSlideTracker.Value.ToString();
            paintColor = c;
        }
        private void GSlideTracker_Scroll(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(chosenColor.BackColor.A, chosenColor.BackColor.R, GSlideTracker.Value, chosenColor.BackColor.B);
            chosenColor.BackColor = c;
            chosenColorGValue.Text = GSlideTracker.Value.ToString();
            paintColor = c;
        }
        private void BSlideTracker_Scroll(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(chosenColor.BackColor.A, chosenColor.BackColor.R, chosenColor.BackColor.G, BSlideTracker.Value);
            chosenColor.BackColor = c;
            chosenColorBValue.Text = BSlideTracker.Value.ToString();
            paintColor = c;
        }
        private void ASlideTracker_Scroll(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(ASlideTracker.Value, chosenColor.BackColor.R, chosenColor.BackColor.G, chosenColor.BackColor.B);
            chosenColor.BackColor = c;
            chosenColorAValue.Text = ASlideTracker.Value.ToString();
            paintColor = c;
        }
        #endregion
    }
}
