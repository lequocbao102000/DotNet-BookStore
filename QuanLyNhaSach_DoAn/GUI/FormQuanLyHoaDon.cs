using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach_DoAn
{
    public partial class FormQuanLyHoaDon : Form
    {
        XuLy dt = new XuLy();
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }
        public string _textbox1
        {
            set { lbltenuser.Text = value; }
        }

        private void FormQuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datadshd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datadshd_SelectionChanged(object sender, EventArgs e)
        {
            if (datadshd.CurrentCell != null)
            {
                btnxoa.Enabled = true;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            datadshd.ClearSelection();
            dt.SearchQLHD(datadshd, txtsearch.Text);
        }

        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            datadshd.DataSource = dt.LoadThemHD();
            datachitiet.DataSource = dt.LoadChiTiet();
            dt.DataBlindsHD(dt.LoadThemHD(), lblhdchon);
            lbltonghd.Text = dt.tonghd(datadshd).ToString();
            lbldoanhthu.Text = dt.tongdoanhthu(datadshd).ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {   dt.XoaCTHD(datachitiet,lblhdchon.Text);
            dt.LuuCTHD();
            dt.XoaHD(datadshd, lblhdchon.Text);
            
                
                { MessageBox.Show("Đã xóa hóa đơn"); }
                
                lbltonghd.Text = dt.tonghd(datadshd).ToString();
                lbldoanhthu.Text = dt.tongdoanhthu(datadshd).ToString();
            
            
        }

        private void datachitiet_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
