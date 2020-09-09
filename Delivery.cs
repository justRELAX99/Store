using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    class Delivery
    {
        public int ID { get; set; }
        public int order { get; set; }
        public String addres { get; set; }
        public String status { get; set; }

        public Delivery(int ID,int order,String addres,String status)
        {
            this.ID = ID;
            this.order = order;
            this.addres = addres;
            this.status = status;
        }

    }
}
