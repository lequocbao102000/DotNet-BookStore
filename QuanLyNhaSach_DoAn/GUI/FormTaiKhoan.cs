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
    public partial class FormTaiKhoan : Form
    {
        XuLy dt = new XuLy();
        public FormTaiKhoan()
        {
            InitializeComponent();
        }
        public string _textbox1
        {
            set { lbltenuser.Text = value; }
        }

        private void FormQLyNhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewqlnv.DataSource = dt.LoadTaiKhoan();
            btnsathai.Enabled = false;
            dt.DataBlindsNV(dt.LoadTaiKhoan(), lbltennv);
            txtten.Text = lbltenuser.Text;
            lbltennv.Visible = false;
            btnsathai.Enabled = false;
            btnluu.Enabled = false;
            txtten.Enabled = false;
            if (dt.Role(lbltenuser.Text)==1)
            {
                groupBox1.Hide();
            }
        }

        private void dataGridViewqlnv_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewqlnv.CurrentCell != null)
            {
                btnsathai.Enabled = true;
            }

        }

       

       

      


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnsathai_Click(object sender, EventArgs e)
        {
            dt.XoaNV(dataGridViewqlnv, lbltennv.Text);
            btnluu.Enabled = true;
            btnthoat.Enabled = false;
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            dt.ThemNV(dataGridViewqlnv);
            btnluu.Enabled = true;
            btnthoat.Enabled = false;
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (dt.LuuTaiKhoan())
            { MessageBox.Show("Lưu thành công !!!"); }
            btnthoat.Enabled = true;
            
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (dt.DoimkTaiKhoan(txtten.Text, txtmk.Text, txtnewmk.Text, txtnewmkxn.Text) == true)
            {
                if (dt.LuuTaiKhoan() == true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
            }
            

        }

        

       

     

       

        
    }
}
