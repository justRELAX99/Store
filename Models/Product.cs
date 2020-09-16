using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class Product
    {
        public int ID { get; set; }
        public String country{ get; set; }
        public String company { get; set; }
        public String model { get; set; }
        public String series { get; set; }
        public int memory { get; set; }
        public int frequency { get; set; }
        public int capacity { get; set; }
        public String memory_type { get; set; }
        public int maximum_throughput { get; set; }
        public String Interface { get; set; }
        public int price { get; set; }

        public Product(int ID, String country,String company,String model,String series,int memory,int frequency,int capacity,String memory_type, int maximum_throughput, String Interface,int price)
        {
            this.ID = ID;
            this.country = country;
            this.company = company;
            this.model = model;
            this.series = series;
            this.memory = memory;
            this.frequency = frequency;
            this.capacity = capacity;
            this.memory_type = memory_type;
            this.maximum_throughput = maximum_throughput;
            this.Interface=Interface;
            this.price = price;
        }
        public Product()
        {

        }
    }
}
