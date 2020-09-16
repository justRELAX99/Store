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
    public partial class AuthForm : Form
    {
        public ConnectionSettings connectionSettings;
        public AuthForm()
        {
            InitializeComponent();
            connectionSettings = new ConnectionSettings();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String login = login_tb.Text;
            String password = password_tb.Text;
            User user;

            DataBase DB = new DataBase();//создаем класс Базы данных(подключаемся к ней)

            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                //try
                //{
                    user = DB.checkLoginPassword(login, password);
                    if (user.ID != -1)//если есть такой пользователь,переходим в главное окно
                    {
                        createMainForm(user);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                //}

                //catch
                //{
                //    MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                DB.closeConnection();
            }
            else
            {
                MessageBox.Show("Connection was not open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void createMainForm(User user)//запускаем главную форму
        {
            this.Hide();
            MainForm mainForm = new MainForm(user);
            mainForm.ShowDialog();
            this.Close();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            createRegForm();
        }

        private void createRegForm()//запускаем форму регистрации
        {
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.ShowDialog();
            this.Close();
        }

        private void connectionSettings_btn_Click(object sender, EventArgs e)
        {
            ConnectionSettingsForm connectionSettingsForm = new ConnectionSettingsForm();
            connectionSettingsForm.ShowDialog();
            this.connectionSettings = connectionSettingsForm.connectionSettings;
        }
    }
}
