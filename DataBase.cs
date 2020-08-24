using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_kurs
{
    class DataBase
    {
        private SqlConnection conn;
        public DataBase()
        {
            String dataSource = "DESKTOP-VRM1SLK\\SQLEXPRESS";
            String nameDataBase = "Store";
            String userID = "sa";
            String password = "123";
            SqlConnection conn = ConnectToSql(dataSource, nameDataBase, userID, password);
            this.conn = conn;
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection was not open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlConnection ConnectToSql(String dataSource, String nameDataBase, String userID, String password)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=" + dataSource + ";"
                                   + "Initial Catalog=" + nameDataBase + ";"
                                   + "User ID=" + userID + ";"
                                   + "Password=" + password + ";";
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                String msgError = "Connection error";

                foreach (SqlError err in ex.Errors)
                {
                    msgError += "\n" + "Message:" + err.Message;
                    msgError += "\n" + "Error:";
                    if (err.Number == -1)
                        msgError += "Invalid server name";
                    else
                        if (err.Number == 4060)
                        msgError += "Invalid database name";
                    else
                            if (err.Number == 18456)
                        msgError += "The username or password you entered is incorrect";
                    else
                        msgError += "Unknown error";
                }
                MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                String msgError = "Connection error";
                msgError += "\n" + "Error:Unknown error";
                MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public Boolean checkLogin(String login)//проверка,есть ли в бд юзер с таким логином
        {
            Boolean checkData = false;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdSelect = conn.CreateCommand();
            cmdSelect.CommandText = "SELECT * " + '\n' +
                                    "FROM [User]" + '\n' +
                                    "WHERE Login=@login";

            cmdSelect.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;

            da.SelectCommand = cmdSelect;
            DataSet ds = new DataSet();
            da.Fill(ds, "[User]");
            if (ds.Tables["[User]"].Rows.Count > 0)
                checkData = true;

            return checkData;
        }

        public User checkLoginPassword(String login, String password)//проверка,есть ли в бд юзер с таким логином и паролем,если есть,то возвращаем его роль.
        {
            User user;

            int ID;
            int role;
            String name;
            String secondName;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdSelect = conn.CreateCommand();
            cmdSelect.CommandText = "SELECT * " + '\n' +
                                    "FROM [User]" + '\n' +
                                    "WHERE Login=@login AND Password=@password";

            cmdSelect.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
            cmdSelect.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

            da.SelectCommand = cmdSelect;
            DataSet ds = new DataSet();
            da.Fill(ds, "[User]");

            if (ds.Tables["[User]"].Rows.Count > 0)
            {
                ID = Convert.ToInt32(ds.Tables["[User]"].Rows[0].ItemArray[0].ToString());//получаем ID
                role = Convert.ToInt32(ds.Tables["[User]"].Rows[0].ItemArray[1].ToString());//получаем роль
                name = ds.Tables["[User]"].Rows[0].ItemArray[4].ToString();//получаем имя
                secondName = ds.Tables["[User]"].Rows[0].ItemArray[5].ToString();//получаем Фамилию
                user = new User(ID, role, login, password, name, secondName);
            }
            else
            {
                user = new User();
            }
            return user;
        }

        public void createUser(String login, String password, String name, String secondName)//создаем пользователя и переходим в AuthForm
        {
            SqlCommand cmdInsert = conn.CreateCommand();
            int role = 2;
            cmdInsert.CommandText = "INSERT INTO [User]   (Role,Login,Password,Name,[Second name])" + '\n' +
                                    "VALUES(@role,@login, @password,@name,@second_name)";

            cmdInsert.Parameters.AddWithValue("@role", role);
            cmdInsert.Parameters.AddWithValue("@login", login);
            cmdInsert.Parameters.AddWithValue("@password", password);
            cmdInsert.Parameters.AddWithValue("@name", name);
            cmdInsert.Parameters.AddWithValue("@second_name", secondName);
            cmdInsert.ExecuteNonQuery();
            MessageBox.Show("User created successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void chagePassword(String newPassword,String oldPassword)
        {
            SqlCommand cmdInsert = conn.CreateCommand();

            cmdInsert.CommandText = "UPDATE[User]" + '\n' +
                                    "SET Password=@newPassword" + '\n' +
                                    "WHERE Password=@oldPassword";

            cmdInsert.Parameters.AddWithValue("@newPassword", newPassword);
            cmdInsert.Parameters.AddWithValue("@oldPassword", oldPassword);
            cmdInsert.ExecuteNonQuery();
        }

        public DataSet getSaleCardInfo(int userID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdSelect = conn.CreateCommand();
            cmdSelect.CommandText = "SELECT *" + '\n' +
                                    "FROM SaleCard" + '\n' +
                                    "WHERE[User] = @userID";

            cmdSelect.Parameters.AddWithValue("@userID", userID);
            da.SelectCommand = cmdSelect;

            DataSet ds = new DataSet();
            da.Fill(ds, "SaleCard");
            return ds;
        }

        public void changeUserData(String newLogin, String newName, String newSecondName, String oldLogin, String oldName, String oldSecondName)
        {
            SqlCommand cmdInsert = conn.CreateCommand();

            cmdInsert.CommandText = "UPDATE[User]" + '\n' +
                                    "SET Login = @newLogin, Name = @newName,[Second name] = @newSecondName" + '\n' +
                                    "WHERE Login = @oldLogin AND Name = @oldName AND[Second name] = @oldScondName";

            cmdInsert.Parameters.AddWithValue("@newLogin", newLogin);
            cmdInsert.Parameters.AddWithValue("@newName", newName);
            cmdInsert.Parameters.AddWithValue("@newSecondName", newSecondName);

            cmdInsert.Parameters.AddWithValue("@oldLogin", oldLogin);
            cmdInsert.Parameters.AddWithValue("@oldName", oldName);
            cmdInsert.Parameters.AddWithValue("@oldSecondName", oldSecondName);
            cmdInsert.ExecuteNonQuery();
        }

        public void createSaleCard(int userID)//создаем пользователя и переходим в AuthForm
        {
            int discountPercentage = 20;
            String status = "Created";
            int total = 0;

            SqlCommand cmdInsert = conn.CreateCommand();
            cmdInsert.CommandText = "INSERT INTO SaleCard([User],[Discount percentage],Status,Total)" + '\n' +
                                    "VALUES(@userID,@discountPercentage,@status,@total)";

            cmdInsert.Parameters.AddWithValue("@userID", userID);
            cmdInsert.Parameters.AddWithValue("@discountPercentage", discountPercentage);
            cmdInsert.Parameters.AddWithValue("@status", status);
            cmdInsert.Parameters.AddWithValue("@total", total);
            cmdInsert.ExecuteNonQuery();
            MessageBox.Show("Sale card created successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DataSet getProduct()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdSelect = conn.CreateCommand();

            //cmdSelect.CommandText= "SELECT Product.ID,Company.Country,Company.Name AS Company,Model.Name AS Model,Model.Series,Characteristic.Memory," + '\n' +
            //                            "Characteristic.Frequency,Characteristic.Capacity,Characteristic.[Memory type]," + '\n' +
            //                            "Characteristic.[Maximum throughput],Characteristic.Interface" + '\n' +
            //                        "FROM(((Product LEFT JOIN Company" + '\n' +
            //                            "ON Product.Company = Company.ID) LEFT JOIN Model" + '\n' +
            //                              "ON Product.Model = Model.ID) LEFT JOIN Characteristic" + '\n' +
            //                                "ON Product.Characteristic = Characteristic.ID)";

            cmdSelect.CommandText = "SELECT Product.ID,Company.Country,Company.Name AS Company,Model.Name AS Model,Model.Series,Product.Price" + '\n' +
                                    "FROM((Product LEFT JOIN Company" + '\n' +
                                        "ON Product.Company = Company.ID) LEFT JOIN Model" + '\n' +
                                          "ON Product.Model = Model.ID)" ;
            da.SelectCommand = cmdSelect;

            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            return ds;
        }

        public DataSet getProduct(int productID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdSelect = conn.CreateCommand();

            cmdSelect.CommandText = "SELECT Product.ID,Company.Country,Company.Name AS Company,Model.Name AS Model,Model.Series,Characteristic.Memory," + '\n' +
                                        "Characteristic.Frequency,Characteristic.Capacity,Characteristic.[Memory type]," + '\n' +
                                        "Characteristic.[Maximum throughput],Characteristic.Interface,Product.Price" + '\n' +
                                    "FROM(((Product LEFT JOIN Company" + '\n' +
                                        "ON Product.Company = Company.ID) LEFT JOIN Model" + '\n' +
                                          "ON Product.Model = Model.ID) LEFT JOIN Characteristic" + '\n' +
                                            "ON Product.Characteristic = Characteristic.ID)" + '\n' +
                                            "WHERE Product.ID=@productID";

            cmdSelect.Parameters.AddWithValue("@productID", productID);
            da.SelectCommand = cmdSelect;

            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            return ds;
        }

        public void addProductToBasket(int userID,int productID)
        {
            SqlCommand cmdInsert = conn.CreateCommand();
            cmdInsert.CommandText = "INSERT INTO Basket([User],Product)" + '\n' +
                                    "VALUES(@userID,@productID)";

            cmdInsert.Parameters.AddWithValue("@userID", userID);
            cmdInsert.Parameters.AddWithValue("@productID", productID);
            cmdInsert.ExecuteNonQuery();
        }

        public Boolean checkProductInBasket(int userID,int productID)//проверяем,есть ли такой товар уже в корзине у пользователя
        {
            Boolean checkProduct = false;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdSelect = conn.CreateCommand();
            cmdSelect.CommandText = "SELECT * " + '\n' +
                                    "FROM Basket" + '\n' +
                                    "Where [User]=@userID AND Product=@productID";

            cmdSelect.Parameters.Add("@userID", SqlDbType.NVarChar).Value = userID;
            cmdSelect.Parameters.Add("@productID", SqlDbType.NVarChar).Value = productID;

            da.SelectCommand = cmdSelect;
            DataSet ds = new DataSet();
            da.Fill(ds, "Basket");
            if (ds.Tables["Basket"].Rows.Count > 0)
                checkProduct = true;

            return checkProduct;
        }

        public DataSet getBasket(int userID)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmdSelect = conn.CreateCommand();

            cmdSelect.CommandText = "SELECT Product.ID,Company.Country,Company.Name AS Company,Model.Name AS Model,Model.Series,Product.Price" + '\n' +
                                    "FROM (((Basket LEFT JOIN Product" + '\n' +
                                        "ON Basket.Product=Product.ID) LEFT JOIN COMPANY" + '\n' +
                                        "ON Product.Company = Company.ID) LEFT JOIN Model" + '\n' +
                                        "ON Product.Model = Model.ID) " + '\n' +
                                    "Where [User]=@userID";

            cmdSelect.Parameters.AddWithValue("@userID", userID);
            da.SelectCommand = cmdSelect;

            DataSet ds = new DataSet();
            da.Fill(ds, "Basket");
            return ds;
        }

        public void deleteProductFromBasket(int userID,int productID)
        {
            SqlCommand cmdDelete = conn.CreateCommand();
            cmdDelete.CommandText = "DELETE Basket" + '\n' +
                                    "WHERE[User] = @userID AND Product = @productID";

            cmdDelete.Parameters.AddWithValue("@userID", userID);
            cmdDelete.Parameters.AddWithValue("@productID", productID);
            cmdDelete.ExecuteNonQuery();
        }
    }
}
