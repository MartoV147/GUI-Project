using System.Windows.Forms;

namespace GUIProject
{
    partial class KnockOffPhotoShop
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnockOffPhotoShop));
            this.colorCircle = new System.Windows.Forms.PictureBox();
            this.RSlideTracker = new System.Windows.Forms.TrackBar();
            this.GSlideTracker = new System.Windows.Forms.TrackBar();
            this.BSlideTracker = new System.Windows.Forms.TrackBar();
            this.rSlider = new System.Windows.Forms.Label();
            this.gSlider = new System.Windows.Forms.Label();
            this.bSlider = new System.Windows.Forms.Label();
            this.aSlider = new System.Windows.Forms.Label();
            this.ASlideTracker = new System.Windows.Forms.TrackBar();
            this.chosenColor = new System.Windows.Forms.PictureBox();
            this.chosenColorRValue = new System.Windows.Forms.TextBox();
            this.chosenColorGValue = new System.Windows.Forms.TextBox();
            this.chosenColorBValue = new System.Windows.Forms.TextBox();
            this.chosenColorAValue = new System.Windows.Forms.TextBox();
            this.AngleTrackBar = new System.Windows.Forms.TrackBar();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.EllipseBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PointBtn = new System.Windows.Forms.Button();
            this.MultipleSelectLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AngleTBox = new System.Windows.Forms.TextBox();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShapeNameTBox = new System.Windows.Forms.TextBox();
            this.XTBox = new System.Windows.Forms.TextBox();
            this.YTBox = new System.Windows.Forms.TextBox();
            this.HeightTBox = new System.Windows.Forms.TextBox();
            this.WidthTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.MultipleSelectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.X1Label = new System.Windows.Forms.Label();
            this.Y1Label = new System.Windows.Forms.Label();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.FindBtn = new System.Windows.Forms.Button();
            this.FindShapeByNameTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.UngroupBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.DrawingBoard1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.SaveAsPNGBtn = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label23 = new System.Windows.Forms.Label();
            this.NewWindowBtn = new System.Windows.Forms.Button();
            this.EnvelopeBtn = new System.Windows.Forms.Button();
            this.StarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSlideTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSlideTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSlideTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASlideTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleTrackBar)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBoard1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorCircle
            // 
            this.colorCircle.BackColor = System.Drawing.Color.AliceBlue;
            this.colorCircle.Image = ((System.Drawing.Image)(resources.GetObject("colorCircle.Image")));
            this.colorCircle.Location = new System.Drawing.Point(1096, 87);
            this.colorCircle.Name = "colorCircle";
            this.colorCircle.Size = new System.Drawing.Size(198, 191);
            this.colorCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.colorCircle.TabIndex = 1;
            this.colorCircle.TabStop = false;
            this.colorCircle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorCircle_MouseClick);
            this.colorCircle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorCircle_MouseDown);
            this.colorCircle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorCircle_MouseMove);
            this.colorCircle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorCircle_MouseUp);
            // 
            // RSlideTracker
            // 
            this.RSlideTracker.LargeChange = 1;
            this.RSlideTracker.Location = new System.Drawing.Point(1004, 289);
            this.RSlideTracker.Maximum = 255;
            this.RSlideTracker.Name = "RSlideTracker";
            this.RSlideTracker.Size = new System.Drawing.Size(206, 45);
            this.RSlideTracker.TabIndex = 2;
            this.RSlideTracker.Scroll += new System.EventHandler(this.RSlideTracker_Scroll);
            this.RSlideTracker.ValueChanged += new System.EventHandler(this.RSlideTracker_Scroll);
            // 
            // GSlideTracker
            // 
            this.GSlideTracker.LargeChange = 1;
            this.GSlideTracker.Location = new System.Drawing.Point(1004, 325);
            this.GSlideTracker.Maximum = 255;
            this.GSlideTracker.Name = "GSlideTracker";
            this.GSlideTracker.Size = new System.Drawing.Size(206, 45);
            this.GSlideTracker.TabIndex = 3;
            this.GSlideTracker.Scroll += new System.EventHandler(this.GSlideTracker_Scroll);
            // 
            // BSlideTracker
            // 
            this.BSlideTracker.LargeChange = 1;
            this.BSlideTracker.Location = new System.Drawing.Point(1004, 363);
            this.BSlideTracker.Maximum = 255;
            this.BSlideTracker.Name = "BSlideTracker";
            this.BSlideTracker.Size = new System.Drawing.Size(206, 45);
            this.BSlideTracker.TabIndex = 4;
            this.BSlideTracker.Scroll += new System.EventHandler(this.BSlideTracker_Scroll);
            // 
            // rSlider
            // 
            this.rSlider.AutoSize = true;
            this.rSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rSlider.ForeColor = System.Drawing.Color.White;
            this.rSlider.Location = new System.Drawing.Point(983, 292);
            this.rSlider.Name = "rSlider";
            this.rSlider.Size = new System.Drawing.Size(28, 22);
            this.rSlider.TabIndex = 5;
            this.rSlider.Text = "R:";
            // 
            // gSlider
            // 
            this.gSlider.AutoSize = true;
            this.gSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gSlider.ForeColor = System.Drawing.Color.White;
            this.gSlider.Location = new System.Drawing.Point(983, 330);
            this.gSlider.Name = "gSlider";
            this.gSlider.Size = new System.Drawing.Size(29, 22);
            this.gSlider.TabIndex = 6;
            this.gSlider.Text = "G:";
            // 
            // bSlider
            // 
            this.bSlider.AutoSize = true;
            this.bSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bSlider.ForeColor = System.Drawing.Color.White;
            this.bSlider.Location = new System.Drawing.Point(983, 368);
            this.bSlider.Name = "bSlider";
            this.bSlider.Size = new System.Drawing.Size(27, 22);
            this.bSlider.TabIndex = 7;
            this.bSlider.Text = "B:";
            // 
            // aSlider
            // 
            this.aSlider.AutoSize = true;
            this.aSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aSlider.ForeColor = System.Drawing.Color.White;
            this.aSlider.Location = new System.Drawing.Point(983, 408);
            this.aSlider.Name = "aSlider";
            this.aSlider.Size = new System.Drawing.Size(27, 22);
            this.aSlider.TabIndex = 9;
            this.aSlider.Text = "A:";
            // 
            // ASlideTracker
            // 
            this.ASlideTracker.LargeChange = 1;
            this.ASlideTracker.Location = new System.Drawing.Point(1004, 403);
            this.ASlideTracker.Maximum = 255;
            this.ASlideTracker.Name = "ASlideTracker";
            this.ASlideTracker.Size = new System.Drawing.Size(206, 45);
            this.ASlideTracker.TabIndex = 8;
            this.ASlideTracker.Value = 255;
            this.ASlideTracker.Scroll += new System.EventHandler(this.ASlideTracker_Scroll);
            // 
            // chosenColor
            // 
            this.chosenColor.BackColor = System.Drawing.Color.Black;
            this.chosenColor.Location = new System.Drawing.Point(3, 3);
            this.chosenColor.Name = "chosenColor";
            this.chosenColor.Size = new System.Drawing.Size(104, 69);
            this.chosenColor.TabIndex = 10;
            this.chosenColor.TabStop = false;
            // 
            // chosenColorRValue
            // 
            this.chosenColorRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chosenColorRValue.Location = new System.Drawing.Point(1234, 289);
            this.chosenColorRValue.Name = "chosenColorRValue";
            this.chosenColorRValue.ReadOnly = true;
            this.chosenColorRValue.Size = new System.Drawing.Size(60, 27);
            this.chosenColorRValue.TabIndex = 11;
            this.chosenColorRValue.Text = "0";
            // 
            // chosenColorGValue
            // 
            this.chosenColorGValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chosenColorGValue.Location = new System.Drawing.Point(1234, 327);
            this.chosenColorGValue.Name = "chosenColorGValue";
            this.chosenColorGValue.ReadOnly = true;
            this.chosenColorGValue.Size = new System.Drawing.Size(60, 27);
            this.chosenColorGValue.TabIndex = 12;
            this.chosenColorGValue.Text = "0";
            // 
            // chosenColorBValue
            // 
            this.chosenColorBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chosenColorBValue.Location = new System.Drawing.Point(1234, 365);
            this.chosenColorBValue.Name = "chosenColorBValue";
            this.chosenColorBValue.ReadOnly = true;
            this.chosenColorBValue.Size = new System.Drawing.Size(60, 27);
            this.chosenColorBValue.TabIndex = 13;
            this.chosenColorBValue.Text = "0";
            // 
            // chosenColorAValue
            // 
            this.chosenColorAValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chosenColorAValue.Location = new System.Drawing.Point(1234, 405);
            this.chosenColorAValue.Name = "chosenColorAValue";
            this.chosenColorAValue.ReadOnly = true;
            this.chosenColorAValue.Size = new System.Drawing.Size(60, 27);
            this.chosenColorAValue.TabIndex = 14;
            this.chosenColorAValue.Text = "255";
            // 
            // AngleTrackBar
            // 
            this.AngleTrackBar.LargeChange = 1;
            this.AngleTrackBar.Location = new System.Drawing.Point(10, 200);
            this.AngleTrackBar.Maximum = 360;
            this.AngleTrackBar.Name = "AngleTrackBar";
            this.AngleTrackBar.Size = new System.Drawing.Size(227, 45);
            this.AngleTrackBar.TabIndex = 16;
            this.AngleTrackBar.Scroll += new System.EventHandler(this.AngleTrackBar_Scroll);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.BackColor = System.Drawing.Color.White;
            this.RectangleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RectangleBtn.BackgroundImage")));
            this.RectangleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleBtn.Location = new System.Drawing.Point(1096, 37);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(45, 45);
            this.RectangleBtn.TabIndex = 19;
            this.RectangleBtn.UseVisualStyleBackColor = false;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.BackColor = System.Drawing.Color.White;
            this.EllipseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EllipseBtn.BackgroundImage")));
            this.EllipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EllipseBtn.Location = new System.Drawing.Point(1147, 36);
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(45, 45);
            this.EllipseBtn.TabIndex = 20;
            this.EllipseBtn.UseVisualStyleBackColor = false;
            this.EllipseBtn.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.BackColor = System.Drawing.Color.White;
            this.LineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineBtn.BackgroundImage")));
            this.LineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineBtn.Location = new System.Drawing.Point(1198, 37);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(45, 45);
            this.LineBtn.TabIndex = 21;
            this.LineBtn.UseVisualStyleBackColor = false;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.Color.White;
            this.DrawButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawButton.BackgroundImage")));
            this.DrawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DrawButton.Location = new System.Drawing.Point(291, 36);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(45, 45);
            this.DrawButton.TabIndex = 22;
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.White;
            this.SelectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectButton.BackgroundImage")));
            this.SelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectButton.Location = new System.Drawing.Point(342, 36);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(45, 45);
            this.SelectButton.TabIndex = 23;
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 px",
            "3 px",
            "5 px",
            "8 px"});
            this.comboBox1.Location = new System.Drawing.Point(986, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(990, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Line Width:";
            this.label1.Visible = false;
            // 
            // PointBtn
            // 
            this.PointBtn.BackColor = System.Drawing.Color.White;
            this.PointBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PointBtn.BackgroundImage")));
            this.PointBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PointBtn.Location = new System.Drawing.Point(1249, 36);
            this.PointBtn.Name = "PointBtn";
            this.PointBtn.Size = new System.Drawing.Size(45, 45);
            this.PointBtn.TabIndex = 26;
            this.PointBtn.UseVisualStyleBackColor = false;
            this.PointBtn.Click += new System.EventHandler(this.PointBtn_Click);
            // 
            // MultipleSelectLabel
            // 
            this.MultipleSelectLabel.AutoSize = true;
            this.MultipleSelectLabel.Location = new System.Drawing.Point(405, 11);
            this.MultipleSelectLabel.Name = "MultipleSelectLabel";
            this.MultipleSelectLabel.Size = new System.Drawing.Size(0, 13);
            this.MultipleSelectLabel.TabIndex = 30;
            this.MultipleSelectLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Rotate Shape:";
            // 
            // AngleTBox
            // 
            this.AngleTBox.BackColor = System.Drawing.SystemColors.Control;
            this.AngleTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.AngleTBox.Location = new System.Drawing.Point(244, 192);
            this.AngleTBox.Name = "AngleTBox";
            this.AngleTBox.ReadOnly = true;
            this.AngleTBox.Size = new System.Drawing.Size(39, 27);
            this.AngleTBox.TabIndex = 32;
            this.AngleTBox.Text = "0";
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SaveChangesBtn.Location = new System.Drawing.Point(10, 252);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(273, 46);
            this.SaveChangesBtn.TabIndex = 33;
            this.SaveChangesBtn.Text = "Save Changes";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Shape Name:";
            // 
            // ShapeNameTBox
            // 
            this.ShapeNameTBox.BackColor = System.Drawing.SystemColors.Control;
            this.ShapeNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ShapeNameTBox.Location = new System.Drawing.Point(135, 4);
            this.ShapeNameTBox.Name = "ShapeNameTBox";
            this.ShapeNameTBox.Size = new System.Drawing.Size(148, 27);
            this.ShapeNameTBox.TabIndex = 35;
            // 
            // XTBox
            // 
            this.XTBox.BackColor = System.Drawing.SystemColors.Control;
            this.XTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.XTBox.Location = new System.Drawing.Point(135, 38);
            this.XTBox.Name = "XTBox";
            this.XTBox.Size = new System.Drawing.Size(148, 27);
            this.XTBox.TabIndex = 36;
            // 
            // YTBox
            // 
            this.YTBox.BackColor = System.Drawing.SystemColors.Control;
            this.YTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.YTBox.Location = new System.Drawing.Point(135, 71);
            this.YTBox.Name = "YTBox";
            this.YTBox.Size = new System.Drawing.Size(148, 27);
            this.YTBox.TabIndex = 37;
            // 
            // HeightTBox
            // 
            this.HeightTBox.BackColor = System.Drawing.SystemColors.Control;
            this.HeightTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.HeightTBox.Location = new System.Drawing.Point(135, 137);
            this.HeightTBox.Name = "HeightTBox";
            this.HeightTBox.Size = new System.Drawing.Size(148, 27);
            this.HeightTBox.TabIndex = 39;
            // 
            // WidthTBox
            // 
            this.WidthTBox.BackColor = System.Drawing.SystemColors.Control;
            this.WidthTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.WidthTBox.Location = new System.Drawing.Point(135, 104);
            this.WidthTBox.Name = "WidthTBox";
            this.WidthTBox.Size = new System.Drawing.Size(148, 27);
            this.WidthTBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Shape X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Shape Y:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(10, 140);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(124, 22);
            this.HeightLabel.TabIndex = 43;
            this.HeightLabel.Text = "Shape Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.WidthLabel.ForeColor = System.Drawing.Color.White;
            this.WidthLabel.Location = new System.Drawing.Point(10, 107);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(118, 22);
            this.WidthLabel.TabIndex = 42;
            this.WidthLabel.Text = "Shape Width:";
            // 
            // MultipleSelectButton
            // 
            this.MultipleSelectButton.BackColor = System.Drawing.Color.White;
            this.MultipleSelectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MultipleSelectButton.BackgroundImage")));
            this.MultipleSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MultipleSelectButton.Location = new System.Drawing.Point(557, 36);
            this.MultipleSelectButton.Name = "MultipleSelectButton";
            this.MultipleSelectButton.Size = new System.Drawing.Size(45, 45);
            this.MultipleSelectButton.TabIndex = 44;
            this.MultipleSelectButton.UseVisualStyleBackColor = false;
            this.MultipleSelectButton.Click += new System.EventHandler(this.MultipleSelectButton_Click);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(339, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 31);
            this.label9.TabIndex = 46;
            this.label9.Text = "Single Select";
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(554, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 31);
            this.label10.TabIndex = 47;
            this.label10.Text = "Multiple Select + Group Shapes";
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1093, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Rectangle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1151, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Ellipse";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1202, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "_____";
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1255, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Dot";
            // 
            // X1Label
            // 
            this.X1Label.AutoSize = true;
            this.X1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.X1Label.ForeColor = System.Drawing.Color.White;
            this.X1Label.Location = new System.Drawing.Point(10, 107);
            this.X1Label.Name = "X1Label";
            this.X1Label.Size = new System.Drawing.Size(94, 22);
            this.X1Label.TabIndex = 52;
            this.X1Label.Text = "Shape X1:";
            this.X1Label.Visible = false;
            // 
            // Y1Label
            // 
            this.Y1Label.AutoSize = true;
            this.Y1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Y1Label.ForeColor = System.Drawing.Color.White;
            this.Y1Label.Location = new System.Drawing.Point(10, 140);
            this.Y1Label.Name = "Y1Label";
            this.Y1Label.Size = new System.Drawing.Size(94, 22);
            this.Y1Label.TabIndex = 53;
            this.Y1Label.Text = "Shape Y1:";
            this.Y1Label.Visible = false;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.Y1Label);
            this.EditPanel.Controls.Add(this.X1Label);
            this.EditPanel.Controls.Add(this.HeightLabel);
            this.EditPanel.Controls.Add(this.WidthLabel);
            this.EditPanel.Controls.Add(this.label5);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.HeightTBox);
            this.EditPanel.Controls.Add(this.WidthTBox);
            this.EditPanel.Controls.Add(this.YTBox);
            this.EditPanel.Controls.Add(this.XTBox);
            this.EditPanel.Controls.Add(this.ShapeNameTBox);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.SaveChangesBtn);
            this.EditPanel.Controls.Add(this.AngleTBox);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.AngleTrackBar);
            this.EditPanel.Location = new System.Drawing.Point(-1, 84);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(286, 301);
            this.EditPanel.TabIndex = 54;
            this.EditPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chosenColor);
            this.panel2.Location = new System.Drawing.Point(983, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 77);
            this.panel2.TabIndex = 56;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.FindBtn);
            this.SearchPanel.Controls.Add(this.FindShapeByNameTBox);
            this.SearchPanel.Controls.Add(this.label6);
            this.SearchPanel.Location = new System.Drawing.Point(3, 391);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(282, 122);
            this.SearchPanel.TabIndex = 57;
            this.SearchPanel.Visible = false;
            // 
            // FindBtn
            // 
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.FindBtn.Location = new System.Drawing.Point(10, 66);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(273, 46);
            this.FindBtn.TabIndex = 54;
            this.FindBtn.Text = "Find Shape";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // FindShapeByNameTBox
            // 
            this.FindShapeByNameTBox.BackColor = System.Drawing.SystemColors.Control;
            this.FindShapeByNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.FindShapeByNameTBox.Location = new System.Drawing.Point(10, 32);
            this.FindShapeByNameTBox.Name = "FindShapeByNameTBox";
            this.FindShapeByNameTBox.Size = new System.Drawing.Size(273, 27);
            this.FindShapeByNameTBox.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Insert Shape Name:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.White;
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.Location = new System.Drawing.Point(393, 36);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(45, 45);
            this.SearchBtn.TabIndex = 58;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(390, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 31);
            this.label7.TabIndex = 59;
            this.label7.Text = "Find Shape";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(288, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 31);
            this.label8.TabIndex = 60;
            this.label8.Text = "Draw Shape";
            // 
            // GroupBtn
            // 
            this.GroupBtn.BackColor = System.Drawing.Color.White;
            this.GroupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroupBtn.BackgroundImage")));
            this.GroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GroupBtn.Location = new System.Drawing.Point(608, 36);
            this.GroupBtn.Name = "GroupBtn";
            this.GroupBtn.Size = new System.Drawing.Size(45, 45);
            this.GroupBtn.TabIndex = 61;
            this.GroupBtn.UseVisualStyleBackColor = false;
            this.GroupBtn.Click += new System.EventHandler(this.GroupBtn_Click);
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(656, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 31);
            this.label16.TabIndex = 64;
            this.label16.Text = "Ungroup Shapes";
            // 
            // UngroupBtn
            // 
            this.UngroupBtn.BackColor = System.Drawing.Color.White;
            this.UngroupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UngroupBtn.BackgroundImage")));
            this.UngroupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UngroupBtn.Location = new System.Drawing.Point(659, 35);
            this.UngroupBtn.Name = "UngroupBtn";
            this.UngroupBtn.Size = new System.Drawing.Size(45, 45);
            this.UngroupBtn.TabIndex = 63;
            this.UngroupBtn.UseVisualStyleBackColor = false;
            this.UngroupBtn.Click += new System.EventHandler(this.UngroupBtn_Click);
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1, -1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 31);
            this.label17.TabIndex = 68;
            this.label17.Text = "Copy Shape";
            // 
            // label18
            // 
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(52, -1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 31);
            this.label18.TabIndex = 67;
            this.label18.Text = "Delete Shape";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteBtn.Location = new System.Drawing.Point(55, 34);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(45, 45);
            this.DeleteBtn.TabIndex = 66;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.BackColor = System.Drawing.Color.White;
            this.CopyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CopyBtn.BackgroundImage")));
            this.CopyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyBtn.Location = new System.Drawing.Point(4, 34);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(45, 45);
            this.CopyBtn.TabIndex = 65;
            this.CopyBtn.UseVisualStyleBackColor = false;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.CopyBtn);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(444, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 80);
            this.panel3.TabIndex = 69;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveBtn.Location = new System.Drawing.Point(9, 36);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(45, 45);
            this.SaveBtn.TabIndex = 70;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 31);
            this.label15.TabIndex = 71;
            this.label15.Text = "Save Image";
            // 
            // label19
            // 
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(108, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 31);
            this.label19.TabIndex = 73;
            this.label19.Text = "Load Image";
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadBtn.BackgroundImage")));
            this.LoadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadBtn.Location = new System.Drawing.Point(111, 37);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(45, 45);
            this.LoadBtn.TabIndex = 72;
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(979, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 46);
            this.label20.TabIndex = 74;
            this.label20.Text = "Chosen Color:";
            // 
            // DrawingBoard1
            // 
            this.DrawingBoard1.BackColor = System.Drawing.Color.White;
            this.DrawingBoard1.Location = new System.Drawing.Point(291, 88);
            this.DrawingBoard1.Name = "DrawingBoard1";
            this.DrawingBoard1.Size = new System.Drawing.Size(686, 415);
            this.DrawingBoard1.TabIndex = 75;
            this.DrawingBoard1.TabStop = false;
            this.DrawingBoard1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingBoard1_Paint);
            this.DrawingBoard1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard1_MouseClick);
            this.DrawingBoard1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard1_MouseDown);
            this.DrawingBoard1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard1_MouseMove);
            this.DrawingBoard1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard1_MouseUp);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(159, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 31);
            this.label21.TabIndex = 77;
            this.label21.Text = "Clear Project";
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.Color.White;
            this.NewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewBtn.BackgroundImage")));
            this.NewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewBtn.Location = new System.Drawing.Point(162, 38);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(45, 45);
            this.NewBtn.TabIndex = 76;
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(57, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 31);
            this.label22.TabIndex = 79;
            this.label22.Text = "Save as PNG";
            // 
            // SaveAsPNGBtn
            // 
            this.SaveAsPNGBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveAsPNGBtn.BackgroundImage")));
            this.SaveAsPNGBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveAsPNGBtn.Location = new System.Drawing.Point(60, 36);
            this.SaveAsPNGBtn.Name = "SaveAsPNGBtn";
            this.SaveAsPNGBtn.Size = new System.Drawing.Size(45, 45);
            this.SaveAsPNGBtn.TabIndex = 78;
            this.SaveAsPNGBtn.UseVisualStyleBackColor = true;
            this.SaveAsPNGBtn.Click += new System.EventHandler(this.SaveAsPNGBtn_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(292, 485);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(685, 17);
            this.hScrollBar1.TabIndex = 80;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(210, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 31);
            this.label23.TabIndex = 82;
            this.label23.Text = "New Window";
            // 
            // NewWindowBtn
            // 
            this.NewWindowBtn.BackColor = System.Drawing.Color.White;
            this.NewWindowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewWindowBtn.BackgroundImage")));
            this.NewWindowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewWindowBtn.Location = new System.Drawing.Point(213, 38);
            this.NewWindowBtn.Name = "NewWindowBtn";
            this.NewWindowBtn.Size = new System.Drawing.Size(45, 45);
            this.NewWindowBtn.TabIndex = 81;
            this.NewWindowBtn.UseVisualStyleBackColor = false;
            this.NewWindowBtn.Click += new System.EventHandler(this.NewWindowBtn_Click);
            // 
            // EnvelopeBtn
            // 
            this.EnvelopeBtn.Location = new System.Drawing.Point(1039, 38);
            this.EnvelopeBtn.Name = "EnvelopeBtn";
            this.EnvelopeBtn.Size = new System.Drawing.Size(50, 41);
            this.EnvelopeBtn.TabIndex = 83;
            this.EnvelopeBtn.UseVisualStyleBackColor = true;
            this.EnvelopeBtn.Click += new System.EventHandler(this.EnvelopeBtn_Click);
            // 
            // StarBtn
            // 
            this.StarBtn.Location = new System.Drawing.Point(983, 38);
            this.StarBtn.Name = "StarBtn";
            this.StarBtn.Size = new System.Drawing.Size(50, 41);
            this.StarBtn.TabIndex = 84;
            this.StarBtn.Text = "Patric";
            this.StarBtn.UseVisualStyleBackColor = true;
            this.StarBtn.Click += new System.EventHandler(this.StarBtn_Click);
            // 
            // KnockOffPhotoShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 509);
            this.Controls.Add(this.StarBtn);
            this.Controls.Add(this.EnvelopeBtn);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.NewWindowBtn);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.SaveAsPNGBtn);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.DrawingBoard1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.UngroupBtn);
            this.Controls.Add(this.GroupBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MultipleSelectButton);
            this.Controls.Add(this.MultipleSelectLabel);
            this.Controls.Add(this.PointBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.LineBtn);
            this.Controls.Add(this.EllipseBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.chosenColorAValue);
            this.Controls.Add(this.chosenColorBValue);
            this.Controls.Add(this.chosenColorGValue);
            this.Controls.Add(this.chosenColorRValue);
            this.Controls.Add(this.aSlider);
            this.Controls.Add(this.ASlideTracker);
            this.Controls.Add(this.bSlider);
            this.Controls.Add(this.gSlider);
            this.Controls.Add(this.rSlider);
            this.Controls.Add(this.BSlideTracker);
            this.Controls.Add(this.GSlideTracker);
            this.Controls.Add(this.RSlideTracker);
            this.Controls.Add(this.colorCircle);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnockOffPhotoShop";
            this.Text = "KnockOffPhotoShop";
            this.SizeChanged += new System.EventHandler(this.KnockOffPhotoShop_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.colorCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSlideTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSlideTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSlideTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASlideTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chosenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleTrackBar)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBoard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox colorCircle;
        private System.Windows.Forms.TrackBar RSlideTracker;
        private System.Windows.Forms.TrackBar GSlideTracker;
        private System.Windows.Forms.TrackBar BSlideTracker;
        private System.Windows.Forms.Label rSlider;
        private System.Windows.Forms.Label gSlider;
        private System.Windows.Forms.Label bSlider;
        private System.Windows.Forms.Label aSlider;
        private System.Windows.Forms.TrackBar ASlideTracker;
        private System.Windows.Forms.PictureBox chosenColor;
        private System.Windows.Forms.TextBox chosenColorRValue;
        private System.Windows.Forms.TextBox chosenColorGValue;
        private System.Windows.Forms.TextBox chosenColorBValue;
        private System.Windows.Forms.TextBox chosenColorAValue;
        private System.Windows.Forms.TrackBar AngleTrackBar;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button EllipseBtn;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PointBtn;
        private System.Windows.Forms.Label MultipleSelectLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AngleTBox;
        private System.Windows.Forms.Button SaveChangesBtn;
        private Label label3;
        private TextBox ShapeNameTBox;
        private TextBox XTBox;
        private TextBox YTBox;
        private TextBox HeightTBox;
        private TextBox WidthTBox;
        private Label label4;
        private Label label5;
        private Label HeightLabel;
        private Label WidthLabel;
        private Button MultipleSelectButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label X1Label;
        private Label Y1Label;
        private Panel EditPanel;
        private Panel panel2;
        private Panel SearchPanel;
        private TextBox FindShapeByNameTBox;
        private Label label6;
        private Button FindBtn;
        private Button SearchBtn;
        private Label label7;
        private Label label8;
        private Button GroupBtn;
        private Label label16;
        private Button UngroupBtn;
        private Label label17;
        private Label label18;
        private Button DeleteBtn;
        private Button CopyBtn;
        private Panel panel3;
        private Button SaveBtn;
        private Label label15;
        private Label label19;
        private Button LoadBtn;
        private Label label20;
        private PictureBox DrawingBoard1;
        private Label label21;
        private Button NewBtn;
        private Label label22;
        private Button SaveAsPNGBtn;
        private HScrollBar hScrollBar1;
        private Label label23;
        private Button NewWindowBtn;
        private Button EnvelopeBtn;
        private Button StarBtn;
    }
}

