﻿namespace QuanLyShopQuanAoTreEm.PAL
{
    partial class ucProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tpManagementProduct = new System.Windows.Forms.TabPage();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnReloadProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnReloadCategory = new Guna.UI2.WinForms.Guna2Button();
            this.lvwProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.brpFilter = new System.Windows.Forms.GroupBox();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.cmbSizeFilter = new System.Windows.Forms.ComboBox();
            this.lblLoaiSP1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNameFliter = new System.Windows.Forms.TextBox();
            this.lblSizeSP1 = new System.Windows.Forms.Label();
            this.picTimKiemSP = new System.Windows.Forms.PictureBox();
            this.lblTenSP1 = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbcProducts = new System.Windows.Forms.TabControl();
            this.tpManagementProduct.SuspendLayout();
            this.brpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiemSP)).BeginInit();
            this.tbcProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpManagementProduct
            // 
            this.tpManagementProduct.BackColor = System.Drawing.Color.White;
            this.tpManagementProduct.Controls.Add(this.btnDelete);
            this.tpManagementProduct.Controls.Add(this.btnShowAddProduct);
            this.tpManagementProduct.Controls.Add(this.btnReloadProducts);
            this.tpManagementProduct.Controls.Add(this.btnAddCategory);
            this.tpManagementProduct.Controls.Add(this.btnReloadCategory);
            this.tpManagementProduct.Controls.Add(this.lvwProducts);
            this.tpManagementProduct.Controls.Add(this.tvwCategory);
            this.tpManagementProduct.Controls.Add(this.brpFilter);
            this.tpManagementProduct.Controls.Add(this.lblTotalProducts);
            this.tpManagementProduct.Controls.Add(this.lblTotal);
            this.tpManagementProduct.Controls.Add(this.label7);
            this.tpManagementProduct.Location = new System.Drawing.Point(4, 4);
            this.tpManagementProduct.Name = "tpManagementProduct";
            this.tpManagementProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagementProduct.Size = new System.Drawing.Size(828, 490);
            this.tpManagementProduct.TabIndex = 1;
            this.tpManagementProduct.Text = "Quản Lý Sản Phẩm";
            // 
            // btnDelete
            // 
            this.btnDelete.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.btnDelete.DefaultAutoSize = true;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(424, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "-";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAddProduct
            // 
            this.btnShowAddProduct.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.btnShowAddProduct.DefaultAutoSize = true;
            this.btnShowAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnShowAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnShowAddProduct.Location = new System.Drawing.Point(379, 433);
            this.btnShowAddProduct.Name = "btnShowAddProduct";
            this.btnShowAddProduct.Size = new System.Drawing.Size(39, 28);
            this.btnShowAddProduct.TabIndex = 9;
            this.btnShowAddProduct.Text = "+";
            // 
            // btnReloadProducts
            // 
            this.btnReloadProducts.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.btnReloadProducts.DefaultAutoSize = true;
            this.btnReloadProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReloadProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReloadProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnReloadProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReloadProducts.ForeColor = System.Drawing.Color.White;
            this.btnReloadProducts.Location = new System.Drawing.Point(335, 433);
            this.btnReloadProducts.Name = "btnReloadProducts";
            this.btnReloadProducts.Size = new System.Drawing.Size(38, 28);
            this.btnReloadProducts.TabIndex = 9;
            this.btnReloadProducts.Text = "R";
            this.btnReloadProducts.UseWaitCursor = true;
            this.btnReloadProducts.Click += new System.EventHandler(this.btnReloadProducts_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.btnAddCategory.DefaultAutoSize = true;
            this.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(57, 433);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(39, 28);
            this.btnAddCategory.TabIndex = 9;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnReloadCategory
            // 
            this.btnReloadCategory.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.btnReloadCategory.DefaultAutoSize = true;
            this.btnReloadCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReloadCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReloadCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnReloadCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadCategory.ForeColor = System.Drawing.Color.White;
            this.btnReloadCategory.Location = new System.Drawing.Point(13, 433);
            this.btnReloadCategory.Name = "btnReloadCategory";
            this.btnReloadCategory.Size = new System.Drawing.Size(38, 28);
            this.btnReloadCategory.TabIndex = 9;
            this.btnReloadCategory.Text = "R";
            this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
            // 
            // lvwProducts
            // 
            this.lvwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwProducts.FullRowSelect = true;
            this.lvwProducts.GridLines = true;
            this.lvwProducts.HideSelection = false;
            this.lvwProducts.Location = new System.Drawing.Point(333, 146);
            this.lvwProducts.Name = "lvwProducts";
            this.lvwProducts.Size = new System.Drawing.Size(489, 280);
            this.lvwProducts.TabIndex = 8;
            this.lvwProducts.UseCompatibleStateImageBehavior = false;
            this.lvwProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Số";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sản Phẩm";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 35;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 61;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá Bán";
            this.columnHeader5.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nhóm Mặt Hàng";
            this.columnHeader6.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hình Ảnh";
            // 
            // tvwCategory
            // 
            this.tvwCategory.Location = new System.Drawing.Point(7, 146);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(319, 280);
            this.tvwCategory.TabIndex = 7;
            this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
            this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
            // 
            // brpFilter
            // 
            this.brpFilter.Controls.Add(this.cmbCategoryFilter);
            this.brpFilter.Controls.Add(this.cmbSizeFilter);
            this.brpFilter.Controls.Add(this.lblLoaiSP1);
            this.brpFilter.Controls.Add(this.label22);
            this.brpFilter.Controls.Add(this.txtNameFliter);
            this.brpFilter.Controls.Add(this.lblSizeSP1);
            this.brpFilter.Controls.Add(this.picTimKiemSP);
            this.brpFilter.Controls.Add(this.lblTenSP1);
            this.brpFilter.Location = new System.Drawing.Point(7, 26);
            this.brpFilter.Name = "brpFilter";
            this.brpFilter.Size = new System.Drawing.Size(815, 113);
            this.brpFilter.TabIndex = 5;
            this.brpFilter.TabStop = false;
            this.brpFilter.Text = "Bộ Lọc Sản Phẩm";
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Items.AddRange(new object[] {
            "-- Hãy Chọn Loại Sản Phẩm--",
            "Áo Thun",
            "Áo Khoác",
            "Áo Polo",
            "Quần Dài",
            "Quần Đùi",
            "Quần Short"});
            this.cmbCategoryFilter.Location = new System.Drawing.Point(6, 86);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(199, 21);
            this.cmbCategoryFilter.TabIndex = 6;
            // 
            // cmbSizeFilter
            // 
            this.cmbSizeFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSizeFilter.FormattingEnabled = true;
            this.cmbSizeFilter.Items.AddRange(new object[] {
            "--Hãy Chọn Size Sản Phẩm--",
            "S",
            "M",
            "L",
            "XL"});
            this.cmbSizeFilter.Location = new System.Drawing.Point(211, 87);
            this.cmbSizeFilter.Name = "cmbSizeFilter";
            this.cmbSizeFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbSizeFilter.TabIndex = 5;
            // 
            // lblLoaiSP1
            // 
            this.lblLoaiSP1.AutoSize = true;
            this.lblLoaiSP1.BackColor = System.Drawing.Color.White;
            this.lblLoaiSP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSP1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLoaiSP1.Location = new System.Drawing.Point(3, 66);
            this.lblLoaiSP1.Name = "lblLoaiSP1";
            this.lblLoaiSP1.Size = new System.Drawing.Size(40, 18);
            this.lblLoaiSP1.TabIndex = 0;
            this.lblLoaiSP1.Text = "Loại";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(467, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 18);
            this.label22.TabIndex = 0;
            // 
            // txtNameFliter
            // 
            this.txtNameFliter.Location = new System.Drawing.Point(3, 40);
            this.txtNameFliter.Name = "txtNameFliter";
            this.txtNameFliter.Size = new System.Drawing.Size(329, 20);
            this.txtNameFliter.TabIndex = 2;
            // 
            // lblSizeSP1
            // 
            this.lblSizeSP1.AutoSize = true;
            this.lblSizeSP1.BackColor = System.Drawing.Color.White;
            this.lblSizeSP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeSP1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSizeSP1.Location = new System.Drawing.Point(208, 66);
            this.lblSizeSP1.Name = "lblSizeSP1";
            this.lblSizeSP1.Size = new System.Drawing.Size(41, 18);
            this.lblSizeSP1.TabIndex = 0;
            this.lblSizeSP1.Text = "Size";
            // 
            // picTimKiemSP
            // 
            this.picTimKiemSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTimKiemSP.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.Screenshot_2024_09_10_042339_removebg_preview2;
            this.picTimKiemSP.Location = new System.Drawing.Point(763, 66);
            this.picTimKiemSP.Name = "picTimKiemSP";
            this.picTimKiemSP.Size = new System.Drawing.Size(46, 42);
            this.picTimKiemSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiemSP.TabIndex = 4;
            this.picTimKiemSP.TabStop = false;
            this.picTimKiemSP.MouseHover += new System.EventHandler(this.picTimKiemSP_MouseHover);
            // 
            // lblTenSP1
            // 
            this.lblTenSP1.AutoSize = true;
            this.lblTenSP1.BackColor = System.Drawing.Color.White;
            this.lblTenSP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenSP1.Location = new System.Drawing.Point(3, 19);
            this.lblTenSP1.Name = "lblTenSP1";
            this.lblTenSP1.Size = new System.Drawing.Size(118, 18);
            this.lblTenSP1.TabIndex = 0;
            this.lblTenSP1.Text = "Tên Sản Phẩm";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.BackColor = System.Drawing.Color.White;
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalProducts.Location = new System.Drawing.Point(113, 467);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(24, 16);
            this.lblTotalProducts.TabIndex = 0;
            this.lblTotalProducts.Text = "{?}";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(3, 467);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Tổng Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản Lý Sản Phẩm";
            // 
            // tbcProducts
            // 
            this.tbcProducts.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbcProducts.Controls.Add(this.tpManagementProduct);
            this.tbcProducts.Location = new System.Drawing.Point(3, 3);
            this.tbcProducts.Name = "tbcProducts";
            this.tbcProducts.SelectedIndex = 0;
            this.tbcProducts.Size = new System.Drawing.Size(836, 516);
            this.tbcProducts.TabIndex = 0;
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbcProducts);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(842, 522);
            this.tpManagementProduct.ResumeLayout(false);
            this.tpManagementProduct.PerformLayout();
            this.brpFilter.ResumeLayout(false);
            this.brpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiemSP)).EndInit();
            this.tbcProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private System.Windows.Forms.TabPage tpManagementProduct;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnShowAddProduct;
        private Guna.UI2.WinForms.Guna2Button btnReloadProducts;
        private Guna.UI2.WinForms.Guna2Button btnAddCategory;
        private Guna.UI2.WinForms.Guna2Button btnReloadCategory;
        private System.Windows.Forms.ListView lvwProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.GroupBox brpFilter;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.ComboBox cmbSizeFilter;
        private System.Windows.Forms.Label lblLoaiSP1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNameFliter;
        private System.Windows.Forms.Label lblSizeSP1;
        private System.Windows.Forms.PictureBox picTimKiemSP;
        private System.Windows.Forms.Label lblTenSP1;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tbcProducts;
    }
}
