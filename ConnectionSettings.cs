using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class ConnectionSettings
    {
        public String dataSource{ get; set; }
        public String nameDataBase{ get; set; }
        public String userName{ get; set; }
        public String password{ get; set; }
        public ConnectionSettings(String dataSource, String nameDataBase, String userName, String password)
        {
            this.dataSource = dataSource;
            this.nameDataBase = nameDataBase;
            this.userName = userName;
            this.password = password;
        }
        public ConnectionSettings()//дефолтные настройки берутся из app.config
        {
            this.dataSource = ConfigurationManager.AppSettings["dataSource"];
            this.nameDataBase = ConfigurationManager.AppSettings["nameDataBase"];
            this.userName = ConfigurationManager.AppSettings["userName"];
            this.password = ConfigurationManager.AppSettings["password"];
        }
    }   
}
