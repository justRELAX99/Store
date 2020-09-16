using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class Company
    {
        public int ID { get; set; }
        public String name { get; set; }
        public String country { get; set; }

        public Company(int ID,String name,String country)
        {
            this.ID = ID;
            this.name = name;
            this.country = country;
        }
    }
}
