using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        public static int picnum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            car car = new car();
            picnum = 1;
            car.ShowDialog();
        }
            
        private void car1(string reason)
        {
            car car = new car();
            car.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

            car car = new car();
            picnum = 2;
            car.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            car car = new car();
            picnum = 3;
            car.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            car car = new car();
            picnum = 7;
            car.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            car car = new car();
            picnum = 5;
            car.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            car car = new car();
            picnum = 6;
            car.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            car car = new car();
            picnum = 4;
            car.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            car car = new car();
            picnum = 8;
            car.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            pay pay  = new pay();
            this.Hide();
            pay.ShowDialog();
            
        }

        private void list_Load(object sender, EventArgs e)
        {
            
        }
    }
}
