namespace Store_kurs
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderBasket_dgv = new System.Windows.Forms.DataGridView();
            this.makeAnOrder_btn = new System.Windows.Forms.Button();
            this.address_lbl = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.allOrderValue_lbl = new System.Windows.Forms.Label();
            this.allOrderValue_tb = new System.Windows.Forms.TextBox();
            this.inOrderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumThroughputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interfaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBasket_bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderBasket_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBasket_bs)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBasket_dgv
            // 
            this.orderBasket_dgv.AllowUserToAddRows = false;
            this.orderBasket_dgv.AllowUserToDeleteRows = false;
            this.orderBasket_dgv.AllowUserToResizeColumns = false;
            this.orderBasket_dgv.AllowUserToResizeRows = false;
            this.orderBasket_dgv.AutoGenerateColumns = false;
            this.orderBasket_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderBasket_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderBasket_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inOrderDataGridViewCheckBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.memoryDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.memoryTypeDataGridViewTextBoxColumn,
            this.maximumThroughputDataGridViewTextBoxColumn,
            this.interfaceDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.orderBasket_dgv.DataSource = this.orderBasket_bs;
            this.orderBasket_dgv.Location = new System.Drawing.Point(12, 12);
            this.orderBasket_dgv.Name = "orderBasket_dgv";
            this.orderBasket_dgv.ReadOnly = true;
            this.orderBasket_dgv.RowHeadersVisible = false;
            this.orderBasket_dgv.Size = new System.Drawing.Size(760, 150);
            this.orderBasket_dgv.TabIndex = 2;
            this.orderBasket_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderBasket_dgv_CellMouseDoubleClick);
            // 
            // makeAnOrder_btn
            // 
            this.makeAnOrder_btn.Location = new System.Drawing.Point(301, 460);
            this.makeAnOrder_btn.Name = "makeAnOrder_btn";
            this.makeAnOrder_btn.Size = new System.Drawing.Size(157, 23);
            this.makeAnOrder_btn.TabIndex = 4;
            this.makeAnOrder_btn.Text = "MAKE AN ORDER";
            this.makeAnOrder_btn.UseVisualStyleBackColor = true;
            this.makeAnOrder_btn.Click += new System.EventHandler(this.makeAnOrder_btn_Click);
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(63, 231);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(59, 13);
            this.address_lbl.TabIndex = 37;
            this.address_lbl.Text = "ADDRESS";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(128, 231);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(196, 20);
            this.address_tb.TabIndex = 36;
            // 
            // allOrderValue_lbl
            // 
            this.allOrderValue_lbl.AutoSize = true;
            this.allOrderValue_lbl.Location = new System.Drawing.Point(16, 280);
            this.allOrderValue_lbl.Name = "allOrderValue_lbl";
            this.allOrderValue_lbl.Size = new System.Drawing.Size(106, 13);
            this.allOrderValue_lbl.TabIndex = 38;
            this.allOrderValue_lbl.Text = "ALL ORDER VALUE";
            // 
            // allOrderValue_tb
            // 
            this.allOrderValue_tb.Location = new System.Drawing.Point(128, 277);
            this.allOrderValue_tb.Name = "allOrderValue_tb";
            this.allOrderValue_tb.ReadOnly = true;
            this.allOrderValue_tb.Size = new System.Drawing.Size(196, 20);
            this.allOrderValue_tb.TabIndex = 39;
            // 
            // inOrderDataGridViewCheckBoxColumn
            // 
            this.inOrderDataGridViewCheckBoxColumn.DataPropertyName = "inOrder";
            this.inOrderDataGridViewCheckBoxColumn.HeaderText = "inOrder";
            this.inOrderDataGridViewCheckBoxColumn.Name = "inOrderDataGridViewCheckBoxColumn";
            this.inOrderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inOrderDataGridViewCheckBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoryDataGridViewTextBoxColumn
            // 
            this.memoryDataGridViewTextBoxColumn.DataPropertyName = "memory";
            this.memoryDataGridViewTextBoxColumn.HeaderText = "memory";
            this.memoryDataGridViewTextBoxColumn.Name = "memoryDataGridViewTextBoxColumn";
            this.memoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "frequency";
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.frequencyDataGridViewTextBoxColumn.Visible = false;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Visible = false;
            // 
            // memoryTypeDataGridViewTextBoxColumn
            // 
            this.memoryTypeDataGridViewTextBoxColumn.DataPropertyName = "memoryType";
            this.memoryTypeDataGridViewTextBoxColumn.HeaderText = "memoryType";
            this.memoryTypeDataGridViewTextBoxColumn.Name = "memoryTypeDataGridViewTextBoxColumn";
            this.memoryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoryTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // maximumThroughputDataGridViewTextBoxColumn
            // 
            this.maximumThroughputDataGridViewTextBoxColumn.DataPropertyName = "maximumThroughput";
            this.maximumThroughputDataGridViewTextBoxColumn.HeaderText = "maximumThroughput";
            this.maximumThroughputDataGridViewTextBoxColumn.Name = "maximumThroughputDataGridViewTextBoxColumn";
            this.maximumThroughputDataGridViewTextBoxColumn.ReadOnly = true;
            this.maximumThroughputDataGridViewTextBoxColumn.Visible = false;
            // 
            // interfaceDataGridViewTextBoxColumn
            // 
            this.interfaceDataGridViewTextBoxColumn.DataPropertyName = "Interface";
            this.interfaceDataGridViewTextBoxColumn.HeaderText = "Interface";
            this.interfaceDataGridViewTextBoxColumn.Name = "interfaceDataGridViewTextBoxColumn";
            this.interfaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.interfaceDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBasket_bs
            // 
            this.orderBasket_bs.DataSource = typeof(Store_kurs.ProductInBasket);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.allOrderValue_tb);
            this.Controls.Add(this.allOrderValue_lbl);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.makeAnOrder_btn);
            this.Controls.Add(this.orderBasket_dgv);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.orderBasket_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBasket_bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderBasket_dgv;
        private System.Windows.Forms.BindingSource orderBasket_bs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inOrderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumThroughputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interfaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button makeAnOrder_btn;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label allOrderValue_lbl;
        private System.Windows.Forms.TextBox allOrderValue_tb;
    }
}