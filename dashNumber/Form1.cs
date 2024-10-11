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
            Pen pen = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;
    
            //baza 
            int baseX = 150;
            int baseY = 100;
    
            // jedności dziesiątki setki tysiące
            int one = numberToDraw % 10;         
            int ten = (numberToDraw / 10) % 10;  
            int hundred = (numberToDraw / 100) % 10;  
            int thousand = (numberToDraw / 1000) % 10;  
    
            // Rysowanie cyfr
            drawNumberCyster(g, pen, baseX, baseY, one);       
            drawNumberCyster(g, pen, baseX, baseY, ten, true);    
            drawNumberCyster(g, pen, baseX , baseY, hundred, false, true); 
            drawNumberCyster(g, pen, baseX, baseY, thousand, false, false, true); 
        }

        private void drawNumberCyster(Graphics g, Pen pen, int baseX, int baseY, int digit, bool isTen = false, bool isHundred = false, bool isThousand = false)
        {
            if (isTen)
            {
                // Rysowanie dziesiątek
                switch (digit)
                {
                    case 1:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 30, baseX - 20, baseY + 30);
                        break;
                    case 2:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 40, baseX - 20, baseY + 40);
                        break;
                    case 3:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 30, baseX - 20, baseY + 40);
                        break;
                    case 4:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 40, baseX - 20, baseY + 30);
                        break;
                    case 5:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 40, baseX - 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 30, baseX - 20, baseY + 30);
                        break;
                    case 6:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX - 20, baseY + 40, baseX - 20, baseY + 30);
                        break;
                    case 7:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX - 20, baseY + 40, baseX - 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 30, baseX - 20, baseY + 30);
                        break;
                    case 8:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX - 20, baseY + 40, baseX - 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 40, baseX - 20, baseY + 40);
                        break;
                    case 9:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 30, baseX - 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 40, baseX - 20, baseY + 40);
                        g.DrawLine(pen, baseX - 20, baseY + 40, baseX - 20, baseY + 30);
                        break;
                }
            }
            else if (isHundred)
            {
                // Rysowanie setek
                switch (digit)
                {
                    case 1:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX + 20, baseY + 80);
                        break;
                    case 2:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX + 20, baseY + 70);
                        break;
                    case 3:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX + 20, baseY + 70);
                        break;
                    case 4:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX + 20, baseY + 80);
                        break;
                    case 5:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX + 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX + 20, baseY + 80);
                        break;
                    case 6:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX + 20, baseY + 70, baseX + 20, baseY + 80);
                        break;
                    case 7:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX + 20, baseY + 70, baseX + 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX + 20, baseY + 80);
                        break;
                    case 8:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX + 20, baseY + 70, baseX + 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX + 20, baseY + 70);
                        break;
                    case 9:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX + 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX + 20, baseY + 70);
                        g.DrawLine(pen, baseX + 20, baseY + 70, baseX + 20, baseY + 80);
                        break;
                }
            }
            else if (isThousand)
            {
                // Rysowanie tysięcy
                switch (digit)
                {
                   case 1:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX - 20, baseY + 80);
                        break;
                    case 2:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX - 20, baseY + 70);
                        break;
                    case 3:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX - 20, baseY + 70);
                        break;
                    case 4:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX - 20, baseY + 80);
                        break;
                    case 5:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX - 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX - 20, baseY + 80);
                        break;
                    case 6:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX - 20, baseY + 70, baseX - 20, baseY + 80);
                        break;
                    case 7:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX - 20, baseY + 70, baseX - 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX - 20, baseY + 80);
                        break;
                    case 8:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX - 20, baseY + 70, baseX - 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX - 20, baseY + 70);
                        break;
                    case 9:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 80, baseX - 20, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 70, baseX - 20, baseY + 70);
                        g.DrawLine(pen, baseX - 20, baseY + 70, baseX - 20, baseY + 80);
                        break;
                }
            }
            else
            {
                // Rysowanie jedności
                switch (digit)
                {
                    case 1:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 30, baseX + 20, baseY + 30);
                        break;
                    case 2:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 40, baseX + 20, baseY + 40);
                        break;
                    case 3:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 30, baseX + 20, baseY + 40);
                        break;
                    case 4:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 40, baseX + 20, baseY + 30);
                        break;
                    case 5:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 40, baseX + 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 30, baseX + 20, baseY + 30);
                        break;
                    case 6:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX + 20, baseY + 40, baseX + 20, baseY + 30);
                        break;
                    case 7:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX + 20, baseY + 40, baseX + 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 30, baseX + 20, baseY + 30);
                        break;
                    case 8:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX + 20, baseY + 40, baseX + 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 40, baseX + 20, baseY + 40);
                        break;
                    case 9:
                        g.DrawLine(pen, baseX, baseY + 30, baseX, baseY + 80);
                        g.DrawLine(pen, baseX, baseY + 30, baseX + 20, baseY + 30);
                        g.DrawLine(pen, baseX, baseY + 40, baseX + 20, baseY + 40);
                        g.DrawLine(pen, baseX + 20, baseY + 40, baseX + 20, baseY + 30);
                        break;
                }
            }
        }
    }
}
