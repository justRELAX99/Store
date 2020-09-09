using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class OrderProduct
    {
        public int ID { get; set; }
        public int order { get; set; }
        public int product { get; set; }

        public OrderProduct(int ID,int order,int product)
        {
            this.ID = ID;
            this.order = order;
            this.product = product;
        }

    }
}
