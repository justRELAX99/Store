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
    public partial class ProductInformationForm : Form
    {
        public ProductInformationForm(int productID)
        {
            InitializeComponent();

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DataSet dsProduct = DB.getProduct(productID);
                    if (dsProduct.Tables["Product"].Rows.Count > 0)//если нашли продукт
                    {
                        country_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[1].ToString();//заполняем текст боксы
                        company_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[2].ToString();
                        model_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[3].ToString();
                        series_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[4].ToString();
                        memory_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[5].ToString();
                        frequency_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[6].ToString();
                        capacity_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[7].ToString();
                        memoryType_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[8].ToString();
                        maxThroughput_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[9].ToString();
                        interface_tb.Text = dsProduct.Tables["Product"].Rows[0].ItemArray[10].ToString();
                        price_tb.Text= dsProduct.Tables["Product"].Rows[0].ItemArray[11].ToString();
                    }
                    else//иначе 
                    {

                    }
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
