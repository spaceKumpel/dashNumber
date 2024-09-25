using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num))
            {
                DrawcistercianNum(num);
            }
            else
            {
                MessageBox.Show("enter number");
            }
        }
        private void DrawcistercianNum(int num)
        {
            
        }
        
    }
}