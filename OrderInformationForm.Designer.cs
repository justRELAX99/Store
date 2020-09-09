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
            this.products_dgv = new System.Windows.Forms.DataGridView();
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
            this.orderProduct_bs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).BeginInit();
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
            // products_dgv
            // 
            this.products_dgv.AllowUserToAddRows = false;
            this.products_dgv.AllowUserToDeleteRows = false;
            this.products_dgv.AllowUserToResizeColumns = false;
            this.products_dgv.AllowUserToResizeRows = false;
            this.products_dgv.AutoGenerateColumns = false;
            this.products_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.products_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.priceDataGridViewTextBoxColumn});
            this.products_dgv.DataSource = this.orderProduct_bs;
            this.products_dgv.Location = new System.Drawing.Point(12, 12);
            this.products_dgv.Name = "products_dgv";
            this.products_dgv.ReadOnly = true;
            this.products_dgv.RowHeadersVisible = false;
            this.products_dgv.Size = new System.Drawing.Size(760, 150);
            this.products_dgv.TabIndex = 2;
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
            // orderProduct_bs
            // 
            this.orderProduct_bs.DataSource = typeof(Store_kurs.Product);
            // 
            // OrderInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.products_dgv);
            this.Controls.Add(this.OK_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order information";
            ((System.ComponentModel.ISupportInitialize)(this.products_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProduct_bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.BindingSource orderProduct_bs;
        private System.Windows.Forms.DataGridView products_dgv;
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
    }
}