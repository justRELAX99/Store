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
        public string memory_type { get; set; }
        public int maximum_throughput { get; set; }
        public string Interface { get; set; }

        public Characteristic(int ID,int memory,int frequency, int capacity, string memory_type, int maximum_throughput, string Interface)
        {
            this.ID = ID;
            this.memory = memory;
            this.frequency = frequency;
            this.capacity = capacity;
            this.memory_type = memory_type;
            this.maximum_throughput = maximum_throughput;
            this.Interface = Interface;
        }

        public Characteristic()
        {

        }
    }
}
