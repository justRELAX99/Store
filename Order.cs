using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class Order
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public DateTime date { get; set; }
        public String status { get; set; }
        public List<int> products { get; set; }
        public int deliveryID { get; set; }

        public Order(int ID,int userID,DateTime date,String status,List<int> products,int deliveryID)
        {
            this.ID = ID;
            this.userID = userID;
            this.date = date;
            this.status = status;
            this.products = products;
            this.deliveryID = deliveryID;
        }

        public Order(int userID)
        {
            this.userID = userID;
        }
    }
}
