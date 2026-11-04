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
    public partial class money : Form
    {
        public money()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        
        public static int moneyyy = 0;
        private void money_Load(object sender, EventArgs e)
        {
            moneyyy = car.money+pay.moneyy;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            allthings1.Visible = true;
        }
    }
}
