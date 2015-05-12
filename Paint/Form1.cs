using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
namespace Paint
{
    public struct IconInfo
    {
        public bool fIcon;
        public int xHotspot;
        public int yHotspot;
        public IntPtr hbmMask;
        public IntPtr hbmColor;
    }
    public partial class Paint : Form
    {
        Label[] lbl = new Label[3];//Для растягивания окна рисовки
        bool dragging = false;
        bool MouseDownDrawArea = false;
        Graphics g;
        Point prevLocMouse;
        public int SizePen = 10;
        Pen PEN;
        ArrayList curs = new ArrayList();
        String CurTool;
        int x = 0, y = 0;
        public Bitmap bufer;
        Graphics Contour, DrawArea_G;
        ArrayList points = new ArrayList();
        public Paint()
        {
            InitializeComponent();
            Cursor[] arrArrow = new Cursor[] { Cursors.SizeWE, Cursors.SizeNWSE, Cursors.SizeNS };
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i] = new Label();
                lbl[i].TabIndex = i;
                lbl[i].FlatStyle = 0;
                lbl[i].BorderStyle = BorderStyle.FixedSingle;
                lbl[i].BackColor = Color.White;//BoxColor
                lbl[i].Cursor = arrArrow[i];
                lbl[i].Text = "";
                lbl[i].BringToFront();
                lbl[i].MouseDown += new MouseEventHandler(this.lbl_MouseDown);
                lbl[i].MouseMove += new MouseEventHandler(this.lbl_MouseMove);
                lbl[i].MouseUp += new MouseEventHandler(this.lbl_MouseUp);
                lbl[i].Size = new Size(5, 5);
                this.panel.Controls.Add(lbl[i]);
            }
            lbl[0].Location = new Point(DrawArea.Right, DrawArea.Height / 2 + DrawArea.Top);
            lbl[1].Location = new Point(DrawArea.Right, DrawArea.Bottom);
            lbl[2].Location = new Point(DrawArea.Width / 2 + DrawArea.Left, DrawArea.Bottom);
            Status.Items["DrawSize"].Text = DrawArea.Size.Width + " x " + DrawArea.Size.Height;
            DrawArea.Image = new Bitmap(DrawArea.Width, DrawArea.Height);
            g = Graphics.FromImage(DrawArea.Image);
            for (int i = 0; i < CurColor.DropDownItems.Count; i++)
                CurColor.DropDownItems[i].Click += new System.EventHandler(Color_Click);
            CurColor.DropDownItems["RGB"].Click += new System.EventHandler(RGB_Click);
            PEN = new Pen(CurColor.BackColor, SizePen);
            SizeBrush.SelectedIndex = 9;
            curs.Add(CreateCursor(new Bitmap("../../source/pen.png"), 5, 23));
            curs.Add(CreateCursor(new Bitmap("../../source/brush.png"), 3, 31));
            curs.Add(CreateCursor(new Bitmap("../../source/fill.png"), 10, 28));
            curs.Add(CreateCursor(new Bitmap("../../source/pattern.png"), 1, 31));
            ToolBar.Items.Add(new ToolStripControlHost(this.Intensity));

