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
        public static string selectedAddon = "";   
        public static int addonPrice = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            car car = new car();
            picnum = 1;
            car.ShowDialog();
            abc();
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

        private void button11_Click(object sender, EventArgs e)
        {
            howmuch2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            howmuch2.Visible = false;
        }
        private void abc()
        {
            if (radioButton1.Checked)
            {
                selectedAddon = "加購外套";
                addonPrice = 1000;   
            }
            if (radioButton2.Checked)
            {
                selectedAddon = "軍靴";
                addonPrice = 2000;
                
            }
            if (radioButton3.Checked)
            {
                selectedAddon = "德國飛行員手錶";
                addonPrice = 100000;
                
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
