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
            label2.Text = "總金額為" + moneyyy + "元，歡迎下次光臨";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
