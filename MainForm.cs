using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_kurs
{
    public partial class MainForm : Form
    {
        public User user;
        public List<Product> products = new List<Product>();
        public Basket basket;
        public List<Order> orders=new List<Order>();

        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            login_tb.Text = user.login;
            name_tb.Text = user.name;
            secondName_tb.Text = user.secondName;

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {

                    DataSet dsSaleCard = DB.getSaleCardInfo(user.ID);//получаем данные о скидочной карте


                    DataSet dsProduct = DB.getProductMaxInf();//получаем данные о продукции
                    updateProducts(dsProduct, products);//заполняет лист продуктов
                    products_bs.DataSource = products;//устанавливаем в dgv полученные данные о продукции

                    DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                    basket = new Basket(user.ID);//создаем модель корзины
                    updateBasket(dsBasket, basket);//заполняем поле словаря в корзине
                    basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине

                    DataSet dsOrder = DB.getAllOrders(user.ID);//получаем данные о заказах
                    updateOrders(dsOrder, orders,DB);//заполняем информацию о заказах
                    orders_bs.DataSource = orders;

                    if (dsSaleCard.Tables["SaleCard"].Rows.Count > 0)//если карта существует,то выводим
                    {
                        saleCard_tb.Text= dsSaleCard.Tables["SaleCard"].Rows[0].ItemArray[0].ToString();//получаем ID
                    }
                    else//иначе показываем кнопку,которой можно создать
                    {
                        saleCard_lbl.Visible = false;
                        saleCard_tb.Visible = false;
                        createSaleCard_btn.Visible = true;
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

            int role = user.role;
            if (role == 5)
                store_tc.TabPages[1].Parent = null;
        }

        public void updateOrders(DataSet dsOrder,List<Order> orders,DataBase DB)
        {
            List<int> products = new List<int>();
            int deliveryID=0;
            int ID;//переменные для заполнения полей модели
            DateTime date;
            String status;

            if (dsOrder.Tables["Order"].Rows.Count==0)
            {
                MessageBox.Show("Orders not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orders.Clear();

            for(int i=0;i< dsOrder.Tables["Order"].Rows.Count; i++)
            {
                ID= Convert.ToInt32(dsOrder.Tables["Order"].Rows[i].ItemArray[0].ToString());//ид заказа
                date=Convert.ToDateTime(dsOrder.Tables["Order"].Rows[i].ItemArray[2].ToString());//дата заказа
                status= dsOrder.Tables["Order"].Rows[i].ItemArray[3].ToString();//статус заказа
                try
                {
                    DataSet dsOrderProducts = DB.getAllOrderProduct(ID);//получаем данные из таблицы ЗаказПродукт
                    if (dsOrderProducts.Tables["OrderProduct"].Rows.Count != 0)
                    {
                        products.Clear();
                        for (int j = 0; j < dsOrderProducts.Tables["OrderProduct"].Rows.Count; j++)
                        {
                            products.Add(Convert.ToInt32(dsOrderProducts.Tables["OrderProduct"].Rows[j].ItemArray[2].ToString()));//сохраняем id продуктов
                        }
                    }

                    DataSet dsDelivery = DB.getDelivery(ID);//получаем данные из таблицы Доставка
                    if (dsDelivery.Tables["Delivery"].Rows.Count != 0)
                    {
                        deliveryID=Convert.ToInt32(dsDelivery.Tables["Delivery"].Rows[0].ItemArray[0].ToString());//сохраняем id доставки
                    }
                    Order order = new Order(ID, user.ID, date, status, products, deliveryID);
                    orders.Add(order);
                }
                catch
                {
                    MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
        }

        public void updateProducts(DataSet dsProduct,List<Product> products)
        {
            Product product;
            int ID;//переменные для заполнения полей модели
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

            if(dsProduct.Tables["Product"].Rows.Count==0)
            {
                MessageBox.Show("Products not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            products.Clear();

            for (int i = 0; i < dsProduct.Tables["Product"].Rows.Count; i++)
            {
                ID = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[0].ToString());
                country = dsProduct.Tables["Product"].Rows[i].ItemArray[1].ToString();
                company= dsProduct.Tables["Product"].Rows[i].ItemArray[2].ToString();
                model= dsProduct.Tables["Product"].Rows[i].ItemArray[3].ToString();
                series= dsProduct.Tables["Product"].Rows[i].ItemArray[4].ToString();
                memory= Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[5].ToString());
                frequency= Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[6].ToString());
                capacity= Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[7].ToString());
                memoryType= dsProduct.Tables["Product"].Rows[i].ItemArray[8].ToString();
                maximumThroughput= Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[9].ToString());
                Interface= dsProduct.Tables["Product"].Rows[i].ItemArray[10].ToString();
                price= Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[11].ToString());

                product = new Product(ID, country, company, model, series, memory, frequency, capacity, memoryType, maximumThroughput, Interface, price);
                products.Add(product);
            }
        }

        public void updateBasket(DataSet dsBasket,Basket basket)//в dsBasket содержится множество корзин,принадлежащих юзеру
        {
            Product product;
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


            if (dsBasket.Tables["Basket"].Rows.Count == 0)
            {
                MessageBox.Show("Basket not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            basket.productInBasket.Clear();

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

                product = new Product(productID, country, company, model, series, memory, frequency, capacity, memoryType, maximumThroughput, Interface, price);
                basket.productInBasket.Add(basketID, product);
            }
        }



        private void changeData_btn_Click(object sender, EventArgs e)
        {
            login_tb.ReadOnly = false;
            name_tb.ReadOnly = false;
            secondName_tb.ReadOnly = false;

            saveData_btn.Visible = true;
            cancel_btn.Visible = true;
        }

        private void saveData_btn_Click(object sender, EventArgs e)
        {
            String login = login_tb.Text;
            String name = name_tb.Text;
            String secondName = secondName_tb.Text;

            Boolean exists;

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    if (login.Length != 0)
                    {
                        exists = DB.checkLogin(login);

                        if (exists)//если есть такой пользователь с таким логином,выводим ошибку
                        {
                            MessageBox.Show("User with this login already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (name.Length != 0)
                            {
                                if (secondName.Length != 0)
                                {
                                    DB.changeUserData(login, name, secondName,user.login,user.name,user.secondName);//меняем данные в бд
                                    user.login = login;//меняем логин в классе
                                    user.name = name;//меняем имя в классе
                                    user.secondName = secondName;//меняем фамилию в классе

                                    //cancel_btn_Click(sender, e);//потестить,тк код ниже делает то же самое,что и эта строчка(нажание кнопки Cancel)

                                    login_tb.Text = login;//меняем логин в tabPage
                                    login_tb.ReadOnly = true;

                                    name_tb.Text = name;//меняем имя в tabPage
                                    name_tb.ReadOnly = true;

                                    secondName_tb.Text = secondName;//меняем фамилию в tabPage
                                    secondName_tb.ReadOnly = true;

                                    saveData_btn.Visible = false;
                                    cancel_btn.Visible = false;
                                    MessageBox.Show("User changed successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Invalid cell value : Second name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid cell value : Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid cell value : Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            login_tb.Text = user.login;//меняем логин в tabPage
            login_tb.ReadOnly = true;

            name_tb.Text = user.name;//меняем имя в tabPage
            name_tb.ReadOnly = true;

            secondName_tb.Text = user.secondName;//меняем фамилию в tabPage
            secondName_tb.ReadOnly = true;

            saveData_btn.Visible = false;
            cancel_btn.Visible = false;
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            cancelPassword_btn.Visible = true;
            savePassword_btn.Visible = true;

            newPassword_lbl.Visible = true;
            confirmPassword_lbl.Visible = true;
            oldPassword_lbl.Visible = true;

            newPassword_tb.Visible = true;
            confirmPassword_tb.Visible = true;
            oldPassword_tb.Visible = true;
        }

        private void cancelPassword_btn_Click(object sender, EventArgs e)
        {
            cancelPassword_btn.Visible = false;
            savePassword_btn.Visible = false;

            newPassword_lbl.Visible = false;
            confirmPassword_lbl.Visible = false;
            oldPassword_lbl.Visible = false;

            newPassword_tb.Text = "";
            confirmPassword_tb.Text = "";
            oldPassword_tb.Text = "";

            oldPassword_tb.Visible = false;
            newPassword_tb.Visible = false;
            confirmPassword_tb.Visible = false;
        }

        private void savePassword_btn_Click(object sender, EventArgs e)
        {
            String newPassword = newPassword_tb.Text;
            String confirmPassword = confirmPassword_tb.Text;
            String oldPasswordTb = oldPassword_tb.Text;
            String oldPassword = user.password;
            try
            {
                if (oldPasswordTb == oldPassword)
                {
                    if (newPassword == confirmPassword)
                    {
                        if (oldPassword != newPassword)
                        {
                            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
                            if (DB.getConnection().State == ConnectionState.Open)//если подключились
                            {
                                DB.chagePassword(newPassword,user.password);//меняем пароль в бд
                                user.password = newPassword;//меняем пароль в классе

                                //cancelPassword_btn_Click(sender, e);
                                cancelPassword_btn.Visible = false;
                                savePassword_btn.Visible = false;

                                newPassword_lbl.Visible = false;
                                confirmPassword_lbl.Visible = false;
                                oldPassword_lbl.Visible = false;

                                newPassword_tb.Text = "";
                                confirmPassword_tb.Text = "";
                                oldPassword_tb.Text = "";

                                oldPassword_tb.Visible = false;
                                newPassword_tb.Visible = false;
                                confirmPassword_tb.Visible = false;

                                MessageBox.Show("Password changed successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DB.closeConnection();
                            }

                            else
                            {
                                MessageBox.Show("Connection was not open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The old password is the same as the new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password mismatch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void createSaleCard_btn_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.createSaleCard(user.ID);//создаем карту
                    saleCard_lbl.Visible = true;//отображаем элементы,куда выводим данные о скидочной карте
                    saleCard_tb.Visible = true;

                    DataSet dsSaleCard = DB.getSaleCardInfo(user.ID);
                    if (dsSaleCard.Tables["SaleCard"].Rows.Count > 0)//если карта существует,то выводим
                    {
                        saleCard_tb.Text = dsSaleCard.Tables["SaleCard"].Rows[0].ItemArray[0].ToString();//получаем ID
                    }
                    createSaleCard_btn.Visible = false;

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

        private void products_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex;
            rowIndex = products_dgv.CurrentCell.RowIndex;
            ProductInformationForm productInformation = new ProductInformationForm(products[rowIndex]);
            productInformation.ShowDialog();
        }

        private void addToBasket_btn_Click(object sender, EventArgs e)
        {
            int rowIndex;
            int productID;
            Boolean checkProduct = false;//если меняется на true,то данный товар уже есть в корзине

            rowIndex = products_dgv.CurrentCell.RowIndex;
            productID = products[rowIndex].ID;

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    checkProduct = DB.checkProductInBasket(user.ID, productID);
                    if(checkProduct==false)//если товара нет в корзине,то добавляем его
                    {
                        DB.addProductToBasket(user.ID, productID);
                        MessageBox.Show("Product added to basket successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                        updateBasket(dsBasket, basket);//заполняем поле словаря в корзине
                        basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
                    }
                    else
                    {
                        MessageBox.Show("The product is already in the basket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void basket_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex;
            rowIndex = basket_dgv.CurrentCell.RowIndex;
            ProductInformationForm productInformation = new ProductInformationForm(basket.productInBasket.ElementAt(rowIndex).Value);
            productInformation.ShowDialog();
        }

        private void deleteFromBasket_btn_Click(object sender, EventArgs e)
        {
            int rowIndex;
            int productID;
            int basketID;
            rowIndex = basket_dgv.CurrentCell.RowIndex;
            basketID = basket.productInBasket.ElementAt(rowIndex).Key;
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.deleteProductFromBasketByBasketID(user.ID, basketID);
                    MessageBox.Show("Product deleted from basket successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                    updateBasket(dsBasket, basket);//заполняем поле словаря в корзине
                    basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
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

        private void makeAnOrder_btn_Click(object sender, EventArgs e)
        {
            if(basket_dgv.RowCount<=0)
            {
                MessageBox.Show("Basket is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrderForm orderForm = new OrderForm(basket);
                orderForm.ShowDialog();
            }

        }

        private void orders_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex;
            int orderID;
            rowIndex = orders_dgv.CurrentCell.RowIndex;
            OrderInformationForm orderInformation = new OrderInformationForm(orders[rowIndex]);
            orderInformation.ShowDialog();
        }
    }
}
