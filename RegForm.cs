using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_kurs
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            String login = login_tb.Text;
            String password = password_tb.Text;
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
                            if (password.Length != 0)
                            {
                                if (name.Length != 0)
                                {
                                    if (secondName.Length != 0)
                                    {
                                        DB.createUser(login, password, name, secondName);//создаем пользователя
                                        createAuthForm();
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
                            else
                            {
                                MessageBox.Show("Invalid cell value : Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            createAuthForm();
        }

        private void createAuthForm()//запускаем форму авторизации
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }
    }
}
