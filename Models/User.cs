using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class User
    {
        public int ID { get; set; }
        public int role { get; set; }
        public String login { get; set; }
        public String password { get; set; }
        public String name { get; set; }
        public String second_name { get; set; }

        public User()
        {
            this.ID = -1;//ставим значение -1 для проверки если юзера не нашлось в бд,тк столбец в бд не может быть отрицательным 
        }

        public User(int ID,int role,String login, String password, String name, String second_name)
        {
            this.ID = ID;
            this.role = role;
            this.login = login;
            this.password = password;
            this.name = name;
            this.second_name = second_name;
        }

    }
}
