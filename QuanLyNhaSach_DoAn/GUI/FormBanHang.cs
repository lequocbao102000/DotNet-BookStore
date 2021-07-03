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
    public partial class FormBanHang : Form
    {
        XuLy dt = new XuLy();
        public FormBanHang()
        {
            InitializeComponent();
        }
        public string _textbox1
        {
            set { lbltenuser.Text = value; }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {

            txtma.Enabled = txtgia.Enabled = txttensach.Enabled = false;
            datagirdviewsp.DataSource = dt.LoadSach();
            dt.DataBlindsSPSACH(dt.LoadSach(), txtma, txttensach, txtgia);
            panel1.Hide();
            datahdtest.DataSource = dt.LoadThemHD();
            datachitiet.DataSource = dt.LoadThemCTHD();
            
            button1.Enabled = false;
           lblnguoiban.Text = lbltenuser.Text;
           lblngay.Text = DateTime.Now.ToString();
           button2.Enabled = false;
           panel2.Hide();
           
           
          
        }

    
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncart_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            if (datagirdviewsp.CurrentRow.Cells[3].Value.ToString() == "0"
                || int.Parse(datagirdviewsp.CurrentRow.Cells[3].Value.ToString()) < int.Parse(txtsoluongmua.Value.ToString()))
            { MessageBox.Show("Khong du so luong"); }
            else
            {
                dt.ThemSPvaoCart(datacart, txtma.Text, txttensach.Text, txtgia.Text, txtsoluongmua.Value.ToString());
                lbltongtien.Text = dt.tongtien(datacart).ToString();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            datagirdviewsp.ClearSelection();
            dt.SearchSPHD(datagirdviewsp, txtsearch.Text, rdbma, rdbten);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltienhd.Text = lbltongtien.Text;
            lblsoluongcart.Text = dt.tongsach(datacart).ToString();
            panel1.Show();
            button2.Enabled = button1.Enabled = false;
            btncart.Enabled = false;
            btnthoat.Enabled = false;
            lblmahd.Text = dt.RandomMa(datahdtest).ToString();
         
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            datacart.Rows.Clear();
            lbltongtien.Text = "";
            button1.Enabled =button2.Enabled= false;
            btncart.Enabled = true;
            btnthoat.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datacart.Rows.Clear();
            button1.Enabled= button2.Enabled = false;
            lbltongtien.Text = "";
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dt.ThemHD(lblmahd.Text,lblnguoiban.Text, txtkhachmua.Text,lblngay.Text,lbltienhd.Text))
            {
                dt.LuuHD();
                
                MessageBox.Show("Thanh toán thành công"); 
            }
            dt.ThemCTHD(datacart,datagirdviewsp, lblmahd.Text);
            lbltongtien.Text = "";
            panel1.Hide();
            btncart.Enabled = true;
            datacart.Rows.Clear();
            btnthoat.Enabled = true;


        }

       

      

      
    }
}
