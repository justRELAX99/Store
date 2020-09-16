using System;
using System.Collections.Generic;
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
        public ConnectionSettings()
        {
            this.dataSource = "DESKTOP-VRM1SLK\\SQLEXPRESS";
            this.nameDataBase = "Store";
            this.userName = "sa";
            this.password = "123";
        }
    }   
}
