namespace Paint
{
    partial class Paint
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
        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Pen = new System.Windows.Forms.ToolStripButton();
            this.Brush = new System.Windows.Forms.ToolStripButton();
            this.Filling = new System.Windows.Forms.ToolStripButton();
            this.CurColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.RGB = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeBrush = new System.Windows.Forms.ToolStripComboBox();
            this.Intensity = new System.Windows.Forms.NumericUpDown();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.CurPoss = new System.Windows.Forms.ToolStripStatusLabel();
            this.DrawSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.usermenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawArea = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).BeginInit();
            this.Status.SuspendLayout();
            this.usermenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pen,
            this.Brush,
            this.Filling,
            this.CurColor,
            this.SizeBrush});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(784, 32);
            this.ToolBar.TabIndex = 0;
            // 
            // Pen
            // 
            this.Pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pen.Image = ((System.Drawing.Image)(resources.GetObject("Pen.Image")));
            this.Pen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(29, 29);
            this.Pen.Text = "Pen";
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // Brush
            // 
            this.Brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Brush.Image = ((System.Drawing.Image)(resources.GetObject("Brush.Image")));
            this.Brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(29, 29);
            this.Brush.Text = "Brush";
            this.Brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // Filling
            // 
            this.Filling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Filling.Image = ((System.Drawing.Image)(resources.GetObject("Filling.Image")));
            this.Filling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Filling.Name = "Filling";
            this.Filling.Size = new System.Drawing.Size(29, 29);
            this.Filling.Text = "Fill";
            this.Filling.Click += new System.EventHandler(this.Filling_Click);
            // 
            // CurColor
            // 
            this.CurColor.AutoSize = false;
            this.CurColor.BackColor = System.Drawing.Color.Blue;
            this.CurColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.CurColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem21,
            this.toolStripMenuItem2,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem18,
            this.toolStripMenuItem20,
            this.RGB});
            this.CurColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CurColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurColor.Name = "CurColor";
            this.CurColor.ShowDropDownArrow = false;
            this.CurColor.Size = new System.Drawing.Size(68, 22);
            this.CurColor.Text = "Color";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.AutoSize = false;
            this.toolStripMenuItem21.BackColor = System.Drawing.Color.Red;
            this.toolStripMenuItem21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.AutoSize = false;
            this.toolStripMenuItem22.BackColor = System.Drawing.Color.Lime;
            this.toolStripMenuItem22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.AutoSize = false;
            this.toolStripMenuItem23.BackColor = System.Drawing.Color.Blue;
            this.toolStripMenuItem23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.AutoSize = false;
            this.toolStripMenuItem24.BackColor = System.Drawing.Color.Yellow;
            this.toolStripMenuItem24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.AutoSize = false;
            this.toolStripMenuItem25.BackColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.AutoSize = false;
            this.toolStripMenuItem26.BackColor = System.Drawing.Color.Aqua;
            this.toolStripMenuItem26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.toolStripMenuItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AutoSize = false;
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.toolStripMenuItem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.AutoSize = false;
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.toolStripMenuItem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.AutoSize = false;
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(201)))));
            this.toolStripMenuItem8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.AutoSize = false;
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(39)))));
            this.toolStripMenuItem9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.AutoSize = false;
            this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(228)))), ((int)(((byte)(176)))));
            this.toolStripMenuItem12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.AutoSize = false;
            this.toolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.AutoSize = false;
            this.toolStripMenuItem14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(29)))));
            this.toolStripMenuItem14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.AutoSize = false;
            this.toolStripMenuItem15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.toolStripMenuItem15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.AutoSize = false;
            this.toolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.toolStripMenuItem16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.AutoSize = false;
            this.toolStripMenuItem18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.toolStripMenuItem18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(80, 20);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.AutoSize = false;
            this.toolStripMenuItem20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.toolStripMenuItem20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(80, 20);
            // 
            // RGB
            // 
            this.RGB.AutoSize = false;
            this.RGB.BackColor = System.Drawing.Color.White;
            this.RGB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RGB.BackgroundImage")));
            this.RGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RGB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RGB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RGB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RGB.Name = "RGB";
            this.RGB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RGB.Size = new System.Drawing.Size(65, 20);
            // 
            // SizeBrush
            // 
            this.SizeBrush.AutoSize = false;
            this.SizeBrush.DropDownHeight = 200;
            this.SizeBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeBrush.DropDownWidth = 25;
            this.SizeBrush.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SizeBrush.ForeColor = System.Drawing.Color.Black;
            this.SizeBrush.IntegralHeight = false;
            this.SizeBrush.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.SizeBrush.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SizeBrush.Name = "SizeBrush";
            this.SizeBrush.Size = new System.Drawing.Size(40, 23);
            this.SizeBrush.Tag = "";
            this.SizeBrush.ToolTipText = "Size";
            this.SizeBrush.SelectedIndexChanged += new System.EventHandler(this.SizeBrush_SelectedIndexChanged);
            // 
            // Intensity
            // 
            this.Intensity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Intensity.Location = new System.Drawing.Point(210, 3);
            this.Intensity.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.Intensity.Name = "Intensity";
            this.Intensity.Size = new System.Drawing.Size(45, 25);
            this.Intensity.TabIndex = 3;
            this.Intensity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Intensity.ValueChanged += new System.EventHandler(this.Intensity_ValueChanged);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurPoss,
            this.DrawSize});
            this.Status.Location = new System.Drawing.Point(0, 540);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(784, 22);
            this.Status.SizingGrip = false;
            this.Status.Stretch = false;
            this.Status.TabIndex = 1;
            // 
            // CurPoss
            // 
            this.CurPoss.AutoSize = false;
            this.CurPoss.Name = "CurPoss";
            this.CurPoss.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.CurPoss.Size = new System.Drawing.Size(60, 17);
            // 
            // DrawSize
            // 
            this.DrawSize.AutoSize = false;
            this.DrawSize.Margin = new System.Windows.Forms.Padding(200, 3, 0, 2);
            this.DrawSize.Name = "DrawSize";
            this.DrawSize.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.DrawSize.Size = new System.Drawing.Size(600, 17);
            // 
            // usermenu
            // 
            this.usermenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.usermenu.Location = new System.Drawing.Point(0, 0);
            this.usermenu.Name = "usermenu";
            this.usermenu.Size = new System.Drawing.Size(784, 24);
            this.usermenu.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Load,
            this.Save,
            this.Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(100, 22);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Load
            // 
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(100, 22);
            this.Load.Text = "Load";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DrawArea
            // 
            this.DrawArea.BackColor = System.Drawing.Color.White;
            this.DrawArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawArea.Location = new System.Drawing.Point(3, 3);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(750, 450);
            this.DrawArea.TabIndex = 2;
            this.DrawArea.TabStop = false;
            this.DrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseDown);
            this.DrawArea.MouseLeave += new System.EventHandler(this.DrawArea_MouseLeave);
            this.DrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseMove);
            this.DrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseUp);
            this.DrawArea.Resize += new System.EventHandler(this.DrawArea_Resize);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.DrawArea);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 484);
            this.panel.TabIndex = 4;
            // 
            // Paint
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(217)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.usermenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.usermenu;
            this.Name = "Paint";
            this.Text = "Paint";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Paint_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Paint_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Paint_KeyDown);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).EndInit();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.usermenu.ResumeLayout(false);
            this.usermenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolStrip ToolBar;
        public System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel CurPoss;
        private System.Windows.Forms.ToolStripStatusLabel DrawSize;
        private System.Windows.Forms.ToolStripButton Pen;
        private System.Windows.Forms.ToolStripButton Brush;
        private System.Windows.Forms.ToolStripButton Filling;
        private System.Windows.Forms.ToolStripComboBox SizeBrush;
        private System.Windows.Forms.ToolStripDropDownButton CurColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem RGB;
        private System.Windows.Forms.NumericUpDown Intensity;
        private System.Windows.Forms.MenuStrip usermenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Load;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        public System.Windows.Forms.PictureBox DrawArea;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripSplitButton Pattern;
        private System.Windows.Forms.ToolStripSplitButton Figures;
    }
}