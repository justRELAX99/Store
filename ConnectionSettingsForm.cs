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
    public partial class ConnectionSettingsForm : Form
    {
        public ConnectionSettings connectionSettings;
        public ConnectionSettingsForm()
        {
            InitializeComponent();
            connectionSettings = new ConnectionSettings();
        }

        private void saveConnectionSettings_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataSource_tb.Text))
            {
                MessageBox.Show("Invalid cell value : Data source", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(nameDataBase_tb.Text))
            {
                MessageBox.Show("Invalid cell value : Name data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConnectionSettings connectionSettings = new ConnectionSettings(dataSource_tb.Text,nameDataBase_tb.Text,userName_tb.Text,password_tb.Text);
            DataBase DB = new DataBase(connectionSettings);//создаем класс Базы данных(подключаемся к ней)
            if (DB.getConnection().State == ConnectionState.Open)//если подключились
            {
                try
                {
                    MessageBox.Show("Connection was successful", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.connectionSettings = connectionSettings;
                }

                catch
                {
                    MessageBox.Show("Runtime error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DB.closeConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Connection was not open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
