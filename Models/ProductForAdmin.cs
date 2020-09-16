using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class ProductForAdmin:Product
    {
        public int companyID { get; set; }
        public int characteristicID { get; set; }
        public int modelID { get; set; }
        public ProductForAdmin(int ID, String country, String company, String model, String series, int memory, int frequency, int capacity, String memoryType, int maximumThroughput, String Interface, int price, int companyID,int characteristicID,int modelID) :
            base(ID, country, company, model, series, memory, frequency, capacity, memoryType, maximumThroughput, Interface, price)
        {
            this.companyID = companyID;
            this.characteristicID = characteristicID;
            this.modelID = modelID;
        }

        public ProductForAdmin()
        {

        }
    }
}
