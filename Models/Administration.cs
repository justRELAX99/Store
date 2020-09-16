using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_kurs
{
    public class Administration
    {
        public DataSet dsCompany { get; set; }
        public DataSet dsModel { get; set; }
        public DataSet dsCharacteristic { get; set; }
        public DataSet dsUser { get; set; }
        public DataSet dsRole { get; set; }
        public DataSet dsProductForAdmin { get; set; }
        public List<ProductForAdmin> productsForAdmin { get; set; }

        public Administration(DataSet dsCompany, DataSet dsModel)
        {
            this.dsCompany = dsCompany;
            this.dsModel = dsModel;
            productsForAdmin = new List<ProductForAdmin>();
        }
        public Administration()
        {
            productsForAdmin = new List<ProductForAdmin>();
        }

        public void setAllDataCompany(DataBase DB)
        {
            DataSet dsCompany;
            dsCompany = DB.getAllCompany();
            this.dsCompany = dsCompany;
        }

        public List<string> getCompanyData(int companyID)
        {
            List<string> companyData = new List<string>();
            if (dsCompany.Tables["Company"].Rows.Count == 0)
            {
                //MessageBox.Show("Company not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return companyData;
            }

            for (int i = 0; i < dsCompany.Tables["Company"].Rows.Count; i++)
            {
                if ((int)dsCompany.Tables["Company"].Rows[i].ItemArray[0] == companyID)
                {
                    companyData.Add(dsCompany.Tables["Company"].Rows[i].ItemArray[1].ToString());
                    companyData.Add(dsCompany.Tables["Company"].Rows[i].ItemArray[2].ToString());
                }
            }
            return companyData;
        }

        public void setAllDataModel(DataBase DB)
        {
            DataSet dsModel;
            dsModel = DB.getAllModel();
            this.dsModel = dsModel;
        }

        public List<string> getModelData(int modelID)
        {
            List<string> modelData = new List<string>();
            if (dsModel.Tables["Model"].Rows.Count == 0)
            {
                //MessageBox.Show("Company not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return modelData;
            }

            for (int i = 0; i < dsModel.Tables["Model"].Rows.Count; i++)
            {
                if ((int)dsModel.Tables["Model"].Rows[i].ItemArray[0] == modelID)
                {
                    modelData.Add(dsModel.Tables["Model"].Rows[i].ItemArray[1].ToString());
                    modelData.Add(dsModel.Tables["Model"].Rows[i].ItemArray[2].ToString());
                }
            }
            return modelData;
        }

        public void setAllDataCharacteristic(DataBase DB)
        {
            DataSet dsCharacteristic;
            dsCharacteristic = DB.getAllCharacteristic();
            this.dsCharacteristic = dsCharacteristic;
        }

        public List<string> getCharacteristicData(int characteristicID)
        {
            List<string> characteristicData = new List<string>();
            if (dsCharacteristic.Tables["Characteristic"].Rows.Count == 0)
            {
                //MessageBox.Show("Company not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return characteristicData;
            }

            for (int i = 0; i < dsCharacteristic.Tables["Characteristic"].Rows.Count; i++)
            {
                if ((int)dsCharacteristic.Tables["Characteristic"].Rows[i].ItemArray[0] == characteristicID)
                {
                    characteristicData.Add(dsCharacteristic.Tables["Characteristic"].Rows[i].ItemArray[1].ToString());
                    characteristicData.Add(dsCharacteristic.Tables["Characteristic"].Rows[i].ItemArray[2].ToString());
                    characteristicData.Add(dsCharacteristic.Tables["Characteristic"].Rows[i].ItemArray[3].ToString());
                    characteristicData.Add(dsCharacteristic.Tables["Characteristic"].Rows[i].ItemArray[4].ToString());
                    characteristicData.Add(dsCharacteristic.Tables["Characteristic"].Rows[i].ItemArray[5].ToString());
                    characteristicData.Add(dsCharacteristic.Tables["Characteristic"].Rows[i].ItemArray[6].ToString());
                }
            }
            return characteristicData;
        }

        public void setAllDataUsers(DataBase DB)
        {
            DataSet dsUsers;
            dsUsers = DB.getAllUsers();
            this.dsUser = dsUsers;
        }

        public void setAllProductForAdmin(DataBase DB)
        {
            List<ProductForAdmin> productsForAdmin = new List<ProductForAdmin>();
            productsForAdmin = updateProductsForAdmin(DB);
            this.productsForAdmin = productsForAdmin;
        }

        public void setAllRole(DataBase DB)
        {
            DataSet dsRole;
            dsRole = DB.getAllRoles();
            this.dsRole = dsRole;
        }

        public void setAllDataFromDB(DataBase DB)//заполняет поля класса и DataSource
        {
            this.productsForAdmin = updateProductsForAdmin(DB);
            this.dsCompany = DB.getAllCompany();
            this.dsModel = DB.getAllModel();
            this.dsCharacteristic = DB.getAllCharacteristic();
            this.dsUser = DB.getAllUsers();
            this.dsRole= DB.getAllRoles();
            this.dsProductForAdmin = DB.getProductForAdmin();
        }

        public List<ProductForAdmin> updateProductsForAdmin(DataBase DB)
        {
            List<ProductForAdmin> products = new List<ProductForAdmin>();
            ProductForAdmin product;
            int ID;//переменные для заполнения полей модели
            String country;
            String company;
            String model;
            String series;
            int memory;
            int frequency;
            int capacity;
            String memoryType;
            int maximumThroughput;
            String Interface;
            int price;
            int companyID;
            int characteristicID;
            int modelID;

            DataSet dsProduct = DB.getProductForAdmin();
            if (dsProduct.Tables["Product"].Rows.Count == 0)
            {
                MessageBox.Show("Products not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return products;
            }

            for (int i = 0; i < dsProduct.Tables["Product"].Rows.Count; i++)
            {
                ID = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[0].ToString());
                country = dsProduct.Tables["Product"].Rows[i].ItemArray[1].ToString();
                company = dsProduct.Tables["Product"].Rows[i].ItemArray[2].ToString();
                model = dsProduct.Tables["Product"].Rows[i].ItemArray[3].ToString();
                series = dsProduct.Tables["Product"].Rows[i].ItemArray[4].ToString();
                memory = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[5].ToString());
                frequency = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[6].ToString());
                capacity = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[7].ToString());
                memoryType = dsProduct.Tables["Product"].Rows[i].ItemArray[8].ToString();
                maximumThroughput = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[9].ToString());
                Interface = dsProduct.Tables["Product"].Rows[i].ItemArray[10].ToString();
                price = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[11].ToString());

                companyID = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[12].ToString());
                characteristicID = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[13].ToString());
                modelID = Convert.ToInt32(dsProduct.Tables["Product"].Rows[i].ItemArray[14].ToString());

                product = new ProductForAdmin(ID, country, company, model, series, memory, frequency, capacity, memoryType, maximumThroughput, Interface, price,companyID,characteristicID,modelID);
                products.Add(product);
            }
            return products;
        }
    }
}
