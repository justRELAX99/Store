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
        public String memoryType { get; set; }
        public int maximumThroughput { get; set; }
        public String Interface { get; set; }
        public int price { get; set; }

        public Product(int ID, String country,String company,String model,String series,int memory,int frequency,int capacity,String memoryType,int maximumThroughput,String Interface,int price)
        {
            this.ID = ID;
            this.country = country;
            this.company = company;
            this.model = model;
            this.series = series;
            this.memory = memory;
            this.frequency = frequency;
            this.capacity = capacity;
            this.memoryType = memoryType;
            this.maximumThroughput = maximumThroughput;
            this.Interface=Interface;
            this.price = price;
        }

        public Product()
        {

        }
    }
}
