using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace openFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //opening file async/await
        //read the text file
        private async void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "text documents|*.txt", ValidateNames = true, Multiselect = false }) 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader sr=new StreamReader(ofd.FileName))
                {
                    textBox1.Text = await sr.ReadLineAsync();
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "text documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        await sw.WriteLineAsync(textBox1.Text);
                    MessageBox.Show("saved successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
