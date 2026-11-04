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
            dt.Columns.Add("類型", typeof(string));
            dt.Columns.Add("項目", typeof(string));
            dt.Columns.Add("數量", typeof(int));
            dt.Columns.Add("單價", typeof(int));
            dt.Columns.Add("小計", typeof(int));

            string[] names = { "常凱申", "希姆萊", "溥儀", "貝當", "羅斯福", "戴高樂", "戈林", "史達林" };
            int[] prices = { 19370707, 19390901, 19671017, 19450401, 19450601, 19400618, 19460120, 19530305 };

            int grandTotal = 0;

            // 人物（主要購買）
            for (int i = 0; i < car.buynum.Length; i++)
            {
                if (car.buynum[i] > 0)
                {
                    int sub = car.buynum[i] * prices[i];
                    dt.Rows.Add("人物", names[i], car.buynum[i], prices[i], sub);
                    grandTotal += sub;
                }
            }

            // list 的 RadioButton 加購（分開）
            if (!string.IsNullOrEmpty(list.selectedAddon) && list.addonPrice > 0)
            {
                dt.Rows.Add("加購", list.selectedAddon, 1, list.addonPrice, list.addonPrice);
                grandTotal += list.addonPrice;
            }

            // pay 的兩個 CheckBox 加購（分開）
            foreach (var item in pay.addonItems)
            {
                dt.Rows.Add("加購", item.name, 1, item.price, item.price);
                grandTotal += item.price;
            }

            // 總價
            dt.Rows.Add("總計", "", 0, 0, grandTotal);

            dataGridView1.DataSource = dt;

            // 總價列加粗
            if (dataGridView1.Rows.Count > 0)
            {
                int last = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[last].DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                dataGridView1.Rows[last].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
    }
}
