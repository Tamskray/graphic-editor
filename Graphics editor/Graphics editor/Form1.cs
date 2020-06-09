using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Graphics_editor
{
    public partial class Form1 : Form
    {
        bool isPressed;                     
        int x1, y1, x2, y2;                 
        public Bitmap snapshot, tempDraw;          
        Color foreColor;                    
        int lineWidth = 2;                  
        int FontSize = 2;
        string selectedTool = "none";         
        Pen pen;

        public Form2 Form21
        {
            get => default;
            set
            {
            }
        }

        public void clear()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            pictureBox1.Image = null;
            snapshot = new Bitmap(snapshot.Width, snapshot.Height);
            tempDraw = (Bitmap)snapshot.Clone();
            g.Dispose();
        }
        public void ReloadColor(Color a)
        {
            foreColor = a;
            colorB.BackColor = foreColor;
            pen.Color = foreColor;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (selectedTool != "brush" && selectedTool != "eraser" && selectedTool != "pensil")
                tempDraw = (Bitmap)snapshot.Clone();
            Graphics g = Graphics.FromImage(tempDraw);
            switch (selectedTool)
            {
                case "line":
                    if (tempDraw != null)
                    {
                        if (choseLine.SelectedIndex == 0)
                        {
                            g.DrawLine(pen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 1)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.DashStyle = DashStyle.Dash;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 2)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.DashStyle = DashStyle.DashDot;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 3)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.DashStyle = DashStyle.DashDotDot;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 4)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.DashStyle = DashStyle.Dot;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 5)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.StartCap = LineCap.ArrowAnchor;
                            myPen.EndCap = LineCap.DiamondAnchor;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 6)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.StartCap = LineCap.Round;
                            myPen.EndCap = LineCap.RoundAnchor;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 7)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.StartCap = LineCap.Square;
                            myPen.EndCap = LineCap.SquareAnchor;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                        else if (choseLine.SelectedIndex == 8)
                        {
                            Pen myPen = new Pen(foreColor, lineWidth);
                            myPen.StartCap = LineCap.Triangle;
                            myPen.EndCap = LineCap.Flat;
                            g.DrawLine(myPen, x1, y1, x2, y2);
                        }
                    }
                    break;
                case "rectangle":
                    if (tempDraw != null)
                    {
                        if (x2 < x1 && y2 < y1)
                        {
                            g.FillRectangle(new SolidBrush(foreColor), x2, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                        }
                        else if (x2 < x1 && y2 > y1)
                        {
                            g.FillRectangle(new SolidBrush(foreColor), x2, y1, Math.Abs(x2 - x1), y2 - y1);
                        }
                        else if (x2 > x1 && y2 < y1)
                        {
                            g.FillRectangle(new SolidBrush(foreColor), x1, y2, x2 - x1, Math.Abs(y2 - y1));
                        }
                        else
                            g.FillRectangle(new SolidBrush(foreColor), x1, y1, x2 - x1, y2 - y1);
                    }
                    break;
                case "brush":
                    if (tempDraw != null)
                        g.DrawLine(pen, x1, y1, x2, y2);
                    x1 = x2;
                    y1 = y2;
                    break;
                case "eraser":
                    if (tempDraw != null)
                        g.FillEllipse(new SolidBrush(pictureBox1.BackColor), x1, y1, lineWidth, lineWidth);
                    x1 = x2;
                    y1 = y2;
                    break;
                case "ellipse":
                    g.FillEllipse(new SolidBrush(foreColor), x1, y1, x2 - x1, y2 - y1);
                    break;
                case "pensil":
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    if (pensilStyle.SelectedIndex == 0)
                    {
                        g.FillEllipse(new SolidBrush(foreColor), x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 1)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Cross, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 2)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DarkDownwardDiagonal, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 3)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DarkHorizontal, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 4)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DarkVertical, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 5)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DashedDownwardDiagonal, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 6)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DashedHorizontal, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 7)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DashedUpwardDiagonal, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 8)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DashedVertical, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 9)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DiagonalBrick, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 10)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DiagonalCross, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 11)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Divot, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 12)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DottedGrid, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 13)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.DottedDiamond, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 14)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Horizontal, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 15)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.LargeCheckerBoard, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 16)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.LargeConfetti, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 17)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Plaid, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 18)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Shingle, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 19)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.SmallGrid, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 20)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.SolidDiamond, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 21)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Sphere, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 22)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Trellis, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 23)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Vertical, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 24)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Wave, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 25)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.Weave, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    else if (pensilStyle.SelectedIndex == 26)
                    {
                        HatchBrush hb = new HatchBrush(HatchStyle.ZigZag, foreColor, Color.White);
                        g.FillEllipse(hb, x1, y1, lineWidth, lineWidth);
                        x1 = x2;
                        y1 = y2;
                    }
                    break;
                case "spacerectangle":
                    if (tempDraw != null)
                    {
                        if (x2 < x1 && y2 < y1)
                        {
                            g.DrawRectangle(pen, x2, y2, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
                        }
                        else if (x2 < x1 && y2 > y1)
                        {
                            g.DrawRectangle(pen, x2, y1, Math.Abs(x2 - x1), y2 - y1);
                        }
                        else if (x2 > x1 && y2 < y1)
                        {
                            g.DrawRectangle(pen, x1, y2, x2 - x1, Math.Abs(y2 - y1));
                        }
                        else
                            g.DrawRectangle(pen, x1, y1, x2 - x1, y2 - y1);
                    }
                    break;
                case "spaceellipse":
                    g.DrawEllipse(pen, x1, y1, x2 - x1, y2 - y1);
                    break;
                case "text":
                    if (fontStyle.SelectedIndex == 0)
                    {
                        Font f1 = new Font(fontName.Text, FontSize, FontStyle.Regular);
                        g.DrawString(textToDraw.Text, f1, new SolidBrush(foreColor), x1, y1);
                    }
                    else if (fontStyle.SelectedIndex == 1)
                    {
                        Font f1 = new Font(fontName.Text, FontSize, FontStyle.Bold);
                        g.DrawString(textToDraw.Text, f1, new SolidBrush(foreColor), x1, y1);
                    }
                    else if (fontStyle.SelectedIndex == 2)
                    {
                        Font f1 = new Font(fontName.Text, FontSize, FontStyle.Italic);
                        g.DrawString(textToDraw.Text, f1, new SolidBrush(foreColor), x1, y1);
                    }
                    else if (fontStyle.SelectedIndex == 3)
                    {
                        Font f1 = new Font(fontName.Text, FontSize, FontStyle.Underline);
                        g.DrawString(textToDraw.Text, f1, new SolidBrush(foreColor), x1, y1);
                    }
                    break;
                case "triangle1":
                    if (tempDraw != null)
                    {
                        Point[] myPoints =
                    {
                        new Point(x1,y1), new Point(x2,y2), new Point(x1,y2)
                    };
                        g.DrawPolygon(pen, myPoints);
                    }
                    break;
                case "triangle":
                    if (tempDraw != null)
                    {
                        Point[] myPoints =
                    {
                        new Point(x1,y1), new Point(x2,y2), new Point(x1,y2)
                    };
                        g.FillPolygon(new SolidBrush(foreColor), myPoints);
                    }
                    break;
            }
            g.Dispose();
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
        }


        private void tool_click(object sender, EventArgs e)
        {
            brush.Checked = false;
            line.Checked = false;
            rectangle.Checked = false;
            eraser.Checked = false;
            ellipse.Checked = false;
            none.Checked = false;
            pip.Checked = false;
            pensil.Checked = false;
            spacerectangle.Checked = false;
            spaceellipse.Checked = false;
            text.Checked = false;
            triangle1.Checked = false;
            triangle.Checked = false;
            ToolStripButton selected = sender as ToolStripButton;
            selected.Checked = true;
            selectedTool = selected.Name;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            x1 = e.X;
            y1 = e.Y;
            tempDraw = (Bitmap)snapshot.Clone();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                x2 = e.X;
                y2 = e.Y;
                pictureBox1.Invalidate();
                pictureBox1.Update();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            snapshot = (Bitmap)tempDraw.Clone();
        }

        private void sizeCB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lineWidth = int.Parse(sizeCB.Text);
                pen = new Pen(foreColor, lineWidth);
            }
            catch { }
        }

        private void newPicture_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void openPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                clear();                                                               
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Refresh();
                pictureBox1.Update();
                snapshot = new Bitmap(pictureBox1.Image);
                tempDraw = new Bitmap(snapshot);
                this.Text = openFileDialog1.FileName;   
            }
        }

        private void savePicture_Click(object sender, EventArgs e)
        {
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                this.Text = fileName;

                switch (strFilExtn)
                {
                    case "bmp": snapshot.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case "jpg": snapshot.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case "png": snapshot.Save(fileName, System.Drawing.Imaging.ImageFormat.Png); break;
                    default: break;
                }
            }
        }

        private void colorB_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ReloadColor(colorDialog1.Color);
            }
        }

        private void clearPaint_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedTool == "pip")
            {
                Bitmap copy = new Bitmap(snapshot);
                ReloadColor(copy.GetPixel(e.X, e.Y));
            }
        }

        private void whiteC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.White);
        }

        private void grayC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Gray);
        }

        private void brownC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Brown);
        }

        private void redC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Red);
        }

        private void orangeC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Orange);
        }

        private void yellowC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Yellow);
        }

        private void greenC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Green);
        }

        private void aquaC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Aqua);
        }

        private void blackC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily font in family)
            {
                fontName.Items.Add(font.GetName(1).ToString());
            }

            pictureBox1.AllowDrop = true;
        }

        private void fontSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FontSize = int.Parse(fontSize.Text);
            }
            catch { }
        }

        private void ButtonBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = c.Color;
                ButtonBackgroundColor.BackColor = c.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Width < 2000 || pictureBox1.Height < 2000 && pictureBox1.Width > 100 || pictureBox1.Height > 100)
            {
                pictureBox1.Width += 100;
                pictureBox1.Height += 100;
            }
            snapshot = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tempDraw = (Bitmap)snapshot.Clone();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Width < 2000 || pictureBox1.Height < 2000 && pictureBox1.Width > 100 || pictureBox1.Height > 100)
            {
                pictureBox1.Width -= 100;
                pictureBox1.Height -= 100;
            }
            snapshot = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tempDraw = (Bitmap)snapshot.Clone();
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    pictureBox1.Image = Image.FromFile(fileNames[0]);
            }
            snapshot = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tempDraw = (Bitmap)snapshot.Clone();
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void filtresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виконав: Копилов В.Р., КН-19-2");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void blueC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Blue);
        }

        private void fuchsiaC_Click(object sender, EventArgs e)
        {
            ReloadColor(Color.Fuchsia);
        }

        public Form1()
        {
            InitializeComponent();
            snapshot = new Bitmap(pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height);
            tempDraw = (Bitmap)snapshot.Clone();
            foreColor = Color.Black;
            pen = new Pen(foreColor, lineWidth);
            none.Checked = true;
            sizeCB.SelectedIndex = 9;
            choseLine.SelectedIndex = 0;
            pensilStyle.SelectedIndex = 0;
            fontSize.SelectedIndex = 13;
            fontStyle.SelectedIndex = 0;
        }
    }
}
