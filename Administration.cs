using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_kurs
{
    public class Administration
    {
        public DataSet dsCompany { get; set; }
        public DataSet dsModel { get; set; }
        public DataSet dsCharacteristic { get; set; }
        public Administration(DataSet dsCompany, DataSet dsModel)
        {
            this.dsCompany = dsCompany;
            this.dsModel = dsModel;
        }
        public Administration()
        {

        }

        public void getAllDataCompany(DataBase DB)
        {
            DataSet dsCompany;
            dsCompany = DB.getAllCompany();
            this.dsCompany = dsCompany;
        }

        public void getAllDataModel(DataBase DB)
        {
            DataSet dsModel;
            dsModel = DB.getAllModel();
            this.dsModel = dsModel;
        }

        public void getAllDataCharacteristic(DataBase DB)
        {
            DataSet dsCharacteristic;
            dsCharacteristic = DB.getAllCharacteristic();
            this.dsCharacteristic = dsCharacteristic;
        }

        public void getAllDataFromDB(DataBase DB)//заполняет поля класса и DataSource
        {
            DataSet dsCompany;
            DataSet dsModel;
            DataSet dsCharacteristic;
            dsCompany = DB.getAllCompany();
            dsModel = DB.getAllModel();
            dsCharacteristic = DB.getAllCharacteristic();
            this.dsCompany = dsCompany;
            this.dsModel = dsModel;
            this.dsCharacteristic = dsCharacteristic;
        }
    }
}
