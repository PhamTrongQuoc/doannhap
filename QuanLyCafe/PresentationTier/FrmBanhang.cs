using QuanLyCafe.DataTier.Models;
using QuanLyCafe.LogicTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.PresentationTier
{
    public partial class FrmBanhang : Form
    {
        private const int w = 105;
        private const int h = 81;
        private const int _X = 144;
        private const int _Y = 110;
        private const int COT = 5;
        private int maSoBanChon = -1;

        private BanCafeBUS banCafeBUS;
        private DanhMucBUS DanhMucBUS;
        private MonBus monBUS;


        public FrmBanhang()
        {
            InitializeComponent();
            CaiDatDieuKhien();
            
            banCafeBUS = new BanCafeBUS();
            DanhMucBUS = new DanhMucBUS();
            monBUS = new MonBus();
        }
        private void CaiDatDieuKhien()
        {
            cbxDanhMuc.DisplayMember = "ten";
            cbxDanhMuc.ValueMember = " MaDanhMuc";
            cbxMon.DisplayMember = "ten";
            cbxMon.ValueMember = "MaMon";
        }
        private void Taonut(int x ,int y ,BanCafe ban)

        {
            Button btn = new Button();
            btn.Location = new Point(x,y);
            btn.Size = new Size(w, h);
            btn.Text = ban.TenBan;
            btn.Tag = ban.MaSoBan;
            btn.BackColor = Color.White;
            btn.Click += Btn_Click;
            pnlBan.Controls.Add(btn);
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            if (btnBanChon == null9)



            Button btn = (Button)sender;
            
            int maSoBan = int.Parse(btn.Tag.ToString());
            if(maSoBanChon == -1)
            {
                maSoBanChon = maSoBan;
                btn.BackColor = Color.Yellow;
               
            }
             else if(maSoBan != maSoBanChon) 
            {
                //
                pnlBan.Controls.OfType<Button>().Where(x=>
                x.Tag.ToString()==
                maSoBanChon.ToString()).FirstOrDefault().BackColor = Color.White;
                maSoBanChon = maSoBan;
                btn.BackColor = Color.YellowGreen;
            }
            else
            {
                btn.BackColor = Color.Yellow;
                maSoBanChon = -1;
            }
           /* maSoBanChon = int.Parse(btn.Tag.ToString());    
            btn.BackColor = Color.GreenYellow;
            MessageBox.Show(maSoBanChon.ToString());*/
        }

        private void KhoiTaoSoBan()
        {
            int x = 26;
            int y = 29;
            int count = 0;
            foreach(BanCafe ban in banCafeBUS.GetBans())
            {
                Taonut(x, y, ban);
                count++;
                if(count % COT == 0)
                {
                    y += _Y;
                    x = 26;
                    continue;
                }
                x += _Y;
            }
            
         
        }
        private void FrmBanhang_Load(object sender, EventArgs e)
        {
            KhoiTaoSoBan();
            LoadDanhMuc();
            WindowState = FormWindowState.Maximized; 
        }
        private void LoadDanhMuc()
        {
            cbxDanhMuc.DataSource = DanhMucBUS.GetMucDALs();
        }

        private void cbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            int maDanhMuc = int.Parse(cbx.SelectedValue.ToString());
            cbxMon.DataSource = monBUS.GetMons(maDanhMuc);
        }
    }
}
