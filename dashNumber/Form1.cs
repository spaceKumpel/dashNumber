using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace dashNumber
{
    public partial class Form1 : Form
    {
        private int numberToDraw;  
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num) && num >= 1 && num <= 9999)
            {
                numberToDraw = num;  
                pictureBox1.Invalidate();  
            }
            else
            {
                MessageBox.Show("Enter a number between 1 and 9999.");
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (numberToDraw > 0)
            {
                Pen pen = new Pen(Color.Black, 2);
                e.Graphics.DrawLine(pen, new Point(150, 10), new Point(150, pictureBox1.Height - 10));
            }
        }
    }
}