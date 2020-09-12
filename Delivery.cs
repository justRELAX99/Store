using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class Delivery
    {
        public int ID { get; set; }
        public int order { get; set; }
        public String address { get; set; }
        public String status { get; set; }

        public Delivery(int ID,int order,String address,String status)
        {
            this.ID = ID;
            this.order = order;
            this.address = address;
            this.status = status;
        }

        public Delivery()
        {

        }

    }
}
