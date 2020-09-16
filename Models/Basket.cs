using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_kurs
{
    public class Basket
    {   
        public int userID { get; set; }
        public Dictionary<int,ProductInBasket> productInBasket { get; set; }//ключ-id корзины

        public Basket(int userID)
        {
            productInBasket = new Dictionary<int, ProductInBasket>();
            this.userID = userID;
        }

        public void updateBasket(DataSet dsBasket)//в dsBasket содержится множество корзин,принадлежащих юзеру
        {
            ProductInBasket productInBasket;
            int productID;//переменные для заполнения полей модели
            String country;
            String company;
            String model;
            String series;
            int memory;
            int frequency;
            int capacity;
            String memoryType;
            int maximumThroughput;
            String Interface;
            int price;
            int basketID;
            int countProduct;


            this.productInBasket.Clear();

            if (dsBasket.Tables["Basket"].Rows.Count == 0)
            {
                //MessageBox.Show("Basket not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < dsBasket.Tables["Basket"].Rows.Count; i++)
            {
                productID = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[0].ToString());
                country = dsBasket.Tables["Basket"].Rows[i].ItemArray[1].ToString();
                company = dsBasket.Tables["Basket"].Rows[i].ItemArray[2].ToString();
                model = dsBasket.Tables["Basket"].Rows[i].ItemArray[3].ToString();
                series = dsBasket.Tables["Basket"].Rows[i].ItemArray[4].ToString();
                memory = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[5].ToString());
                frequency = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[6].ToString());
                capacity = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[7].ToString());
                memoryType = dsBasket.Tables["Basket"].Rows[i].ItemArray[8].ToString();
                maximumThroughput = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[9].ToString());
                Interface = dsBasket.Tables["Basket"].Rows[i].ItemArray[10].ToString();
                price = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[11].ToString());

                basketID = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[12].ToString());
                countProduct = Convert.ToInt32(dsBasket.Tables["Basket"].Rows[i].ItemArray[13].ToString());

                productInBasket = new ProductInBasket(productID, country, company, model, series, memory, frequency, capacity, memoryType, maximumThroughput, Interface, price, countProduct);
                this.productInBasket.Add(basketID, productInBasket);
            }
        }

        public void clearBasket(int userID)
        {
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.deleteProductFromBasketByUserID(userID);//удаляем все корзины данного юзера
                    DataSet dsBasket = DB.getBasketMaxInf(userID);//получаем данные о корзине
                    updateBasket(dsBasket);//заполняем поле словаря в корзине новыми данными
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
    }
}
