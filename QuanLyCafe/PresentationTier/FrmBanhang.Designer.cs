namespace QuanLyCafe.PresentationTier
{
    partial class FrmBanhang
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
            this.pnlBan = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDanhSachMon = new System.Windows.Forms.DataGridView();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDanhMuc = new System.Windows.Forms.ComboBox();
            this.cbxMon = new System.Windows.Forms.ComboBox();
            this.nupSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nupGiamGia = new System.Windows.Forms.NumericUpDown();
            this.cbxDoiBan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnDoiBan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBan
            // 
            this.pnlBan.BackColor = System.Drawing.SystemColors.Info;
            this.pnlBan.Location = new System.Drawing.Point(12, 51);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(793, 614);
            this.pnlBan.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1394, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý ";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất ";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(811, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh  mục ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(820, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(811, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng ";
            // 
            // dgvDanhSachMon
            // 
            this.dgvDanhSachMon.AllowUserToAddRows = false;
            this.dgvDanhSachMon.AllowUserToDeleteRows = false;
            this.dgvDanhSachMon.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMon,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgvDanhSachMon.Location = new System.Drawing.Point(815, 198);
            this.dgvDanhSachMon.Name = "dgvDanhSachMon";
            this.dgvDanhSachMon.ReadOnly = true;
            this.dgvDanhSachMon.RowHeadersWidth = 51;
            this.dgvDanhSachMon.RowTemplate.Height = 24;
            this.dgvDanhSachMon.Size = new System.Drawing.Size(574, 290);
            this.dgvDanhSachMon.TabIndex = 5;
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Tên Món ";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            this.colTenMon.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng ";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá ";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "ThanhTien";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 125;
            // 
            // cbxDanhMuc
            // 
            this.cbxDanhMuc.FormattingEnabled = true;
            this.cbxDanhMuc.Location = new System.Drawing.Point(971, 55);
            this.cbxDanhMuc.Name = "cbxDanhMuc";
            this.cbxDanhMuc.Size = new System.Drawing.Size(121, 24);
            this.cbxDanhMuc.TabIndex = 7;
            this.cbxDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbxDanhMuc_SelectedIndexChanged);
            // 
            // cbxMon
            // 
            this.cbxMon.FormattingEnabled = true;
            this.cbxMon.Location = new System.Drawing.Point(971, 98);
            this.cbxMon.Name = "cbxMon";
            this.cbxMon.Size = new System.Drawing.Size(121, 24);
            this.cbxMon.TabIndex = 8;
            // 
            // nupSoLuong
            // 
            this.nupSoLuong.Location = new System.Drawing.Point(971, 153);
            this.nupSoLuong.Name = "nupSoLuong";
            this.nupSoLuong.Size = new System.Drawing.Size(120, 22);
            this.nupSoLuong.TabIndex = 9;
            // 
            // nupGiamGia
            // 
            this.nupGiamGia.Location = new System.Drawing.Point(939, 574);
            this.nupGiamGia.Name = "nupGiamGia";
            this.nupGiamGia.Size = new System.Drawing.Size(120, 22);
            this.nupGiamGia.TabIndex = 10;
            // 
            // cbxDoiBan
            // 
            this.cbxDoiBan.FormattingEnabled = true;
            this.cbxDoiBan.Items.AddRange(new object[] {
            "Bàn 1 ",
            "Bàn 2 ",
            "Bàn 3",
            "Bàn 4 ",
            "Bàn 5 ",
            "Bàn 6 ",
            "Bàn 7 ",
            "Bàn 8 ",
            "Bàn 9 ",
            "Bàn 10 ",
            "Bàn 11",
            "Bàn 12",
            " Bàn 13",
            "Bàn 14",
            "Bàn 15",
            "Bàn 16",
            "Bàn 17",
            "Bàn 18",
            "Bàn 19",
            "Bàn 20",
            "Bàn 21",
            "Bàn 22",
            "Bàn 23",
            "Bàn 24",
            "Bàn 25"});
            this.cbxDoiBan.Location = new System.Drawing.Point(939, 631);
            this.cbxDoiBan.Name = "cbxDoiBan";
            this.cbxDoiBan.Size = new System.Drawing.Size(121, 24);
            this.cbxDoiBan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(824, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giảm giá ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(857, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thành Tiền ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(987, 504);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(243, 22);
            this.txtThanhTien.TabIndex = 16;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Magneto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::QuanLyCafe.Properties.Resources._2;
            this.btnThanhToan.Location = new System.Drawing.Point(1135, 591);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(108, 64);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh Toán ";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Magneto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Image = global::QuanLyCafe.Properties.Resources._4;
            this.btnThemMon.Location = new System.Drawing.Point(1122, 83);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(108, 64);
            this.btnThemMon.TabIndex = 10;
            this.btnThemMon.Text = "Thêm món ";
            this.btnThemMon.UseVisualStyleBackColor = true;
            // 
            // btnDoiBan
            // 
            this.btnDoiBan.Image = global::QuanLyCafe.Properties.Resources._2;
            this.btnDoiBan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiBan.Location = new System.Drawing.Point(824, 622);
            this.btnDoiBan.Name = "btnDoiBan";
            this.btnDoiBan.Size = new System.Drawing.Size(92, 33);
            this.btnDoiBan.TabIndex = 17;
            this.btnDoiBan.Text = "Đổi bàn ";
            this.btnDoiBan.UseVisualStyleBackColor = true;
            // 
            // FrmBanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1394, 703);
            this.Controls.Add(this.btnDoiBan);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDoiBan);
            this.Controls.Add(this.nupGiamGia);
            this.Controls.Add(this.nupSoLuong);
            this.Controls.Add(this.cbxMon);
            this.Controls.Add(this.cbxDanhMuc);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.dgvDanhSachMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBanhang";
            this.Text = "Màn hình bán hàng ";
            this.Load += new System.EventHandler(this.FrmBanhang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDanhSachMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbxDanhMuc;
        private System.Windows.Forms.ComboBox cbxMon;
        private System.Windows.Forms.NumericUpDown nupSoLuong;
        private System.Windows.Forms.NumericUpDown nupGiamGia;
        private System.Windows.Forms.ComboBox cbxDoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnDoiBan;
    }
}