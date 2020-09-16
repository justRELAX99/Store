using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_kurs
{
    public partial class ProductInformationForm : Form
    {
        public ProductInformationForm(Product product)
        {
            InitializeComponent();

            country_tb.Text = product.country;//заполняем текст боксы
            company_tb.Text = product.company;
            model_tb.Text = product.model;
            series_tb.Text = product.series;
            memory_tb.Text = product.memory.ToString();
            frequency_tb.Text = product.frequency.ToString();
            capacity_tb.Text = product.capacity.ToString();
            memoryType_tb.Text = product.memory_type;
            maxThroughput_tb.Text = product.maximum_throughput.ToString();
            interface_tb.Text = product.Interface;
            price_tb.Text= product.price.ToString();                    
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
