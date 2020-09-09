using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class Basket
    {   
        public int userID { get; set; }
        public Dictionary<int,Product> productInBasket { get; set; }//ключ-id корзины



        public Basket(int userID)
        {
            productInBasket = new Dictionary<int, Product>();
            this.userID = userID;
        }
    }
}
