using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class Characteristic
    {
        public int ID { get; set; }
        public int memory { get; set; }
        public int frequency { get; set; }
        public int capacity { get; set; }
        public String memoryType { get; set; }
        public int maximumThroughput { get; set; }
        public String Interface { get; set; }

        public Characteristic(int ID,int memory,int frequency, int capacity, String memoryType, int maximumThroughput, String Interface)
        {
            this.ID = ID;
            this.memory = memory;
            this.frequency = frequency;
            this.capacity = capacity;
            this.memoryType = memoryType;
            this.maximumThroughput = maximumThroughput;
            this.Interface = Interface;
        }

        public Characteristic()
        {

        }
    }
}
