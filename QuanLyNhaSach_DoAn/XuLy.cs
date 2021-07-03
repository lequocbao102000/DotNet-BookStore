using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLyNhaSach_DoAn
{
    public class XuLy
    {

        SqlConnection cnn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QL_NHASACH2;User ID=sa;Password=sa2012");
        DataSet ds_QLNS = new DataSet();
        SqlDataAdapter ds_Sach;
        SqlDataAdapter ds_HoaDon;
        SqlDataAdapter ds_qlnv;
        SqlDataAdapter ds_sach1;
        SqlDataAdapter ds_hoadon1;
        SqlDataAdapter ds_chitiet;
        public XuLy()
        {
            //TAIKHOAN
            ds_qlnv = new SqlDataAdapter("select* from TAIKHOAN", cnn);
            ds_qlnv.Fill(ds_QLNS, "TAIKHOAN");
            DataColumn[] khoachinhnv = new DataColumn[1];
            khoachinhnv[0] = ds_QLNS.Tables["TAIKHOAN"].Columns[0];
            ds_QLNS.Tables["TAIKHOAN"].PrimaryKey = khoachinhnv;




        }

        public int KTDN(string pTenDN, string pMatKhau)
        {

            try
            {
                DataRow dr_NV = ds_QLNS.Tables["TAIKHOAN"].Rows.Find(pTenDN);

                if (dr_NV == null)
                    return 0;
                else
                {
                    if (dr_NV["matkhau"].ToString().Trim() == pMatKhau)
                    {
                        if (dr_NV["chucvu"].ToString().Trim() == "Nhân viên")
                            return 1;
                        else return 2;
                    }
                       
                    else
                        return 0;

                }
            }
            catch { return 0; }
        }
       
        public int Role(string ten)
        {
            DataRow dr_checknv = ds_QLNS.Tables["TAIKHOAN"].Rows.Find(ten);

            if (dr_checknv == null)
                return 0;
            else
            {
                if (dr_checknv["chucvu"].ToString().Trim() == "Nhân viên")
                    return 1;
                else return 2;
            }
        }
       
        //form SACH
        public DataTable LoadChuDe()
        {
            SqlDataAdapter ds_Chude = new SqlDataAdapter("select *from CHUDE", cnn);
            ds_Chude.Fill(ds_QLNS, "CHUDE");
            return ds_QLNS.Tables["CHUDE"];
        }
        public DataTable LoadNXB()
        {
            SqlDataAdapter ds_nxb = new SqlDataAdapter("select *from NHAXUATBAN", cnn);
            ds_nxb.Fill(ds_QLNS, "NHAXUATBAN");
            return ds_QLNS.Tables["NHAXUATBAN"];
        }
        public DataTable LoadTG()
        {
            SqlDataAdapter ds_tg = new SqlDataAdapter("select *from TACGIA", cnn);
            ds_tg.Fill(ds_QLNS, "TACGIA");
            return ds_QLNS.Tables["TACGIA"];
        }
        public DataTable LoadSach()
        {
            ds_Sach = new SqlDataAdapter("select * from SACH", cnn);
            ds_Sach.Fill(ds_QLNS, "SACH");
            DataColumn[] khoachinhsach = new DataColumn[1];
            khoachinhsach[0] = ds_QLNS.Tables["SACH"].Columns[0];
            ds_QLNS.Tables["SACH"].PrimaryKey = khoachinhsach;
            return ds_QLNS.Tables["SACH"];
        }
        public void DataBlindsSach(DataTable pDT, Label pMa, Label pTen, Label pGia, Label pSl, Label pMoTa)
        {
            pMa.DataBindings.Clear();
            pTen.DataBindings.Clear();
            pGia.DataBindings.Clear();
            pSl.DataBindings.Clear();
            pMoTa.DataBindings.Clear();


            pMa.DataBindings.Add("Text", pDT, "masach");
            pTen.DataBindings.Add("Text", pDT, "tensach");
            pGia.DataBindings.Add("Text", pDT, "gia");
            pSl.DataBindings.Add("Text", pDT, "soluong");
            pMoTa.DataBindings.Add("Text", pDT, "mota");


        }
        public void Search(DataGridView pdg, string timkiem, RadioButton ma, RadioButton ten)
        {
            if (ma.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(timkiem))
                    {

                        pdg.Rows[row.Index].Selected = true;

                        break;
                    }
                }
            }
            else if (ten.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(timkiem))
                    {

                        pdg.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
        }
        public void Them(DataGridView pdg)
        {

            pdg.AllowUserToAddRows = true;
            pdg.ReadOnly = false;
            //khong dc sua cac dong tren datagirdView da co du lieu
            for (int i = 0; i < pdg.Rows.Count - 1; i++)
            {
                pdg.Rows[i].ReadOnly = true;
            }

            pdg.FirstDisplayedScrollingRowIndex = pdg.Rows.Count - 1;

        }
        public bool LuuSach()
        {
            try
            {
                SqlDataAdapter dsSachluu = new SqlDataAdapter("select*from SACH", cnn);
                SqlCommandBuilder build = new SqlCommandBuilder(dsSachluu);
                dsSachluu.Update(ds_QLNS, "SACH");
                return true;
            }
            catch { return false; }
        }
        public bool Xoa(DataGridView pdg, string pMa)
        {

            pdg.ReadOnly = false;
            try
            {
                DataRow dr_xoasach = ds_QLNS.Tables["SACH"].Rows.Find(pMa);
                if (dr_xoasach != null)
                {
                    dr_xoasach.Delete();

                }
                return true;
            }
            catch { return false; }


        }
        public void SuaSach(DataGridView pdg, string tenuser)
        {
            pdg.ReadOnly = false;
            for (int i = 0; i < pdg.Rows.Count - 1; i++)
            {
                pdg.Rows[i].ReadOnly = false;


            }
            if (Role(tenuser)==2)
            {
                pdg.Columns[0].ReadOnly = true;
            }
            else
            {
                pdg.Columns[0].ReadOnly = true;
                pdg.Columns[2].ReadOnly = true;
                pdg.Columns[3].ReadOnly = true;
            }
            pdg.AllowUserToAddRows = false;

        }
        //Form ban hang

        public DataTable LoadThemHD()
        {
            ds_hoadon1 = new SqlDataAdapter("select * from HOADON", cnn);
            ds_hoadon1.Fill(ds_QLNS, "HOADON");
            DataColumn[] khoachinhhd = new DataColumn[1];
            khoachinhhd[0] = ds_QLNS.Tables["HOADON"].Columns[0];
            ds_QLNS.Tables["HOADON"].PrimaryKey = khoachinhhd;
            return ds_QLNS.Tables["HOADON"];
        }
     

        public DataTable LoadThemCTHD()
        {
            ds_HoaDon = new SqlDataAdapter("select * from CHITIETHOADON", cnn);
            ds_HoaDon.Fill(ds_QLNS, "CHITIETHOADON");
            //DataColumn[] khoachinhcthd = new DataColumn[1];
            //khoachinhcthd[0] = ds_QLNS.Tables["CHITIETHOADON"].Columns[0];
            //ds_QLNS.Tables["CHITIETHOADON"].PrimaryKey = khoachinhcthd;
            return ds_QLNS.Tables["CHITIETHOADON"];

        }

        public void ThemSPvaoCart(DataGridView pdg, string ma, string ten, string gia, string psoluong)
        {
            int soluong = int.Parse(psoluong);
            int dem = 0;
            for (int i = 0; i < pdg.Rows.Count; i++)
            {
                if (ma == pdg.Rows[i].Cells[0].Value.ToString())
                {

                    pdg.Rows[i].Cells[3].Value = int.Parse(pdg.Rows[i].Cells[3].Value.ToString()) + soluong;
                    pdg.Rows[i].Cells[4].Value = int.Parse(pdg.Rows[i].Cells[3].Value.ToString()) * int.Parse(pdg.Rows[i].Cells[2].Value.ToString());
                    dem = 1;
                }

            }
            if (dem != 1)
            {
                int thanhtien = int.Parse(gia) * int.Parse(psoluong);
                string[] row = { ma, ten, gia, psoluong, thanhtien.ToString() };
                pdg.Rows.Add(row);
            }

        }

        public int tongtien(DataGridView pdg)
        {
            int thanhtien = 0;
            for (int i = 0; i < pdg.Rows.Count; i++)
            {
                thanhtien += int.Parse(pdg.Rows[i].Cells[4].Value.ToString());
            }
            return thanhtien;
        }
        public int tongsach(DataGridView pdg)
        {
            int sach = 0;
            for (int i = 0; i < pdg.Rows.Count; i++)
            {
                sach += int.Parse(pdg.Rows[i].Cells[3].Value.ToString());
            }
            return sach;
        }



        public void DataBlindsSPSACH(DataTable pDT, TextBox pMa, TextBox pten, TextBox gia)
        {
            pMa.DataBindings.Clear();
            pten.DataBindings.Clear();
            gia.DataBindings.Clear();



            pMa.DataBindings.Add("Text", pDT, "masach");
            pten.DataBindings.Add("Text", pDT, "tensach");
            gia.DataBindings.Add("Text", pDT, "gia");
            ;


        }
        public void SearchSPHD(DataGridView pdg, string timkiem, RadioButton ma, RadioButton ten)
        {
            if (ma.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(timkiem))
                    {

                        pdg.Rows[row.Index].Selected = true;

                        break;
                    }
                }
            }
            else if (ten.Checked == true)
            {
                foreach (DataGridViewRow row in pdg.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(timkiem))
                    {

                        pdg.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
        }
        public int RandomMa(DataGridView pdg)
        {
            Random rd = new Random();
            int ma = rd.Next(1, 10000);
            foreach (DataGridViewRow row in pdg.Rows)
            {
                if (String.Compare(row.Cells[0].Value.ToString(), ma.ToString(), true) == 0)
                {
                    ma = rd.Next(1, 10000);

                }
            }
            return ma;

        }
        public bool ThemHD(string mahd, string tennv, string khach, string ngay, string tongtien)
        {
            try
            {
                DataRow dr_themhd = ds_QLNS.Tables["HOADON"].NewRow();
                dr_themhd["mahd"] = mahd;
                dr_themhd["nguoiban"] = tennv;
                dr_themhd["khachmua"] = khach;
                dr_themhd["ngaymua"] = ngay;
                dr_themhd["tongtien"] = tongtien;
                ds_QLNS.Tables["HOADON"].Rows.Add(dr_themhd);

                return true;
            }
            catch { return false; }

        }
        public bool LuuHD()
        {
            try
            {
                SqlDataAdapter dsluuhd = new SqlDataAdapter("select*from HOADON", cnn);
                SqlCommandBuilder build = new SqlCommandBuilder(dsluuhd);
                dsluuhd.Update(ds_QLNS, "HOADON");
                return true;

            }
            catch { return false; }
        }
        public void ThemCTHD(DataGridView pdg, DataGridView pdg2, string mahd)
        {
            try {
                for (int i = 0; i < pdg.Rows.Count; i++)
                {

                    SqlDataAdapter dsluucthd = new SqlDataAdapter("select*from CHITIETHOADON", cnn);

                    DataRow dr_themcthd = ds_QLNS.Tables["CHITIETHOADON"].NewRow();
                    dr_themcthd["mahd"] = mahd;
                    dr_themcthd["masach"] = pdg.Rows[i].Cells[0].Value.ToString();
                    dr_themcthd["soluong"] = pdg.Rows[i].Cells[3].Value.ToString();
                    dr_themcthd["thanhtien"] = pdg.Rows[i].Cells[4].Value.ToString();
                    ds_QLNS.Tables["CHITIETHOADON"].Rows.Add(dr_themcthd);
                    SqlCommandBuilder build = new SqlCommandBuilder(dsluucthd);
                    dsluucthd.Update(ds_QLNS, "CHITIETHOADON");

                    SqlDataAdapter dscapnhat = new SqlDataAdapter("select*from SACH", cnn);
                    DataRow dr_capnhat = ds_QLNS.Tables["SACH"].Rows.Find(pdg.Rows[i].Cells[0].Value.ToString());
                    dr_capnhat["soluong"] = (int.Parse(dr_capnhat["soluong"].ToString()) - int.Parse(pdg.Rows[i].Cells[3].Value.ToString())).ToString();
                    SqlCommandBuilder build1 = new SqlCommandBuilder(dscapnhat);
                    dscapnhat.Update(ds_QLNS, "SACH");

                }
            }
            catch { }
            }
            //Form Tài khoản
            public DataTable LoadTaiKhoan()
        {
            ds_qlnv = new SqlDataAdapter("select* from TAIKHOAN", cnn);
            ds_qlnv.Fill(ds_QLNS, "TAIKHOAN");
            DataColumn[] khoachinhnv = new DataColumn[1];
            khoachinhnv[0] = ds_QLNS.Tables["TAIKHOAN"].Columns[0];
            ds_QLNS.Tables["TAIKHOAN"].PrimaryKey = khoachinhnv;
            return ds_QLNS.Tables["TAIKHOAN"];
        }
        public void ThemNV(DataGridView pdg)
        {

            pdg.AllowUserToAddRows = true;
            pdg.ReadOnly = false;
            //khong dc sua cac dong tren datagirdView da co du lieu
            for (int i = 0; i < pdg.Rows.Count - 1; i++)
            {
                pdg.Rows[i].ReadOnly = true;
            }

            pdg.FirstDisplayedScrollingRowIndex = pdg.Rows.Count - 1;

        }
        public bool XoaNV(DataGridView pdg, string ptentk)
        {
            pdg.ReadOnly = false;
            try
            {
                DataRow dr_xoanv = ds_QLNS.Tables["TAIKHOAN"].Rows.Find(ptentk);
                if (dr_xoanv != null)
                {
                    dr_xoanv.Delete();
                }
                return true;
            }
            catch { return false; }
        }
        public bool DoimkTaiKhoan(string ten, string mkht, string mkmoi, string mkmoi2)
        {
            try
            {
                DataRow dr_doimk = ds_QLNS.Tables["TAIKHOAN"].Rows.Find(ten);

                if (dr_doimk != null)
                {
                    if (dr_doimk["matkhau"].ToString().Trim() == mkht)
                    {
                        if (String.Compare(mkmoi, mkmoi2, true) == 0)
                        {
                            dr_doimk["matkhau"] = mkmoi;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;

            }
            catch { return false; }
        }
       
        public bool LuuTaiKhoan()
        {
            try
            {
                SqlDataAdapter dsluu = new SqlDataAdapter("select*from TAIKHOAN", cnn);
                SqlCommandBuilder build = new SqlCommandBuilder(dsluu);
                dsluu.Update(ds_QLNS, "TAIKHOAN");
                return true;

            }
            catch { return false; }
        }
       
        public void DataBlindsNV(DataTable pDT, Label tk)
        {
            tk.DataBindings.Clear();

            tk.DataBindings.Add("Text", pDT, "tentk");



        }
        public void SearchNV(DataGridView pdg, string timkiem)
        {

            foreach (DataGridViewRow row in pdg.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().Equals(timkiem))
                {

                    pdg.Rows[row.Index].Selected = true;

                    break;
                }
            }

        }

        //Form quản lý hóa đơn

        public DataTable LoadChiTiet()
        {
            ds_chitiet = new SqlDataAdapter("select*from CHITIETHOADON", cnn);
            ds_chitiet.Fill(ds_QLNS,"CHITIETHOADON");
            return ds_QLNS.Tables["CHITIETHOADON"];
        }
        public void SearchQLHD(DataGridView pdg, string timkiem)
        {

            foreach (DataGridViewRow row in pdg.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(timkiem))
                {

                    pdg.Rows[row.Index].Selected = true;

                    break;
                }
            }

        }
        public void DataBlindsHD(DataTable pDT, Label mahd)
        {
            mahd.DataBindings.Clear();

            mahd.DataBindings.Add("Text", pDT, "mahd");



        }
        public bool XoaHD(DataGridView pdg, string pma)
        {
            pdg.ReadOnly = false;
            try
            {
                //DataRow dr_xoacthd = ds_QLNS.Tables["CHITIETHOADON"].Rows.Find(pma);
                //if (dr_xoacthd != null)
                //{
                //    dr_xoacthd.Delete();
                //    SqlDataAdapter dsluucthd = new SqlDataAdapter("select*from CHITIETHOADON", cnn);
                //    SqlCommandBuilder build = new SqlCommandBuilder(dsluucthd);
                //    dsluucthd.Update(ds_QLNS, "CHITIETHOADON");
                //}

                DataRow dr_xoahd = ds_QLNS.Tables["HOADON"].Rows.Find(pma);
                if (dr_xoahd != null)
                {
                    dr_xoahd.Delete();
                    SqlDataAdapter dsluuhd = new SqlDataAdapter("select*from HOADON", cnn);
                    SqlCommandBuilder build = new SqlCommandBuilder(dsluuhd);
                    dsluuhd.Update(ds_QLNS, "HOADON");
                }
                return true;
            }
            catch { return false; }
        }
        public void XoaCTHD( DataGridView pdg,string pma)
        {
            
            try
            {
                for (int i = 0; i < pdg.Rows.Count; i++)
                {
                    string ma = pdg.Rows[i].Cells[0].Value.ToString();
                    if (String.Compare(ma,pma)==0)
                    {
                        pdg.Rows.Remove(pdg.Rows[i]);
                        
                        
                    }
                   
                }
                
            }
            catch { }
        }
        public void LuuCTHD()
        {

            try
            {

                SqlDataAdapter dsluuchitiet = new SqlDataAdapter("select * from CHITIETHOADON", cnn);
                SqlCommandBuilder build1= new SqlCommandBuilder(dsluuchitiet);
                dsluuchitiet.Update(ds_QLNS, "CHITIETHOADON");
            }
            catch { }
        }
        public int tongdoanhthu(DataGridView pdg)
        {
            int doanhthu = 0;
            for (int i = 0; i < pdg.Rows.Count; i++)
            {
                doanhthu += int.Parse(pdg.Rows[i].Cells[4].Value.ToString());
            }
            return doanhthu;
        }
        public int tonghd(DataGridView pdg)
        {
            int tongsohd = pdg.Rows.Count;
            return tongsohd;
        }
    }
}

