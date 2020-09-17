using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public Administration administration;
        public User user;
        public List<Product> products;
        public Basket basket;
        public List<Order> orders;
        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            login_tb.Text = user.login;
            name_tb.Text = user.name;
            secondName_tb.Text = user.second_name;
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    administration = new Administration();
                    products = new List<Product>();
                    orders = new List<Order>();
                    DataSet dsSaleCard = DB.getSaleCardInfo(user.ID);//получаем данные о скидочной карте

                    DataSet dsProduct = DB.getProductMaxInf();//получаем данные о продукции
                    products=updateProducts(dsProduct);//заполняет лист продуктов
                    products_bs.DataSource = products;//устанавливаем в dgv полученные данные о продукции
                    
                    DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                    basket = new Basket(user.ID);//создаем модель корзины
                    basket.updateBasket(dsBasket);//заполняем поле словаря в корзине
                    basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине


                    DataSet dsOrder = DB.getAllOrders(user.ID);//получаем данные о заказах
                    orders=updateOrders(dsOrder,DB);//заполняем информацию о заказах
                    orders_bs.DataSource = orders;

                    //Для роли администратора
                    administration.setAllDataFromDB(DB);//заполняем дата сеты из базы
                    company_bs.DataSource = administration.dsCompany.Tables["Company"];//заполняем биндинг соурс датасетами
                    model_bs.DataSource = administration.dsModel.Tables["Model"];
                    characteristic_bs.DataSource = administration.dsCharacteristic.Tables["Characteristic"];
                    //productsForAdmin_bs.DataSource = administration.productsForAdmin;
                    user_bs.DataSource = administration.dsUser.Tables["User"];
                    productsForAdmin_bs.DataSource = administration.dsProductForAdmin.Tables["Product"];
                    productsForAdmin_dgv.CellValueChanged += productsForAdmin_dgv_CellValueChanged;

                    updateProductsForAdminDGV();//обновляем итемы в комбобоксах для датагрида productsForAdmin
                    var arrayRole = administration.dsRole.Tables["Role"].Rows.OfType<DataRow>().Select(x => x.ItemArray[0]).ToArray();//в датагриде юзерс поле роль можно выбирать только те,которые есть в таблице Role 
                    var columnRole = users_dgv.Columns[1] as DataGridViewComboBoxColumn;
                    columnRole.Items.AddRange(arrayRole);


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

                catch(Exception e)
                {
                    MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DB.closeConnection();
            }
            else
            {
                MessageBox.Show("Connection was not open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int role = user.role;
            if (role == 2)
            {
                productsForAdmin_dgv.Visible = false;
                saveProducts_btn.Visible = false;
                store_tc.TabPages["company_tp"].Parent = null;
                store_tc.TabPages["model_tp"].Parent = null;
                store_tc.TabPages["characteristic_tp"].Parent = null;
                store_tc.TabPages["users_tp"].Parent = null;
            }
        }

        public void updateProductsForAdminDGV()
        {
            var arrayCountry = administration.dsCompany.Tables["Company"].Rows.OfType<DataRow>().Select(x => x.ItemArray[0]).ToArray();
            var columnCountry = productsForAdmin_dgv.Columns[1] as DataGridViewComboBoxColumn;
            columnCountry.Items.Clear();
            columnCountry.Items.AddRange(arrayCountry);

            var arrayCharacteristic = administration.dsCharacteristic.Tables["Characteristic"].Rows.OfType<DataRow>().Select(x => x.ItemArray[0]).ToArray();
            var columnCharacteristic = productsForAdmin_dgv.Columns[4] as DataGridViewComboBoxColumn;
            columnCharacteristic.Items.Clear();
            columnCharacteristic.Items.AddRange(arrayCharacteristic);

            var arrayModel = administration.dsModel.Tables["Model"].Rows.OfType<DataRow>().Select(x => x.ItemArray[0]).ToArray();
            var columnModel = productsForAdmin_dgv.Columns[11] as DataGridViewComboBoxColumn;
            columnModel.Items.Clear();
            columnModel.Items.AddRange(arrayModel);
        }

        public List<Order> updateOrders(DataSet dsOrder,DataBase DB)
        {
            List<Order> orders= new List<Order>();
            List<ProductInOrder> products;
            ProductInOrder product;
            int productID;
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
            int countProduct;

            Delivery delivery=new Delivery();
            int deliveryID;
            int deliveryOder;
            String deliveryAddress;
            String deliveryStatus;

            int orderID;//переменные для заполнения полей модели
            DateTime date;
            String status;

            if (dsOrder.Tables["Order"].Rows.Count==0)
            {
                //MessageBox.Show("Orders not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return orders;
            }

            for (int i=0;i< dsOrder.Tables["Order"].Rows.Count; i++)
            {
                orderID= Convert.ToInt32(dsOrder.Tables["Order"].Rows[i].ItemArray[0].ToString());//ид заказа
                date=Convert.ToDateTime(dsOrder.Tables["Order"].Rows[i].ItemArray[2].ToString());//дата заказа
                status= dsOrder.Tables["Order"].Rows[i].ItemArray[3].ToString();//статус заказа
                
                try
                {
                    products = new List<ProductInOrder>();
                    DataSet dsOrderProducts = DB.getAllOrderProduct(orderID);//получаем данные из таблицы ЗаказПродукт
                    if (dsOrderProducts.Tables["OrderProduct"].Rows.Count != 0)
                    {                     
                        for (int j = 0; j < dsOrderProducts.Tables["OrderProduct"].Rows.Count; j++)
                        {
                            productID = Convert.ToInt32(dsOrderProducts.Tables["OrderProduct"].Rows[j].ItemArray[2].ToString());
                            countProduct= Convert.ToInt32(dsOrderProducts.Tables["OrderProduct"].Rows[j].ItemArray[3].ToString());
                            DataSet dsProduct = DB.getProduct(productID);//получаем данные о продукции

                            if (dsProduct.Tables["Product"].Rows.Count == 0)
                            {
                                MessageBox.Show("Products "+productID+" not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            country = dsProduct.Tables["Product"].Rows[0].ItemArray[1].ToString();
                            company = dsProduct.Tables["Product"].Rows[0].ItemArray[2].ToString();
                            model = dsProduct.Tables["Product"].Rows[0].ItemArray[3].ToString();
                            series = dsProduct.Tables["Product"].Rows[0].ItemArray[4].ToString();
                            memory = Convert.ToInt32(dsProduct.Tables["Product"].Rows[0].ItemArray[5].ToString());
                            frequency = Convert.ToInt32(dsProduct.Tables["Product"].Rows[0].ItemArray[6].ToString());
                            capacity = Convert.ToInt32(dsProduct.Tables["Product"].Rows[0].ItemArray[7].ToString());
                            memoryType = dsProduct.Tables["Product"].Rows[0].ItemArray[8].ToString();
                            maximumThroughput = Convert.ToInt32(dsProduct.Tables["Product"].Rows[0].ItemArray[9].ToString());
                            Interface = dsProduct.Tables["Product"].Rows[0].ItemArray[10].ToString();
                            price = Convert.ToInt32(dsProduct.Tables["Product"].Rows[0].ItemArray[11].ToString());

                            product = new ProductInOrder(orderID, country, company, model, series, memory, frequency, capacity, memoryType, maximumThroughput, Interface, price,countProduct);
                           
                            products.Add(product);//сохраняем информацию о продукте
                        }
                    }

                    DataSet dsDelivery = DB.getDelivery(orderID);//получаем данные из таблицы Доставка
                    if (dsDelivery.Tables["Delivery"].Rows.Count != 0)
                    {
                        deliveryID=Convert.ToInt32(dsDelivery.Tables["Delivery"].Rows[0].ItemArray[0].ToString());//сохраняем данные о доставке
                        deliveryOder= Convert.ToInt32(dsDelivery.Tables["Delivery"].Rows[0].ItemArray[1].ToString());//сохраняем id доставки
                        deliveryAddress = dsDelivery.Tables["Delivery"].Rows[0].ItemArray[2].ToString();
                        deliveryStatus= dsDelivery.Tables["Delivery"].Rows[0].ItemArray[3].ToString();
                        delivery = new Delivery(deliveryID, deliveryOder, deliveryAddress, deliveryStatus);
                    }
                    Order order = new Order(orderID, user.ID, date, status, products, delivery);
                    orders.Add(order);
                }
                catch
                {
                    MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
            return orders;
        }

        public List<Product> updateProducts(DataSet dsProduct)
        {
            List<Product> products = new List<Product>();
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

            if (dsProduct.Tables["Product"].Rows.Count==0)
            {
                MessageBox.Show("Products not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return products;
            }

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
            return products;
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
                    if (login.Length == 0)//если логин пустой,то выход
                    {
                        MessageBox.Show("Invalid cell value : Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (login != user.login)//если логин изменился
                    {
                        exists = DB.checkLogin(login);//то проверяем наличие нового логина в бд
                        if (exists)//если есть такой пользователь с таким логином,выводим ошибку
                        {
                            MessageBox.Show("User with this login already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (name.Length == 0)
                    {
                        MessageBox.Show("Invalid cell value : Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (secondName.Length == 0)
                    {
                        MessageBox.Show("Invalid cell value : Second name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DB.changeUserData(login, name, secondName,user.login,user.name,user.second_name);//меняем данные в бд
                    user.login = login;//меняем логин в классе
                    user.name = name;//меняем имя в классе
                    user.second_name = secondName;//меняем фамилию в классе

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

            secondName_tb.Text = user.second_name;//меняем фамилию в tabPage
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
            if (products.Count == 0)//если продуктов нет,то ничего не происходит
                return;
            rowIndex = products_dgv.CurrentCell.RowIndex;
            ProductInformationForm productInformation = new ProductInformationForm(products[rowIndex]);
            productInformation.ShowDialog();
        }

        private void addToBasket_btn_Click(object sender, EventArgs e)
        {
            int rowIndex;
            int productID;
            int basketID = 0;//если меняется на любое число,то данный товар уже есть в корзине под этим индексом

            rowIndex = products_dgv.CurrentCell.RowIndex;//получаем индекс выбранной строки
            productID = products[rowIndex].ID;//находим в модели строку по такому индексу

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    basketID = DB.checkProductInBasket(user.ID, productID);
                    if(basketID==0)//если товара нет в корзине,то добавляем его
                    {
                        DB.addProductToBasket(user.ID, productID);
                        MessageBox.Show("Product added to basket successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                        basket.updateBasket(dsBasket);//заполняем поле словаря в корзине
                        basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
                    }
                    else//если товар уже есть в корзине,то меняем его число на +1
                    {
                        DB.changeCountProductInBasket(basketID, user.ID, 1);

                        DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                        basket.updateBasket(dsBasket);//заполняем поле словаря в корзине
                        basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине

                        MessageBox.Show("This product was added again successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int rowIndex = basket_dgv.CurrentCell.RowIndex;
            int columnIndex = basket_dgv.CurrentCell.ColumnIndex;
            if (basket.productInBasket.Count == 0)//если корзина пуста,то ничего не происходит
                return;
            //if (columnIndex == 12)//клик по count
            //    return;
            if (columnIndex == 13)
            {
                if (basket.productInBasket.ElementAt(rowIndex).Value.inOrder)
                {
                    basket.productInBasket.ElementAt(rowIndex).Value.inOrder = false;
                    basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
                }
                else
                {
                    basket.productInBasket.ElementAt(rowIndex).Value.inOrder = true;
                    basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
                }
                return;
            }
            ProductInformationForm productInformation = new ProductInformationForm(basket.productInBasket.ElementAt(rowIndex).Value);
            productInformation.ShowDialog();
        }

        private void deleteFromBasket_btn_Click(object sender, EventArgs e)
        {
            int rowIndex;
            int basketID;
            if (basket.productInBasket.Count == 0)//если корзина пуста,то ничего не делаем
            {
                MessageBox.Show("Basket is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rowIndex = basket_dgv.CurrentCell.RowIndex;
            basketID = basket.productInBasket.ElementAt(rowIndex).Key;
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    if (basket.productInBasket.ElementAt(rowIndex).Value.count==1)//если число товаров в корзине равно одному,то удаляем полностью запись
                    {
                        DB.deleteProductFromBasketByBasketID(user.ID, basketID);
                        MessageBox.Show("Product deleted from basket successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                        basket.updateBasket(dsBasket);//заполняем поле словаря в корзине
                        basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
                    }
                    else//если число товаров больше 1,то меняем число товраом на -1
                    {
                        DB.changeCountProductInBasket(basketID, user.ID, -1);
                        DataSet dsBasket = DB.getBasketMaxInf(user.ID);//получаем данные о корзине
                        basket.updateBasket(dsBasket);//заполняем поле словаря в корзине
                        basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
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

        private void makeAnOrder_btn_Click(object sender, EventArgs e)
        {
            Basket basketForOrder=new Basket(user.ID);
            if(basket.productInBasket.Count<=0)
            {
                MessageBox.Show("Basket is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < basket.productInBasket.Count; i++)
                {
                    if (basket.productInBasket.ElementAt(i).Value.inOrder)
                    {
                        basketForOrder.productInBasket.Add(basket.productInBasket.ElementAt(i).Key, basket.productInBasket.ElementAt(i).Value);//добавляем в переменную все товары из корзины,которые помечены как в заказ
                    }
                }
                if (basketForOrder.productInBasket.Count != 0)
                {
                    OrderForm orderForm = new OrderForm(basketForOrder);
                    orderForm.ShowDialog();
                    if (orderForm.isChanged)
                    {
                        basket.clearBasket(user.ID);
                        basket_bs.DataSource = basket.productInBasket.Select(x => x.Value);//устанавливаем данные в dgv о корзине
                        DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
                        if (DB.getConnection().State == ConnectionState.Open)//если подключились
                        {
                            try
                            {
                                DataSet dsOrder = DB.getAllOrders(user.ID);//получаем данные о заказах
                                orders=updateOrders(dsOrder,DB);//заполняем информацию о заказах
                                orders_bs.DataSource = orders;
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

        }

        private void orders_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex;
            if (orders.Count == 0)//если заказов нет,то ничего не происходит
                return;
            rowIndex = orders_dgv.CurrentCell.RowIndex;//получаем индекс строки,куда произошел двойной клик
            OrderInformationForm orderInformation = new OrderInformationForm(orders[rowIndex]);//передаем в форму заказ по данному индексу из модели
            orderInformation.ShowDialog();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }

        private void saveCompany_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < company_dgv.Rows.Count - 1; i++)//проверкао столбцов на пустоту
            {
                if (string.IsNullOrEmpty(company_dgv.Rows[i].Cells["nameDataGridViewTextBoxColumn1"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.saveCompany(administration.dsCompany);
                    administration.setAllDataCompany(DB);
                    company_bs.DataSource = administration.dsCompany.Tables["Company"];//заполняем биндинг соурс датасетами
                    updateProductsForAdminDGV();
                    MessageBox.Show("Saving was successful", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void saveModel_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < model_dgv.Rows.Count - 1; i++)//проверкао столбцов на пустоту
            {
                if (string.IsNullOrEmpty(model_dgv.Rows[i].Cells["nameDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns model is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.saveModel(administration.dsModel);
                    administration.setAllDataModel(DB);
                    model_bs.DataSource = administration.dsModel.Tables["Model"];//заполняем биндинг соурс датасетами

                    updateProductsForAdminDGV();
                    MessageBox.Show("Saving was successful", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void characteristic_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < characteristic_dgv.Rows.Count - 1; i++)//проверкао столбцов на пустоту
            {
                if (string.IsNullOrEmpty(characteristic_dgv.Rows[i].Cells["memoryDataGridViewTextBoxColumn2"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns memory is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(characteristic_dgv.Rows[i].Cells["frequencyDataGridViewTextBoxColumn2"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns frequency is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(characteristic_dgv.Rows[i].Cells["capacityDataGridViewTextBoxColumn2"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns capacity is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(characteristic_dgv.Rows[i].Cells["memorytypeDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns memory type is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(characteristic_dgv.Rows[i].Cells["maximumthroughputDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns maximum throughput is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(characteristic_dgv.Rows[i].Cells["interfaceDataGridViewTextBoxColumn2"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns interface is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.saveCharacteristic(administration.dsCharacteristic);//сохраняем
                    administration.setAllDataCharacteristic(DB);//обнавляем данные в модели
                    characteristic_bs.DataSource = administration.dsCharacteristic.Tables["Characteristic"];//заполняем биндинг соурс датасетами
                    updateProductsForAdminDGV();
                    MessageBox.Show("Saving was successful", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void characteristic_dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)//для ввода только цифр в определнные колонки
        {
            TextBox tb = (TextBox)e.Control;
            int columnCell = characteristic_dgv.CurrentCell.ColumnIndex;
            string nameCell = characteristic_dgv.Columns[columnCell].Name;
            tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
            if ((nameCell != "memorytypeDataGridViewTextBoxColumn") && (nameCell != "interfaceDataGridViewTextBoxColumn2"))//4-6
            {
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)//для ввода только цифр в определнные колонки
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                { 
                    e.Handled = true; 
                }
            }
        }

        private void company_dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)//чтобы обязательно было заполнять все ячейки
        {
            if ((e.FormattedValue == null) || string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
            }
        }

        private void company_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)//чтобы обязательно было заполнять все ячейки
        {
            DataGridView dgv = sender as DataGridView;
            dgv.CellValidating -= company_dgv_CellValidating;
        }

        private void company_dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)//чтобы обязательно было заполнять все ячейки
        {
            DataGridView dgv = sender as DataGridView;
            dgv.CellValidating += company_dgv_CellValidating;
        }
        private void saveUsers_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users_dgv.Rows.Count - 1; i++)//проверкао столбцов на пустоту
            {
                if (string.IsNullOrEmpty(users_dgv.Rows[i].Cells["roleDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns role is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(users_dgv.Rows[i].Cells["loginDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns login is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(users_dgv.Rows[i].Cells["passwordDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns password is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(users_dgv.Rows[i].Cells["nameDataGridViewTextBoxColumn2"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(users_dgv.Rows[i].Cells["dataGridViewTextBoxColumn1"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns second name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.saveUser(administration.dsUser);//сохраняем
                    administration.setAllDataUsers(DB);//обнавляем данные в модели
                    user_bs.DataSource = administration.dsUser.Tables["User"];//заполняем биндинг соурс датасетами
                    MessageBox.Show("Saving was successful", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void saveProducts_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < productsForAdmin_dgv.Rows.Count-1; i++)//проверкао столбцов на пустоту
            {
                if (string.IsNullOrEmpty(productsForAdmin_dgv.Rows[i].Cells["companyIDDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns companyID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(productsForAdmin_dgv.Rows[i].Cells["characteristicIDDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns characteristicID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(productsForAdmin_dgv.Rows[i].Cells["modelIDDataGridViewTextBoxColumn"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns modelID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(productsForAdmin_dgv.Rows[i].Cells["priceDataGridViewTextBoxColumn2"].Value.ToString()))
                {
                    MessageBox.Show("One of the columns price is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    DB.saveProduct(administration.dsProductForAdmin);//сохраняем
                    administration.setdsProductsForAdmin(DB);//обнавляем данные в модели
                    productsForAdmin_bs.DataSource = administration.dsProductForAdmin.Tables["Product"];//заполняем биндинг соурс датасетами
                    MessageBox.Show("Saving was successful", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void productsForAdmin_dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //updateProductsForAdminDGV();
        }

        private void productsForAdmin_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.CurrentCell.ColumnIndex == 1)
            {
                int companyID = (int)dgv.CurrentCell.Value;
                List<string> companyData = new List<string>();
                companyData = administration.getCompanyData(companyID);
                if (companyData.Count == 0)
                    return;
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["companyIDDataGridViewTextBoxColumn"].Value = companyID;
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["companyDataGridViewTextBoxColumn2"].Value = companyData[0];
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["countryDataGridViewTextBoxColumn2"].Value = companyData[1];
                dgv.Refresh();
            }
            if (dgv.CurrentCell.ColumnIndex == 4)
            {
                int characteristicID = (int)dgv.CurrentCell.Value;
                List<string> characteristicData = new List<string>(); ;
                characteristicData = administration.getCharacteristicData(characteristicID);
                if (characteristicData.Count == 0)
                    return;
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["characteristicIDDataGridViewTextBoxColumn"].Value = characteristicID;
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["memoryDataGridViewTextBoxColumn3"].Value = int.Parse(characteristicData[0]);
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["frequencyDataGridViewTextBoxColumn3"].Value = int.Parse(characteristicData[1]);
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["capacityDataGridViewTextBoxColumn3"].Value = int.Parse(characteristicData[2]);
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["memorytypeDataGridViewTextBoxColumn1"].Value = characteristicData[3];
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["maximumthroughputDataGridViewTextBoxColumn1"].Value = int.Parse(characteristicData[4]);
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["interfaceDataGridViewTextBoxColumn3"].Value = characteristicData[5];
                dgv.Refresh();
            }
            if (dgv.CurrentCell.ColumnIndex == 11)
            {
                int modelID = (int)dgv.CurrentCell.Value;
                List<string> modelData = new List<string>(); ;
                modelData = administration.getModelData(modelID);
                if (modelData.Count == 0)
                    return;
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["modelIDDataGridViewTextBoxColumn"].Value = modelID; 
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["modelDataGridViewTextBoxColumn2"].Value = modelData[0];
                productsForAdmin_dgv.Rows[dgv.CurrentCell.RowIndex].Cells["seriesDataGridViewTextBoxColumn3"].Value = modelData[1];
                dgv.Refresh();
            }
        }

        private void productsForAdmin_dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)//запись только цифр в price
        {
            try
            {
                TextBox tb = (TextBox)e.Control;
                int columnCell = productsForAdmin_dgv.CurrentCell.ColumnIndex;
                string nameCell = productsForAdmin_dgv.Columns[columnCell].Name;
                tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
                if (nameCell == "priceDataGridViewTextBoxColumn2")
                {
                    tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
                }
            }
            catch
            {

            }
        }

        private void oldPassword_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void users_dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox tb = (TextBox)e.Control;
                int columnCell = users_dgv.CurrentCell.ColumnIndex;
                string nameCell = users_dgv.Columns[columnCell].Name;
                tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
                if (nameCell == "passwordDataGridViewTextBoxColumn")
                {
                    tb.KeyPress += new KeyPressEventHandler(oldPassword_tb_KeyPress);
                }
            }
            catch
            {

            }
        }
    }
}
