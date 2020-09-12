using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_kurs
{
    public partial class OrderInformationForm : Form
    {
        Order order;
        public OrderInformationForm(Order order)
        {
            InitializeComponent();
            int allOrderValue = 0;
            this.order = order;
            orderProduct_bs.DataSource = order.products;
            orderDate_tb.Text = order.date.ToString();
            orderStatus_tb.Text = order.status;
            deliveryStatus_tb.Text = order.delivery.status;
            deliveryAddres_tb.Text = order.delivery.address;
            for(int i=0;i<order.products.Count;i++)
            {
                allOrderValue += order.products[i].price * order.products[i].count;
            }
            allOrderValue_tb.Text = allOrderValue.ToString();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void products_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = orderProducts_dgv.CurrentCell.RowIndex;
            ProductInformationForm productInformation = new ProductInformationForm(order.products[rowIndex]);
            productInformation.ShowDialog();
        }
    }
}
