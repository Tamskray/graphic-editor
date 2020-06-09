using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_editor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Image file;
        bool opened = false;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        void reload()
        {
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    opened = true;
                }
            }
        }

        void rgbChanges()
        {
            float changered = redbar.Value * 0.1f;
            float changegreen = greenbar.Value * 0.1f;
            float changeblue = bluebar.Value * 0.1f;

            redvalue.Text = changered.ToString();
            greenvalue.Text = changegreen.ToString();
            bluevalue.Text = changeblue.ToString();
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;  
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height); 
                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{1+changered, 0, 0, 0, 0},
                    new float[]{0, 1+changegreen, 0, 0, 0},
                    new float[]{0, 0, 1+changeblue, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image; 
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  
                ImageAttributes ia = new ImageAttributes();         
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture); 
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                            
                pictureBox1.Image = bmpInverted;
            }
        }

        private void artisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;               
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  
                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);  
                Graphics g = Graphics.FromImage(bmpInverted); 
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                           
                pictureBox1.Image = bmpInverted;

            }
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image; 
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();           
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture); 
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                           
                pictureBox1.Image = bmpInverted;
            }
        }

        private void spikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;        
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height); 
                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0.7f, 0, 0, 0},
                    new float[]{0, 0, 1+1.3f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture); 
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                            
                pictureBox1.Image = bmpInverted;
            }
        }

        private void flashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;                          
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                ImageAttributes ia = new ImageAttributes();              
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
                    new float[]{0, 1+1.5f, 0, 0, 0},
                    new float[]{0, 0, 1+1.3f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);  
                Graphics g = Graphics.FromImage(bmpInverted); 
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                           
                pictureBox1.Image = bmpInverted;
            }
        }

        private void frozenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;  
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height); 
                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0f, 0, 0, 0},
                    new float[]{0, 0, 1+5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);        
                Graphics g = Graphics.FromImage(bmpInverted); 
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                            
                pictureBox1.Image = bmpInverted;
            }
        }

        private void sujiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;                            
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  

                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
                    new float[]{.769f+0.3f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);   
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                           
                pictureBox1.Image = bmpInverted;
            }
        }

        private void dramaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;                           
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height); 
                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f+0.2f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.9f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);  
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                           
                pictureBox1.Image = bmpInverted;
            }
        }

        private void kakaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
            if (!opened)
            {
                MessageBox.Show("Відкрийте зображення, а потім застосуйте зміни");
            }
            else
            {
                Image img = pictureBox1.Image;                            
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
                    new float[]{.769f, .686f+0.5f, .534f, 0, 0},
                    new float[]{.189f+2.3f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void redbar_ValueChanged(object sender, EventArgs e)
        {
            rgbChanges();
        }

        private void greenbar_ValueChanged(object sender, EventArgs e)
        {
            rgbChanges();
        }

        private void bluebar_ValueChanged(object sender, EventArgs e)
        {
            rgbChanges();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog(); 
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Зображення не завантажено, спочатку завантажте зображення");
            }
        }
    }
}
