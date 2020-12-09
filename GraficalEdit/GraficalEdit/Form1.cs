using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficalEdit
{
    public partial class Form1 : Form
    {
        Bitmap pict;
        Graphics g;
        int x = 0;
        int y = 0;
        string filePath = "";
        string Filter = "Изображение (*.png)|*.png|Изображение (*.bmp)|*.bmp|Изображение (*.jpg)|*.jpg";

        public Form1()
        {

            InitializeComponent();
            pict = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pict);
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                saveFileDialog1.ShowDialog();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image     Files|*.jpg;*.png;*.tiff;*.bmp";
                if (saveFileDialog1.FileName != "")
                    pict.Save(saveFileDialog1.FileName);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            saveFileDialog1.ShowDialog();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image     Files|*.jpg;*.png;*.tiff;*.bmp";
            if (saveFileDialog1.FileName!="")
            pict.Save(saveFileDialog1.FileName);
          
        }
    


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
        
        }
        private void Button_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p;
            p = new Pen(button3.BackColor,trackBar1.Value);
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Graphics g;
            g = Graphics.FromImage(pict);

            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(p, x, y, e.X, e.Y);
                pictureBox1.Image = pict;
            }
            x=e.X;
            y=e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
           
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
        }

        private void сохранитьКакToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.Filter = Filter;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;

                    pictureBox1.Image.Save(filePath);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            button3.BackColor = b.BackColor;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Draw
        }
    }
}
