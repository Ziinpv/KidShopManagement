namespace QuanLyShopQuanAoTreEm.PAL
{
    partial class frmMainAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMovePanle = new System.Windows.Forms.Panel();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_BaoCao = new System.Windows.Forms.Button();
            this.btn_QuanLy = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picShopIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucReportCheckOut1 = new QuanLyShopQuanAoTreEm.PAL.ucReportCheckOut();
            this.ucProducts1 = new QuanLyShopQuanAoTreEm.PAL.ucProducts();
            this.ucUsers1 = new QuanLyShopQuanAoTreEm.PAL.ucUser();
            this.ucReports1 = new QuanLyShopQuanAoTreEm.PAL.ucReports();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShopIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.pnlMovePanle);
            this.panel1.Controls.Add(this.btnCLose);
            this.panel1.Controls.Add(this.btn_SanPham);
            this.panel1.Controls.Add(this.btn_BaoCao);
            this.panel1.Controls.Add(this.btn_QuanLy);
            this.panel1.Controls.Add(this.btn_HoaDon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picShopIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 622);
            this.panel1.TabIndex = 0;
            // 
            // pnlMovePanle
            // 
            this.pnlMovePanle.BackColor = System.Drawing.Color.White;
            this.pnlMovePanle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMovePanle.Location = new System.Drawing.Point(12, 187);
            this.pnlMovePanle.Name = "pnlMovePanle";
            this.pnlMovePanle.Size = new System.Drawing.Size(11, 50);
            this.pnlMovePanle.TabIndex = 2;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.White;
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.ForeColor = System.Drawing.Color.Black;
            this.btnCLose.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.Screenshot_2024_09_10_043314_removebg_preview;
            this.btnCLose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLose.Location = new System.Drawing.Point(40, 547);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(154, 41);
            this.btnCLose.TabIndex = 0;
            this.btnCLose.Text = "              Đăng Xuất";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.White;
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.ForeColor = System.Drawing.Color.Black;
            this.btn_SanPham.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.Screenshot_2024_09_10_042339_removebg_preview;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(40, 398);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(154, 49);
            this.btn_SanPham.TabIndex = 0;
            this.btn_SanPham.Text = "              Sản Phẩm";
            this.btn_SanPham.UseVisualStyleBackColor = false;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.BackColor = System.Drawing.Color.White;
            this.btn_BaoCao.FlatAppearance.BorderSize = 0;
            this.btn_BaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BaoCao.ForeColor = System.Drawing.Color.Black;
            this.btn_BaoCao.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.Screenshot_2024_09_10_042654_removebg_preview1;
            this.btn_BaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BaoCao.Location = new System.Drawing.Point(40, 331);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(154, 44);
            this.btn_BaoCao.TabIndex = 0;
            this.btn_BaoCao.Text = "              Báo Cáo";
            this.btn_BaoCao.UseVisualStyleBackColor = false;
            this.btn_BaoCao.Click += new System.EventHandler(this.btn_BaoCao_Click);
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.BackColor = System.Drawing.Color.White;
            this.btn_QuanLy.FlatAppearance.BorderSize = 0;
            this.btn_QuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLy.ForeColor = System.Drawing.Color.Black;
            this.btn_QuanLy.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.Screenshot_2024_09_10_043044_removebg_preview;
            this.btn_QuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLy.Location = new System.Drawing.Point(40, 258);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Size = new System.Drawing.Size(154, 49);
            this.btn_QuanLy.TabIndex = 0;
            this.btn_QuanLy.Text = "              Quản Lý";
            this.btn_QuanLy.UseVisualStyleBackColor = false;
            this.btn_QuanLy.Click += new System.EventHandler(this.btn_QuanLy_Click);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.White;
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.Black;
            this.btn_HoaDon.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.pngtree_dashboard_line_icon_vector_png_image_6626604;
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(40, 187);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(154, 50);
            this.btn_HoaDon.TabIndex = 0;
            this.btn_HoaDon.Text = "              Hóa Đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Shop Quần Áo Trẻ Em";
            // 
            // picShopIcon
            // 
            this.picShopIcon.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.LoginLogo_ico;
            this.picShopIcon.Location = new System.Drawing.Point(40, 11);
            this.picShopIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picShopIcon.Name = "picShopIcon";
            this.picShopIcon.Size = new System.Drawing.Size(113, 116);
            this.picShopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShopIcon.TabIndex = 16;
            this.picShopIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.lblDateTime);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(657, 38);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(43, 29);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "{?}";
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(187, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(43, 29);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "{?}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xin Chào: ";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 3;
            this.guna2Elipse1.TargetControl = this.pnlMovePanle;
            // 
            // ucReportCheckOut1
            // 
            this.ucReportCheckOut1.Location = new System.Drawing.Point(200, 100);
            this.ucReportCheckOut1.Name = "ucReportCheckOut1";
            this.ucReportCheckOut1.Size = new System.Drawing.Size(842, 522);
            this.ucReportCheckOut1.TabIndex = 3;
            // 
            // ucProducts1
            // 
            this.ucProducts1.BackColor = System.Drawing.Color.White;
            this.ucProducts1.Location = new System.Drawing.Point(200, 100);
            this.ucProducts1.Name = "ucProducts1";
            this.ucProducts1.Size = new System.Drawing.Size(842, 522);
            this.ucProducts1.TabIndex = 2;
            // 
            // ucUsers1
            // 
            this.ucUsers1.Location = new System.Drawing.Point(199, 100);
            this.ucUsers1.Margin = new System.Windows.Forms.Padding(2);
            this.ucUsers1.Name = "ucUsers1";
            this.ucUsers1.Size = new System.Drawing.Size(842, 522);
            this.ucUsers1.TabIndex = 4;
            // 
            // ucReports1
            // 
            this.ucReports1.Location = new System.Drawing.Point(199, 100);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(842, 522);
            this.ucReports1.TabIndex = 5;
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 622);
            this.Controls.Add(this.ucReports1);
            this.Controls.Add(this.ucUsers1);
            this.Controls.Add(this.ucReportCheckOut1);
            this.Controls.Add(this.ucProducts1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyShopQuanAoTreEm | MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShopIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShopIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_BaoCao;
        private System.Windows.Forms.Button btn_QuanLy;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateAndTime;
        private System.Windows.Forms.Panel pnlMovePanle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private ucProducts ucProducts1;
        private ucReportCheckOut ucReportCheckOut1;
        private ucUser ucUsers1;
        private ucReports ucReports1;
    }
}