            Pattern = new ToolStripSplitButton();
            Pattern.AutoSize = false;
            Pattern.BackgroundImageLayout = ImageLayout.None;
            Pattern.DisplayStyle = ToolStripItemDisplayStyle.None;
            Pattern.ImageScaling = ToolStripItemImageScaling.None;
            Pattern.ImageTransparentColor = Color.Magenta;
            Pattern.Size = new Size(68, 29);
            Pattern.Text = "Pattern";
            Pattern.Name = "Pattern";
            Pattern.Margin = new Padding(5, 0, 5, 0);
            Pattern.Click += new EventHandler(Pattern_Click);
            for (int i = 0; i < 53; i++)
            {
                Bitmap img = new Bitmap(Pattern.Width, Pattern.Height);
                Graphics.FromImage(img).FillRectangle(new HatchBrush(HatchStyle.Horizontal + i, Color.Green, Color.White), 0, 0, Pattern.Width, Pattern.Height);
                ToolStripMenuItem TSMI = new ToolStripMenuItem();
                TSMI.AutoSize = false;
                TSMI.BackColor = Color.White;
                TSMI.BackgroundImage = img;
                TSMI.BackgroundImageLayout = ImageLayout.Stretch;
                TSMI.DisplayStyle = ToolStripItemDisplayStyle.Image;
                TSMI.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                TSMI.ImageAlign = ContentAlignment.MiddleLeft;
                TSMI.ImageScaling = ToolStripItemImageScaling.None;
                TSMI.RightToLeft = RightToLeft.Yes;
                TSMI.Size = new Size(65, 29);
                TSMI.ImageIndex = i;
                TSMI.Click += new EventHandler(Pattern_Items_Click);
                Pattern.DropDownItems.Add(TSMI);
            }
            Pattern.BackgroundImage = Pattern.DropDownItems[0].BackgroundImage;
            Pattern.ImageIndex = Pattern.DropDownItems[0].ImageIndex;
            ToolBar.Items.Add(Pattern);
            Figures = new ToolStripSplitButton();
            Figures.AutoSize = false;
            Figures.BackgroundImageLayout = ImageLayout.None;
            Figures.DisplayStyle = ToolStripItemDisplayStyle.None;
            Figures.ImageScaling = ToolStripItemImageScaling.None;
            Figures.ImageTransparentColor = Color.Magenta;
            Figures.Size = new Size(68, 29);
            Figures.Text = "Figures";
            Figures.Name = "Figures";
            Figures.Margin = new Padding(5, 0, 5, 0);
            Figures.Click += new EventHandler(Figures_Click);
            Figures.BackgroundImageLayout = ImageLayout.Stretch;
            Figures.BackColor = Color.White;
            for (int i = 0; i < 5; i++)
            {
                ToolStripMenuItem TSMI = new ToolStripMenuItem();
                TSMI.AutoSize = false;
                TSMI.BackColor = Color.White;
                TSMI.BackgroundImageLayout = ImageLayout.Stretch;
                TSMI.TextImageRelation = TextImageRelation.Overlay;
                TSMI.DisplayStyle = ToolStripItemDisplayStyle.Image;
                TSMI.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                TSMI.ImageAlign = ContentAlignment.MiddleLeft;
                TSMI.ImageScaling = ToolStripItemImageScaling.None;
                TSMI.RightToLeft = RightToLeft.Yes;
                TSMI.Size = new Size(68, 60);
                TSMI.ImageIndex = i;
                TSMI.Click += new EventHandler(Figures_Items_Click);
                Figures.DropDownItems.Add(TSMI);
            }
            Figures.DropDownItems[0].BackgroundImage = new Bitmap("../../source/f_rectangle.png");
            Figures.DropDownItems[1].BackgroundImage = new Bitmap("../../source/f_ellipse.png");
            Figures.DropDownItems[2].BackgroundImage = new Bitmap("../../source/f_triangle.png");
            Figures.DropDownItems[3].BackgroundImage = new Bitmap("../../source/f_line.png");
            Figures.DropDownItems[4].BackgroundImage = new Bitmap("../../source/f_polygon.png");
            Figures.BackgroundImage = Figures.DropDownItems[0].BackgroundImage;
            Figures.ImageIndex = Figures.DropDownItems[0].ImageIndex;
            ToolBar.Items.Add(Figures);
            DrawArea_G = DrawArea.CreateGraphics();
            bufer = new Bitmap(DrawArea.Width, DrawArea.Height);
            Contour = Graphics.FromImage(bufer);
        }
        private void Pattern_Items_Click(object sender, EventArgs e)
        {
            Pattern.BackgroundImage = ((ToolStripMenuItem)sender).BackgroundImage;
            Pattern.ImageIndex = ((ToolStripMenuItem)sender).ImageIndex;
        }
        private void Figures_Items_Click(object sender, EventArgs e)
        {
            Figures.BackgroundImage = ((ToolStripMenuItem)sender).BackgroundImage;
            Figures.ImageIndex = ((ToolStripMenuItem)sender).ImageIndex;
        }
        private void Pattern_Click(object sender, EventArgs e)
        {
            CurTool = "Pattern";
            DrawArea.Cursor = (Cursor)curs[3];
        }
        private void Figures_Click(object sender, EventArgs e)
        {
            CurTool = "Figures";
            DrawArea.Cursor = Cursors.Cross;
        }
        private void DrawArea_MouseLeave(object sender, EventArgs e)
        {
            Status.Items["CurPoss"].Text = "";
        }
        private void DrawArea_Resize(object sender, EventArgs e)
        {
            Status.Items["DrawSize"].Text = DrawArea.Size.Width + " x " + DrawArea.Size.Height;
        }
        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                int w = DrawArea.Right, h = DrawArea.Bottom;
                Label lb = ((Label)sender);
                lb.Location = new Point();
                switch (lb.TabIndex)
                {
                    case 0:
                        w = e.X;
                        break;
                    case 1:
                        w = e.X;
                        h = e.Y;
                        break;
                    case 2:
                        h = e.Y;
                        break;
                }
                DrawArea.Size = new Size(w - DrawArea.Left, h - DrawArea.Top);
            }
        }
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
        }
        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            lbl[0].Location = new Point(DrawArea.Right, DrawArea.Height / 2 + DrawArea.Top);
            lbl[1].Location = new Point(DrawArea.Right, DrawArea.Bottom);
            lbl[2].Location = new Point(DrawArea.Width / 2 + DrawArea.Left, DrawArea.Bottom);
            dragging = false;
            Object tmp = DrawArea.Image.Clone();
            DrawArea.Image.Dispose();
            g.Dispose();
            DrawArea.Image = new Bitmap(DrawArea.Size.Width, DrawArea.Size.Height);
            g = Graphics.FromImage(DrawArea.Image);
            g.DrawImageUnscaled((Image)tmp, new Rectangle(0, 0, ((Image)tmp).Width, ((Image)tmp).Height));
            ((Image)tmp).Dispose();

            DrawArea_G.Dispose();
            bufer.Dispose();
            Contour.Dispose();
            DrawArea_G = DrawArea.CreateGraphics();
            bufer = new Bitmap(DrawArea.Width, DrawArea.Height);
            Contour = Graphics.FromImage(bufer);
        }
        private void Pen_Click(object sender, EventArgs e)
        {
            CurTool = "Pen";
            DrawArea.Cursor = (Cursor)curs[0];
            PEN.Width = SizePen = 1;
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            CurTool = "Brush";
            DrawArea.Cursor = (Cursor)curs[1];
            PEN.Width = SizePen = SizeBrush.SelectedIndex + 1;
        }
        private void Filling_Click(object sender, EventArgs e)
        {
            CurTool = "Filling";
            DrawArea.Cursor = (Cursor)curs[2];
        }
        void FloodFill(Bitmap bitmap, int x, int y, Color color)
        {
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);
            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;
            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();
                    foreach (Point off in new Point[] { new Point(0, -1), new Point(0, 1), new Point(-1, 0), new Point(1, 0) })
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 && next.X < data.Width && next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }
            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }
        private void DrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownDrawArea = true;
            prevLocMouse.X = e.X - SizePen / 2;
            prevLocMouse.Y = e.Y - SizePen / 2;
            if (CurTool != null)
                switch (CurTool)
                {
                    case "Pen":
                        PEN.Width = SizePen = 1;
                        g.FillRectangle(PEN.Brush, e.X - SizePen / 2, e.Y - SizePen / 2, SizePen, SizePen);
                        break;
                    case "Brush":
                        if (SizePen > 1)
                            g.FillEllipse(PEN.Brush, e.X - SizePen / 2, e.Y - SizePen / 2, SizePen, SizePen);
                        else
                            g.FillRectangle(PEN.Brush, e.X - SizePen / 2, e.Y - SizePen / 2, SizePen, SizePen);
                        break;
                    case "Filling":
                        FloodFill((Bitmap)DrawArea.Image, e.X, e.Y, CurColor.BackColor);
                        break;
                    case "Pattern":
                        HatchBrush Hatch = new HatchBrush(HatchStyle.Horizontal + Pattern.ImageIndex, CurColor.BackColor, Color.FromArgb(0, 0, 0, 0));
                        if (SizePen > 1)
                            g.FillEllipse(Hatch, e.X - SizePen / 2, e.Y - SizePen / 2, SizePen, SizePen);
                        else
                            g.FillRectangle(Hatch, e.X - SizePen / 2, e.Y - SizePen / 2, SizePen, SizePen);
                        Hatch.Dispose();
                        break;
                    case "Figures":
                        x = e.X;
                        y = e.Y;
                        Contour.Clear(Color.White);
                        Contour.DrawImage(DrawArea.Image, 0, 0);
                        if (Figures.ImageIndex == 2)
                            points.Add(new Point(e.X, e.Y));
                        if (Figures.ImageIndex == 4)
                            points.Add(new Point(e.X, e.Y));
                        break;
                }
            DrawArea.Invalidate();
        }
        private void DrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownDrawArea = false;
            if (CurTool == "Figures")
            {
                if (Figures.ImageIndex == 2)
                {
                    if (points.Count == 3)
                    {
                        g.DrawPolygon(PEN, points.Cast<Point>().ToArray<Point>());
                        points.Clear();
                        DrawArea.Invalidate();
                    }
                }
                else if (Figures.ImageIndex == 4)
                {
                    if (points.Count > 1)
                    {
                        Contour.Clear(Color.White);
                        Contour.DrawImage(DrawArea.Image, 0, 0);
                        Contour.DrawPolygon(PEN, points.Cast<Point>().ToArray<Point>());
                        DrawArea_G.DrawImageUnscaled(bufer, 0, 0);
                    }
                }
                else
                {
                    g.DrawImageUnscaled(bufer, 0, 0);
                    points.Clear();
                }
            }
            else
                points.Clear();
        }
        private void DrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            Status.Items["CurPoss"].Text = e.X + ", " + e.Y;
            if (MouseDownDrawArea)
            {
                int X = e.X - SizePen / 2;
                int Y = e.Y - SizePen / 2;
                switch (CurTool)
                {
                    case "Pen":
                        PEN.Width = SizePen = 1;
                        g.FillRectangle(PEN.Brush, X, Y, SizePen, SizePen);
                        g.DrawLine(PEN, prevLocMouse.X + SizePen / 2, prevLocMouse.Y + SizePen / 2, X + SizePen / 2, Y + SizePen / 2);
                        DrawArea.Invalidate();
                        break;
                    case "Brush":
                        if (SizePen > 1)
                            g.FillEllipse(PEN.Brush, X, Y, SizePen, SizePen);
                        else
                            g.FillRectangle(PEN.Brush, X, Y, SizePen, SizePen);
                        g.DrawLine(PEN, prevLocMouse.X + SizePen / 2, prevLocMouse.Y + SizePen / 2, X + SizePen / 2, Y + SizePen / 2);
                        DrawArea.Invalidate();
                        break;
                    case "Pattern":
                        HatchBrush Hatch = new HatchBrush(HatchStyle.Horizontal + Pattern.ImageIndex, CurColor.BackColor, Color.FromArgb(0, 0, 0, 0));
                        if (SizePen > 1)
                            g.FillEllipse(Hatch, X, Y, SizePen, SizePen);
                        else
                            g.FillRectangle(Hatch, X, Y, SizePen, SizePen);
                        Hatch.Dispose();
                        DrawArea.Invalidate();
                        break;
                    case "Figures":
                        Contour.Clear(Color.White);
                        Contour.DrawImage(DrawArea.Image, 0, 0);
                        switch (Figures.ImageIndex)
                        {
                            case 0:
                                Contour.DrawRectangle(PEN, (e.X > x) ? x : e.X, (e.Y > y) ? y : e.Y, (e.X > x) ? e.X - x : x - e.X, (e.Y > y) ? e.Y - y : y - e.Y);
                                break;
                            case 1:
                                Contour.DrawEllipse(PEN, (e.X > x) ? x : e.X, (e.Y > y) ? y : e.Y, (e.X > x) ? e.X - x : x - e.X, (e.Y > y) ? e.Y - y : y - e.Y);
                                break;
                            case 3:
                                Contour.DrawLine(PEN, x, y, e.X, e.Y);
                                break;
                        }
                        DrawArea_G.DrawImageUnscaled(bufer, 0, 0);
                        break;
                }
                prevLocMouse.X = X;
                prevLocMouse.Y = Y;
            }
        }
        private void SizeBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurTool == "Pen")
                PEN.Width = SizePen = 1;
            else
            {
                PEN.Width = SizePen = SizeBrush.SelectedIndex + 1;
            }
        }
        private void Intensity_ValueChanged(object sender, EventArgs e)
        {
            PEN.Color = CurColor.BackColor = Color.FromArgb(Convert.ToInt32((int)Intensity.Value * 2.55), CurColor.BackColor);
        }
        private void Color_Click(object sender, EventArgs e)
        {
            PEN.Color = CurColor.BackColor = ((ToolStripMenuItem)sender).BackColor;
            Intensity.Value = 100;
        }
        private void RGB_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            if (CD.ShowDialog() == DialogResult.OK)
                PEN.Color = CurColor.BackColor = CD.Color;
            CD.Dispose();
            Intensity.Value = 100;
        }
        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);
        public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }
        private void New_Click(object sender, EventArgs e)
        {
            DrawArea.Image.Dispose();
            g.Dispose();
            DrawArea.Image = new Bitmap(DrawArea.Size.Width, DrawArea.Size.Height);
            g = Graphics.FromImage(DrawArea.Image);
        }
        private void Load_Click(object sender, EventArgs e)
        {
            DrawArea.Image.Dispose();
            g.Dispose();
            OpenFileDialog tmp = new OpenFileDialog();
            tmp.Filter =
                "Точечные рисунки|*.bmp;*.dib|" +
                "JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|" +
                "GIF|*.gif|" +
                "TIFF|*.tif;*.tiff|" +
                "PNG|*.png|" +
                "ICO|*.ico|" +
                "Все файлы изображений|*.bmp;*.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png;*.ico;|" +
                "Все файлы|*.*";
            tmp.Multiselect = true;
            if (tmp.ShowDialog() == DialogResult.OK)
            {
                DrawArea.Image = new Bitmap(tmp.FileName);
                g = Graphics.FromImage(DrawArea.Image);
                DrawArea.Size = new Size(DrawArea.Image.Width, DrawArea.Image.Height);
                lbl[0].Location = new Point(DrawArea.Right, DrawArea.Height / 2 + DrawArea.Top);
                lbl[1].Location = new Point(DrawArea.Right, DrawArea.Bottom);
                lbl[2].Location = new Point(DrawArea.Width / 2 + DrawArea.Left, DrawArea.Bottom);
            }
            tmp.Dispose();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog tmp = new SaveFileDialog();
            tmp.Filter =
            "Точечные рисунки|*.bmp;*.dib|" +
            "JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|" +
            "GIF|*.gif|" +
            "TIFF|*.tif;*.tiff|" +
            "PNG|*.png";
            if (tmp.ShowDialog() == DialogResult.OK)
                DrawArea.Image.Save(tmp.FileName);
            tmp.Dispose();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Paint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Figures.ImageIndex == 4)
                {
                    if (points.Count > 1)
                    {
                        g.DrawImageUnscaled(bufer, 0, 0);
                        points.Clear();
                    }
                }
            }
        }
        private void Paint_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData("FileDrop", false);
            DrawArea.Image = new Bitmap(s[0]);
            g = Graphics.FromImage(DrawArea.Image);
            DrawArea.Size = new Size(DrawArea.Image.Width, DrawArea.Image.Height);
            lbl[0].Location = new Point(DrawArea.Right, DrawArea.Height / 2 + DrawArea.Top);
            lbl[1].Location = new Point(DrawArea.Right, DrawArea.Bottom);
            lbl[2].Location = new Point(DrawArea.Width / 2 + DrawArea.Left, DrawArea.Bottom);
        }
        private void Paint_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}