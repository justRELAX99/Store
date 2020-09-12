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
    public partial class OrderForm : Form
    {
        public Boolean isChanged;
        Basket basket;
        public OrderForm(Basket basket)
        {
            InitializeComponent();
            isChanged = false;
            this.basket = basket;
            orderBasket_bs.DataSource = basket.productInBasket.Select(x => x.Value);
            int allOrderValue=0;
            for(int i = 0; i < basket.productInBasket.Count; i++)
            {
                allOrderValue += basket.productInBasket.ElementAt(i).Value.price * basket.productInBasket.ElementAt(i).Value.count;
            }
            allOrderValue_tb.Text = allOrderValue.ToString();

        }

        private void makeAnOrder_btn_Click(object sender, EventArgs e)
        {
            if(address_tb.Text.Length==0)
            {
                MessageBox.Show("No address specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int orderID;
            DateTime now = DateTime.Now;
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.createOrder(basket.userID, now, "created");//создаем заказ в таблице Order
                    DataSet dsNewOrder = DB.getAllOrdersByDate(basket.userID, now);//получаем  ранее созданный заказ
                    orderID= Convert.ToInt32(dsNewOrder.Tables["Order"].Rows[0].ItemArray[0].ToString());//получаем ID ранее созданного заказа
                    DB.createDelivery(orderID, address_tb.Text, "in stock");//создаем доставку в таблице Delivery
                    for (int i = 0; i < basket.productInBasket.Count; i++)//добавляем все продукты в таблицу OrderProduct
                    {
                        DB.createOrderProduct(orderID, basket.productInBasket.ElementAt(i).Value.ID, basket.productInBasket.ElementAt(i).Value.count);
                    }
                }

                catch
                {
                    MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DB.closeConnection();
                isChanged = true;
                MessageBox.Show("Order successfully created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Connection was not open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orderBasket_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = orderBasket_dgv.CurrentCell.RowIndex;
            int columnIndex = orderBasket_dgv.CurrentCell.ColumnIndex;
            if (basket.productInBasket.Count == 0)//если корзина пуста,то ничего не происходит
                return;
            //if (columnIndex == 12)//клик по count
            //    return;
            ProductInformationForm productInformation = new ProductInformationForm(basket.productInBasket.ElementAt(rowIndex).Value);
            productInformation.ShowDialog();
        }
    }
}
