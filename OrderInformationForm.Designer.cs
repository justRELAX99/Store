namespace Store_kurs
{
    partial class OrderInformationForm
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.orderProducts_dgv = new System.Windows.Forms.DataGridView();
            this.deliveryStatus_lbl = new System.Windows.Forms.Label();
            this.deliveryStatus_tb = new System.Windows.Forms.TextBox();
            this.deliveryAddres_lbl = new System.Windows.Forms.Label();
            this.deliveryAddres_tb = new System.Windows.Forms.TextBox();
            this.orderDate_lbl = new System.Windows.Forms.Label();
            this.orderDate_tb = new System.Windows.Forms.TextBox();
            this.orderStatus_lbl = new System.Windows.Forms.Label();
            this.orderStatus_tb = new System.Windows.Forms.TextBox();
            this.allOrderValue_tb = new System.Windows.Forms.TextBox();
            this.allOrderValue_lbl = new System.Windows.Forms.Label();
            this.orderProduct_bs = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.orderProducts_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProduct_bs)).BeginInit();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(363, 326);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 1;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // orderProducts_dgv
            // 
            this.orderProducts_dgv.AllowUserToAddRows = false;
            this.orderProducts_dgv.AllowUserToDeleteRows = false;
            this.orderProducts_dgv.AllowUserToResizeColumns = false;
            this.orderProducts_dgv.AllowUserToResizeRows = false;
            this.orderProducts_dgv.AutoGenerateColumns = false;
            this.orderProducts_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderProducts_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderProducts_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.orderProducts_dgv.DataSource = this.orderProduct_bs;
            this.orderProducts_dgv.Location = new System.Drawing.Point(12, 12);
            this.orderProducts_dgv.Name = "orderProducts_dgv";
            this.orderProducts_dgv.ReadOnly = true;
            this.orderProducts_dgv.RowHeadersVisible = false;
            this.orderProducts_dgv.Size = new System.Drawing.Size(760, 150);
            this.orderProducts_dgv.TabIndex = 2;
            this.orderProducts_dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.products_dgv_CellMouseDoubleClick);
            // 
            // deliveryStatus_lbl
            // 
            this.deliveryStatus_lbl.AutoSize = true;
            this.deliveryStatus_lbl.Location = new System.Drawing.Point(19, 234);
            this.deliveryStatus_lbl.Name = "deliveryStatus_lbl";
            this.deliveryStatus_lbl.Size = new System.Drawing.Size(106, 13);
            this.deliveryStatus_lbl.TabIndex = 20;
            this.deliveryStatus_lbl.Text = "DELIVERY STATUS";
            // 
            // deliveryStatus_tb
            // 
            this.deliveryStatus_tb.Location = new System.Drawing.Point(131, 234);
            this.deliveryStatus_tb.Name = "deliveryStatus_tb";
            this.deliveryStatus_tb.ReadOnly = true;
            this.deliveryStatus_tb.Size = new System.Drawing.Size(100, 20);
            this.deliveryStatus_tb.TabIndex = 19;
            // 
            // deliveryAddres_lbl
            // 
            this.deliveryAddres_lbl.AutoSize = true;
            this.deliveryAddres_lbl.Location = new System.Drawing.Point(19, 260);
            this.deliveryAddres_lbl.Name = "deliveryAddres_lbl";
            this.deliveryAddres_lbl.Size = new System.Drawing.Size(108, 13);
            this.deliveryAddres_lbl.TabIndex = 22;
            this.deliveryAddres_lbl.Text = "DELIVERY ADDRES";
            // 
            // deliveryAddres_tb
            // 
            this.deliveryAddres_tb.Location = new System.Drawing.Point(131, 260);
            this.deliveryAddres_tb.Name = "deliveryAddres_tb";
            this.deliveryAddres_tb.ReadOnly = true;
            this.deliveryAddres_tb.Size = new System.Drawing.Size(100, 20);
            this.deliveryAddres_tb.TabIndex = 21;
            // 
            // orderDate_lbl
            // 
            this.orderDate_lbl.AutoSize = true;
            this.orderDate_lbl.Location = new System.Drawing.Point(298, 260);
            this.orderDate_lbl.Name = "orderDate_lbl";
            this.orderDate_lbl.Size = new System.Drawing.Size(78, 13);
            this.orderDate_lbl.TabIndex = 26;
            this.orderDate_lbl.Text = "ORDER DATE";
            // 
            // orderDate_tb
            // 
            this.orderDate_tb.Location = new System.Drawing.Point(396, 260);
            this.orderDate_tb.Name = "orderDate_tb";
            this.orderDate_tb.ReadOnly = true;
            this.orderDate_tb.Size = new System.Drawing.Size(100, 20);
            this.orderDate_tb.TabIndex = 25;
            // 
            // orderStatus_lbl
            // 
            this.orderStatus_lbl.AutoSize = true;
            this.orderStatus_lbl.Location = new System.Drawing.Point(284, 234);
            this.orderStatus_lbl.Name = "orderStatus_lbl";
            this.orderStatus_lbl.Size = new System.Drawing.Size(92, 13);
            this.orderStatus_lbl.TabIndex = 24;
            this.orderStatus_lbl.Text = "ORDER STATUS";
            // 
            // orderStatus_tb
            // 
            this.orderStatus_tb.Location = new System.Drawing.Point(396, 234);
            this.orderStatus_tb.Name = "orderStatus_tb";
            this.orderStatus_tb.ReadOnly = true;
            this.orderStatus_tb.Size = new System.Drawing.Size(100, 20);
            this.orderStatus_tb.TabIndex = 23;
            // 
            // allOrderValue_tb
            // 
            this.allOrderValue_tb.Location = new System.Drawing.Point(634, 231);
            this.allOrderValue_tb.Name = "allOrderValue_tb";
            this.allOrderValue_tb.ReadOnly = true;
            this.allOrderValue_tb.Size = new System.Drawing.Size(92, 20);
            this.allOrderValue_tb.TabIndex = 41;
            // 
            // allOrderValue_lbl
            // 
            this.allOrderValue_lbl.AutoSize = true;
            this.allOrderValue_lbl.Location = new System.Drawing.Point(522, 234);
            this.allOrderValue_lbl.Name = "allOrderValue_lbl";
            this.allOrderValue_lbl.Size = new System.Drawing.Size(106, 13);
            this.allOrderValue_lbl.TabIndex = 40;
            this.allOrderValue_lbl.Text = "ALL ORDER VALUE";
            // 
            // orderProduct_bs
            // 
            this.orderProduct_bs.DataSource = typeof(Store_kurs.ProductInOrder);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
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
            // OrderInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.allOrderValue_tb);
            this.Controls.Add(this.allOrderValue_lbl);
            this.Controls.Add(this.orderDate_lbl);
            this.Controls.Add(this.orderDate_tb);
            this.Controls.Add(this.orderStatus_lbl);
            this.Controls.Add(this.orderStatus_tb);
            this.Controls.Add(this.deliveryAddres_lbl);
            this.Controls.Add(this.deliveryAddres_tb);
            this.Controls.Add(this.deliveryStatus_lbl);
            this.Controls.Add(this.deliveryStatus_tb);
            this.Controls.Add(this.orderProducts_dgv);
            this.Controls.Add(this.OK_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order information";
            ((System.ComponentModel.ISupportInitialize)(this.orderProducts_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProduct_bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.BindingSource orderProduct_bs;
        private System.Windows.Forms.DataGridView orderProducts_dgv;
        private System.Windows.Forms.Label deliveryStatus_lbl;
        private System.Windows.Forms.TextBox deliveryStatus_tb;
        private System.Windows.Forms.Label deliveryAddres_lbl;
        private System.Windows.Forms.TextBox deliveryAddres_tb;
        private System.Windows.Forms.Label orderDate_lbl;
        private System.Windows.Forms.TextBox orderDate_tb;
        private System.Windows.Forms.Label orderStatus_lbl;
        private System.Windows.Forms.TextBox orderStatus_tb;
        private System.Windows.Forms.TextBox allOrderValue_tb;
        private System.Windows.Forms.Label allOrderValue_lbl;
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
    }
}