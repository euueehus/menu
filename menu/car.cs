using menu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
        }
        public static int[] buynum = new int[8];
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void car_Load(object sender, EventArgs e)
        {
            if (list.picnum == 1)
            {
                pictureBox1.Image = Resources.Chiang_Kai_shek_Colour;
            }
            if (list.picnum == 2)
            {
                pictureBox1.Image = Resources.Bundesarchiv_Bild_183_R99621__Heinrich_Himmler;
            }
            if (list.picnum == 3)
            {
                pictureBox1.Image = Resources.溥仪;
            }
            if (list.picnum == 4)
            {
                pictureBox1.Image = Resources.images__1_;
            }
            if (list.picnum == 5)
            {
                pictureBox1.Image = Resources.FDR_1944_Color_Portrait__cropped__b_;
            }
            if (list.picnum == 6)
            {
                pictureBox1.Image = Resources.De_Gaulle_OWI__cropped___c_;
            }

            if (list.picnum == 7)
            {
                pictureBox1.Image = Resources.Hermann_Göring___Röhr;

            }
            if (list.picnum == 8)
            {
                pictureBox1.Image = Resources.Joseph_Stalin_official_portrait;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        private void call(string reason)
        {
            list list = new list();
            list.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=(int.Parse(textBox1.Text)-1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (list.picnum == 1) 
            {
                buynum[0] += int.Parse(textBox1.Text);

            }
            if (list.picnum == 2)
            {
                buynum[1] += int.Parse(textBox1.Text);

            }
            if (list.picnum == 3)
            {
                buynum[2] += int.Parse(textBox1.Text);

            }
            if (list.picnum == 4)
            {
                buynum[3] += int.Parse(textBox1.Text);

            }
            if (list.picnum == 5)
            {
                buynum[4] += int.Parse(textBox1.Text);

            }
            if (list.picnum == 6)
            {
                buynum[5] += int.Parse(textBox1.Text);

            }
            if (list.picnum == 7)
            {
                buynum[6] += int.Parse(textBox1.Text);

            }
            if (list.picnum == 8)
            {
                buynum[7] += int.Parse(textBox1.Text);

            }
            call("hi");

            




        }
    }
}
