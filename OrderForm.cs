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
    public partial class OrderForm : Form
    {
        public OrderForm(Basket basket)
        {
            InitializeComponent();

            
            foreach (Product p in basket.productInBasket.Values)
            {
                
            }

        }
    }
}
