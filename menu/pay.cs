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
    public partial class pay : Form
    {
        public pay()
        {
            InitializeComponent();
        }

        private void pay_Load(object sender, EventArgs e)
        {
            label16.Text = "已選取" + car.buynum[0]+"隻";
            label13.Text = "已選取" + car.buynum[1] + "隻";
            label12.Text = "已選取" + car.buynum[2] + "隻";
            label10.Text = "已選取" + car.buynum[3] + "隻";
            label15.Text = "已選取" + car.buynum[4] + "隻";
            label11.Text = "已選取" + car.buynum[5] + "隻";
            label14.Text = "已選取" + car.buynum[6] + "隻";
            label17.Text = "已選取" + car.buynum[7] + "隻";
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list list = new list();
            this.Hide();           
            list.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            money money = new money(); 
            this.Hide();
            money.ShowDialog();
        }
    }
}
