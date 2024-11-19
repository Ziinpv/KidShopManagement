namespace QuanLyShopQuanAoTreEm.PAL
{
    partial class frmForgotPassWord
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
            this.btnRSPass = new System.Windows.Forms.Button();
            this.txtSoCCCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picLoginIcon = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picShopIcon = new System.Windows.Forms.PictureBox();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShopIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRSPass
            // 
            this.btnRSPass.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRSPass.FlatAppearance.BorderSize = 0;
            this.btnRSPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRSPass.Location = new System.Drawing.Point(112, 359);
            this.btnRSPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnRSPass.Name = "btnRSPass";
            this.btnRSPass.Size = new System.Drawing.Size(209, 31);
            this.btnRSPass.TabIndex = 3;
            this.btnRSPass.Text = "Forgot PassWord";
            this.btnRSPass.UseVisualStyleBackColor = false;
            this.btnRSPass.Click += new System.EventHandler(this.btnRSPass_Click);
            // 
            // txtSoCCCD
            // 
            this.txtSoCCCD.Location = new System.Drawing.Point(112, 314);
            this.txtSoCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoCCCD.Name = "txtSoCCCD";
            this.txtSoCCCD.Size = new System.Drawing.Size(209, 20);
            this.txtSoCCCD.TabIndex = 2;
            this.txtSoCCCD.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số CCCD :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(112, 255);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName :";
            // 
            // picLoginIcon
            // 
            this.picLoginIcon.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.LoginIcon;
            this.picLoginIcon.Location = new System.Drawing.Point(134, 51);
            this.picLoginIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picLoginIcon.Name = "picLoginIcon";
            this.picLoginIcon.Size = new System.Drawing.Size(150, 162);
            this.picLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginIcon.TabIndex = 31;
            this.picLoginIcon.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.Exit;
            this.picClose.Location = new System.Drawing.Point(381, 6);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 49);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 30;
            this.picClose.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.picClose, "Close");
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kid Clothes Shop Management | LogIn";
            // 
            // picShopIcon
            // 
            this.picShopIcon.Image = global::QuanLyShopQuanAoTreEm.Properties.Resources.LoginLogo_ico;
            this.picShopIcon.Location = new System.Drawing.Point(0, -2);
            this.picShopIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picShopIcon.Name = "picShopIcon";
            this.picShopIcon.Size = new System.Drawing.Size(75, 81);
            this.picShopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShopIcon.TabIndex = 29;
            this.picShopIcon.TabStop = false;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnRSPass;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmForgotPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.btnRSPass);
            this.Controls.Add(this.txtSoCCCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLoginIcon);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picShopIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPassWord";
            ((System.ComponentModel.ISupportInitialize)(this.picLoginIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShopIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRSPass;
        private System.Windows.Forms.TextBox txtSoCCCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLoginIcon;
        private System.Windows.Forms.PictureBox picClose;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picShopIcon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}