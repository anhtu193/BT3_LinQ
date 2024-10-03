namespace BT3_LinQ
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindHighestPrice = new System.Windows.Forms.Button();
            this.btnFindJapanProduct = new System.Windows.Forms.Button();
            this.btnGetExpiredProducts = new System.Windows.Forms.Button();
            this.btnGetProductsByPriceRange = new System.Windows.Forms.Button();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.productListView = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProductList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteProductsByOrigin = new System.Windows.Forms.Button();
            this.txtProductOriginToDelete = new System.Windows.Forms.TextBox();
            this.btnCheckExpired = new System.Windows.Forms.Button();
            this.btnDeleteAllProducts = new System.Windows.Forms.Button();
            this.btnDeleteExpiredProducts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.dtpExpiryDate);
            this.groupBox1.Controls.Add(this.txtOrigin);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Xuất xứ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày hết hạn:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(117, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(219, 22);
            this.txtProductID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(117, 88);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(219, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(117, 116);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(219, 22);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(117, 144);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(219, 22);
            this.txtOrigin.TabIndex = 4;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(117, 174);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(250, 22);
            this.dtpExpiryDate.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productListView);
            this.groupBox2.Controls.Add(this.txtMaxPrice);
            this.groupBox2.Controls.Add(this.txtMinPrice);
            this.groupBox2.Controls.Add(this.btnGetProductsByPriceRange);
            this.groupBox2.Controls.Add(this.btnGetExpiredProducts);
            this.groupBox2.Controls.Add(this.btnFindJapanProduct);
            this.groupBox2.Controls.Add(this.btnFindHighestPrice);
            this.groupBox2.Location = new System.Drawing.Point(437, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng tìm kiếm";
            // 
            // btnFindHighestPrice
            // 
            this.btnFindHighestPrice.Location = new System.Drawing.Point(6, 21);
            this.btnFindHighestPrice.Name = "btnFindHighestPrice";
            this.btnFindHighestPrice.Size = new System.Drawing.Size(94, 48);
            this.btnFindHighestPrice.TabIndex = 6;
            this.btnFindHighestPrice.Text = "1 SP có ĐG cao nhất";
            this.btnFindHighestPrice.UseVisualStyleBackColor = true;
            this.btnFindHighestPrice.Click += new System.EventHandler(this.btnFindHighestPrice_Click);
            // 
            // btnFindJapanProduct
            // 
            this.btnFindJapanProduct.Location = new System.Drawing.Point(106, 21);
            this.btnFindJapanProduct.Name = "btnFindJapanProduct";
            this.btnFindJapanProduct.Size = new System.Drawing.Size(76, 48);
            this.btnFindJapanProduct.TabIndex = 7;
            this.btnFindJapanProduct.Text = "1 SP từ Nhật Bản";
            this.btnFindJapanProduct.UseVisualStyleBackColor = true;
            this.btnFindJapanProduct.Click += new System.EventHandler(this.btnFindJapanProduct_Click);
            // 
            // btnGetExpiredProducts
            // 
            this.btnGetExpiredProducts.Location = new System.Drawing.Point(188, 21);
            this.btnGetExpiredProducts.Name = "btnGetExpiredProducts";
            this.btnGetExpiredProducts.Size = new System.Drawing.Size(100, 48);
            this.btnGetExpiredProducts.TabIndex = 8;
            this.btnGetExpiredProducts.Text = "Xuất toàn bộ SP quá hạn";
            this.btnGetExpiredProducts.UseVisualStyleBackColor = true;
            this.btnGetExpiredProducts.Click += new System.EventHandler(this.btnGetExpiredProducts_Click);
            // 
            // btnGetProductsByPriceRange
            // 
            this.btnGetProductsByPriceRange.Location = new System.Drawing.Point(294, 22);
            this.btnGetProductsByPriceRange.Name = "btnGetProductsByPriceRange";
            this.btnGetProductsByPriceRange.Size = new System.Drawing.Size(100, 48);
            this.btnGetProductsByPriceRange.TabIndex = 11;
            this.btnGetProductsByPriceRange.Text = "Xuất các SP có ĐG [a..b]";
            this.btnGetProductsByPriceRange.UseVisualStyleBackColor = true;
            this.btnGetProductsByPriceRange.Click += new System.EventHandler(this.btnGetProductsByPriceRange_Click);
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(403, 25);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(57, 22);
            this.txtMinPrice.TabIndex = 9;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(466, 25);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(57, 22);
            this.txtMaxPrice.TabIndex = 10;
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(6, 75);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(534, 119);
            this.productListView.TabIndex = 6;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteExpiredProducts);
            this.groupBox3.Controls.Add(this.btnDeleteAllProducts);
            this.groupBox3.Controls.Add(this.btnCheckExpired);
            this.groupBox3.Controls.Add(this.txtProductOriginToDelete);
            this.groupBox3.Controls.Add(this.btnDeleteProductsByOrigin);
            this.groupBox3.Controls.Add(this.ProductList);
            this.groupBox3.Location = new System.Drawing.Point(2, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(941, 271);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // ProductList
            // 
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.ProductList.HideSelection = false;
            this.ProductList.Location = new System.Drawing.Point(7, 22);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(637, 249);
            this.ProductList.TabIndex = 0;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SP";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 66;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Xuất xứ";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày hết hạn";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã SP";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên SP";
            this.columnHeader8.Width = 111;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số lượng";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Đơn giá";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Xuất xứ";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày hết hạn";
            this.columnHeader12.Width = 162;
            // 
            // btnDeleteProductsByOrigin
            // 
            this.btnDeleteProductsByOrigin.Location = new System.Drawing.Point(651, 22);
            this.btnDeleteProductsByOrigin.Name = "btnDeleteProductsByOrigin";
            this.btnDeleteProductsByOrigin.Size = new System.Drawing.Size(114, 61);
            this.btnDeleteProductsByOrigin.TabIndex = 1;
            this.btnDeleteProductsByOrigin.Text = "Xóa SP theo xuất xứ";
            this.btnDeleteProductsByOrigin.UseVisualStyleBackColor = true;
            this.btnDeleteProductsByOrigin.Click += new System.EventHandler(this.btnDeleteProductsByOrigin_Click);
            // 
            // txtProductOriginToDelete
            // 
            this.txtProductOriginToDelete.Location = new System.Drawing.Point(772, 41);
            this.txtProductOriginToDelete.Name = "txtProductOriginToDelete";
            this.txtProductOriginToDelete.Size = new System.Drawing.Size(163, 22);
            this.txtProductOriginToDelete.TabIndex = 2;
            // 
            // btnCheckExpired
            // 
            this.btnCheckExpired.Location = new System.Drawing.Point(651, 89);
            this.btnCheckExpired.Name = "btnCheckExpired";
            this.btnCheckExpired.Size = new System.Drawing.Size(284, 61);
            this.btnCheckExpired.TabIndex = 3;
            this.btnCheckExpired.Text = "Kiểm tra kho có SP quá hạn hay không?";
            this.btnCheckExpired.UseVisualStyleBackColor = true;
            this.btnCheckExpired.Click += new System.EventHandler(this.btnCheckExpired_Click);
            // 
            // btnDeleteAllProducts
            // 
            this.btnDeleteAllProducts.Location = new System.Drawing.Point(651, 156);
            this.btnDeleteAllProducts.Name = "btnDeleteAllProducts";
            this.btnDeleteAllProducts.Size = new System.Drawing.Size(138, 61);
            this.btnDeleteAllProducts.TabIndex = 4;
            this.btnDeleteAllProducts.Text = "Xóa toàn bộ SP trong kho";
            this.btnDeleteAllProducts.UseVisualStyleBackColor = true;
            this.btnDeleteAllProducts.Click += new System.EventHandler(this.btnDeleteAllProducts_Click);
            // 
            // btnDeleteExpiredProducts
            // 
            this.btnDeleteExpiredProducts.Location = new System.Drawing.Point(798, 156);
            this.btnDeleteExpiredProducts.Name = "btnDeleteExpiredProducts";
            this.btnDeleteExpiredProducts.Size = new System.Drawing.Size(138, 61);
            this.btnDeleteExpiredProducts.TabIndex = 5;
            this.btnDeleteExpiredProducts.Text = "Xóa toàn bộ SP quá hạn";
            this.btnDeleteExpiredProducts.UseVisualStyleBackColor = true;
            this.btnDeleteExpiredProducts.Click += new System.EventHandler(this.btnDeleteExpiredProducts_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(342, 56);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Lưu SP";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(342, 88);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Xóa SP";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LinQ to Object - Quản lý sản phẩm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFindHighestPrice;
        private System.Windows.Forms.Button btnGetExpiredProducts;
        private System.Windows.Forms.Button btnFindJapanProduct;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Button btnGetProductsByPriceRange;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnDeleteAllProducts;
        private System.Windows.Forms.Button btnCheckExpired;
        private System.Windows.Forms.TextBox txtProductOriginToDelete;
        private System.Windows.Forms.Button btnDeleteProductsByOrigin;
        private System.Windows.Forms.Button btnDeleteExpiredProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}

