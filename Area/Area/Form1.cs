using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(textBox1.Text);
            int width = Convert.ToInt32(textBox2.Text);

            Rectangle rect = new Rectangle();
            rect.setLength(length);
            rect.setWidth(width);

            MessageBox.Show("The Area is " + rect.CalculateArea(),"Hello");




        }
    }
}
