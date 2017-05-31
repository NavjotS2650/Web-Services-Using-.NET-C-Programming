using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        int xGlobal;
        int yGlobal;
        public Form1()
        {
            InitializeComponent();
        }

        public int nonIntelligent(int[,] chessboard, int x, int y)
        {
            int count = 0;

            chessboard[x, y] = 99;
            int posx = x;
            int posy = y;
            int[] xmove = new int[8];
            int[] ymove = new int[8];

            int[] xMove = new int[8];
            int[] yMove = new int[8];
            xMove[0] = 1;
            xMove[1] = 2;
            xMove[2] = 2;
            xMove[3] = 1;
            xMove[4] = -1;
            xMove[5] = -2;
            xMove[6] = -2;
            xMove[7] = -1;
            yMove[0] = -2;
            yMove[1] = -1;
            yMove[2] = 1;
            yMove[3] = 2;
            yMove[4] = 2;
            yMove[5] = 1;
            yMove[6] = -1;
            yMove[7] = -2;

            for (int i = 0; i < 8; i++)
            {

                int posx1 = posx + xMove[i];
                int posy2 = posy + yMove[i];

                if (posx1 >= 0 && posy2 >= 0 && posx1 < 8 && posy2 < 8)
                {
                    if (chessboard[posx1, posy2] != 99)
                    {
                        xmove[count] = posx1;
                        ymove[count] = posy2;
                        count++;
                    }
                }

                posx1 = 0;
                posy2 = 0;

                // MessageBox.Show("Hello i am in For loop" + xmove[i] + "," + ymove[i] + ",count:" + count);

            }
            Random rnd = new Random();
            int rand = rnd.Next(count);
            chessboard[xmove[rand], ymove[rand]] = 99;
            MessageBox.Show("" + xmove[rand] + "," + ymove[rand] + ",count:" + count);
            xGlobal = xmove[rand];
            yGlobal = ymove[rand];

            return count;
        }



        private void button1_Click(object sender, EventArgs e)
        {


            xGlobal = Convert.ToInt32(textBox1.Text);
            yGlobal = Convert.ToInt32(textBox2.Text);

            //   MessageBox.Show("Hello how are you:"+xGlobal , "Hellow");
            int[,] chessboard = new int[8, 8];


            int counter = nonIntelligent(chessboard, xGlobal, yGlobal);
            int number = 1;
            while (counter != 0)
            {
                counter = nonIntelligent(chessboard, xGlobal, yGlobal);
                //MessageBox.Show("Hello Main While loop counter:" + number);
                number++;
            }


            MessageBox.Show("Hello Outside the Loop TOTAL:" + number);
        } } }
    