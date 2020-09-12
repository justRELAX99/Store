﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class ProductInOrder:Product
    {
        public int count { get; set; }

        public ProductInOrder(int ID, String country, String company, String model, String series, int memory, int frequency, int capacity, String memoryType, int maximumThroughput, String Interface, int price, int count) :
            base(ID, country, company, model, series, memory, frequency, capacity, memoryType, maximumThroughput, Interface, price)
        {
            this.count = count;
        }
    }
}
