using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    class Product
    {
        public int ID;
        public String country;
        public String company;
        public String model;
        public String series;
        public int memory;
        public int frequency;
        public int capacity;
        public String memoryType;
        public int maximumThroughput;
        public String Interface;

        Product(int ID, String country,String company,String model,String series,int memory,int frequency,int capacity,String memoryType,int maximumThroughput,String Interface)
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
        }
    }
}
