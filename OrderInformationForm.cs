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
        public OrderInformationForm(Order order)
        {
            InitializeComponent();
            List<Product> products=new List<Product>();
            Product product;
            int productID;
            String country;
            String company;
            String model;
            String series;
            int price;

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    for (int i = 0; i < order.products.Count; i++)
                    {
                        DataSet dsProduct = DB.getProduct(order.products[i]);//получаем данные о конкретном продукте
                        if (dsProduct.Tables["Product"].Rows.Count == 0)
                        {
                            MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        productID = Convert.ToInt32(dsProduct.Tables["Product"].Rows[0].ItemArray[0].ToString());
                        country = dsProduct.Tables["Product"].Rows[0].ItemArray[1].ToString();
                        company = dsProduct.Tables["Product"].Rows[0].ItemArray[2].ToString();
                        model = dsProduct.Tables["Product"].Rows[0].ItemArray[3].ToString();
                        series = dsProduct.Tables["Product"].Rows[0].ItemArray[4].ToString();
                        price = Convert.ToInt32(dsProduct.Tables["Product"].Rows[0].ItemArray[5].ToString());
                        product = new Product() { ID = productID, country = country, company = company, model = model, series = series, price = price };//заполняем информацию о продукте
                        products.Add(product);//сохраняем продукт
                    }
                    orderProduct_bs.DataSource = products;
                }

                catch
                {
                    MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DB.closeConnection();
            }
            else
            {
                MessageBox.Show("Connection was not open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
