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
        public int ID;
        public int role;
        public String login;
        public String password;
        public String name;
        public String secondName;
        
        public User()
        {
            this.ID = -1;//ставим значение -1 для проверки если юзера не нашлось в бд,тк столбец в бд не может быть отрицательным 
        }

        public User(int ID,int role,String login, String password, String name, String secondName)
        {
            this.ID = ID;
            this.role = role;
            this.login = login;
            this.password = password;
            this.name = name;
            this.secondName = secondName;
        }

    }
}
