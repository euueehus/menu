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
    public partial class allthings : UserControl
    {
        public allthings()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allthings_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("類型", typeof(string));      // 用來區分
            dt.Columns.Add("項目", typeof(string));
            dt.Columns.Add("數量", typeof(int));
            dt.Columns.Add("單價", typeof(int));
            dt.Columns.Add("小計", typeof(int));

            string[] names = { "常凱申", "希姆萊", "溥儀", "貝當", "羅斯福", "戴高樂", "戈林", "史達林" };
            int[] prices = { 19370707, 19390901, 19671017, 19450401, 19450601, 19400618, 19460120, 19530305 };

            // （主要購買）
            for (int i = 0; i < car.buynum.Length; i++)
            {
                if (car.buynum[i] > 0)
                {
                    int subtotal = car.buynum[i] * prices[i];
                    dt.Rows.Add("人物", names[i], car.buynum[i], prices[i], subtotal);
                }
            }

            // 再列加購
            if (!string.IsNullOrEmpty(list.selectedAddon) && list.addonPrice > 0)
            {
                dt.Rows.Add("加購", list.selectedAddon, 1, list.addonPrice, list.addonPrice);
            }

            // 如果 pay 那邊還有額外 CheckBox 加錢，也可以再加一行
            if (pay.moneyy > 0)
            {
                dt.Rows.Add("加購", "其他加購", 1, pay.moneyy, pay.moneyy);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }
    }
}
