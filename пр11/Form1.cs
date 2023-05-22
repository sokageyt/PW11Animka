using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр11
{
    public partial class Form1 : Form
    {

        private Bitmap[] Frames;
        private int FrameNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[12];
            for (int i = 0; i < 12; i++)
            {
                Frames[i] = new Bitmap(@"Z:\Общая для записи студентам\208\208 Сорокин Илья, Чумаев Данила, Лобанов Александр,Саня Журавль и Цыга Трэпстар\маё(не тргать0)\пр11\.png" + i);

            }
            pictureBox1.Image = Frames[FrameNum];
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % Frames.Length;
            pictureBox1.Image = Frames[FrameNum];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) button1.Text = "stop";
            else button1.Text = "start";
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            timer1.Interval = 100 / trackBar1.Value;

        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
