using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThucHanh_01
{
    public partial class LopTCForm : Form
    {
        Dictionary<string, MonHoc> monHocsDic = new Dictionary<string, MonHoc>();

        public LopTCForm()
        {
            InitializeComponent();

            cbbMonHoc.DisplayMember = "TenMonHoc";
            cbbMonHoc.ValueMember = "MaMonHoc";

            LoadMonHocData();

            LoadLopTinChiData();
        }

        private void LoadMonHocData()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM MonHoc", DB.Connection);

            DB.Connection.Open();
            SqlDataReader dr = sqlCmd.ExecuteReader();

            monHocsDic = new Dictionary<string, MonHoc>();
            while (dr.Read())
            {
                MonHoc monHoc = new MonHoc((string)dr[0], (string)dr[1], (int)dr[2]);
                cbbMonHoc.Items.Add(monHoc);
                monHocsDic[monHoc.MaMonHoc] = monHoc;
            }

            DB.Connection.Close();
        }

        private void LoadLopTinChiData()
        {
            DB.Connection.Open();

            string sql = "SELECT LopTC.MaLopTC, LopTC.MaMH, MonHoc.TenMH, MonHoc.SoTC, LopTC.HocKy, LopTC.NamHoc " +
                "FROM LopTC " +
                "INNER JOIN MonHoc " +
                "ON LopTC.MaMH = MonHoc.MaMH;";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, DB.Connection);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgvLopTC.DataSource = ds.Tables[0];

            DB.Connection.Close();
        }

        private void dgvLopTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            tbMaLopTC.Text = dgvLopTC.Rows[e.RowIndex].Cells[0].Value.ToString();
            string maMonHoc = dgvLopTC.Rows[e.RowIndex].Cells[1].Value.ToString();
            string tenMonHoc = dgvLopTC.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbSoTinChi.Text = dgvLopTC.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbHocKy.Text = dgvLopTC.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNamHoc.Text = dgvLopTC.Rows[e.RowIndex].Cells[5].Value.ToString();

            MonHoc monHoc = monHocsDic[maMonHoc];
            cbbMonHoc.SelectedItem = monHoc;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMaLopTC.Text))
            {
                SqlCommand cmd = new SqlCommand("UPDATE LopTC SET MaMH=@maMonHoc,HocKy=@hocKy, NamHoc=@namHoc WHERE MaLopTC=@maLopTC", DB.Connection);
                DB.Connection.Open();

                cmd.Parameters.AddWithValue("@maLopTC", tbMaLopTC.Text);
                cmd.Parameters.AddWithValue("@maMonHoc", ((MonHoc)cbbMonHoc.SelectedItem).MaMonHoc);
                cmd.Parameters.AddWithValue("@hocKy", tbHocKy.Text);
                cmd.Parameters.AddWithValue("@namHoc", tbNamHoc.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa lớp tín chỉ thành công!");

                DB.Connection.Close();

                LoadLopTinChiData();
                ClearLopTinChiData();
            }
        }

        private void ClearLopTinChiData()
        {
            tbMaLopTC.Text = string.Empty;
            cbbMonHoc.SelectedIndex = -1;
            tbSoTinChi.Text = string.Empty;
            tbHocKy.Text = string.Empty;
            tbNamHoc.Text = string.Empty;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO LopTC(MaLopTC, MaMH, HocKy, NamHoc) VALUES(@maLopTC, @maMonHoc, @hocKy, @namHoc)", DB.Connection);
            DB.Connection.Open();

            cmd.Parameters.AddWithValue("@maLopTC", tbMaLopTC.Text);
            cmd.Parameters.AddWithValue("@maMonHoc", ((MonHoc)cbbMonHoc.SelectedItem).MaMonHoc);
            cmd.Parameters.AddWithValue("@hocKy", tbHocKy.Text);
            cmd.Parameters.AddWithValue("@namHoc", tbNamHoc.Text);

            cmd.ExecuteNonQuery();

            DB.Connection.Close();

            MessageBox.Show("Thêm Lớp tín chỉ thành công!!!");

            LoadLopTinChiData();
            ClearLopTinChiData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM LopTC WHERE MaLopTC=@maLopTC", DB.Connection);
            DB.Connection.Open();

            cmd.Parameters.AddWithValue("@maLopTC", tbMaLopTC.Text);

            cmd.ExecuteNonQuery();

            DB.Connection.Close();

            MessageBox.Show("Xóa Lớp tín chỉ thành công!!!");

            LoadLopTinChiData();
            ClearLopTinChiData();
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedIndex == -1)
            {
                tbSoTinChi.Text = "";
            }
            else
            {
                tbSoTinChi.Text = ((MonHoc)cbbMonHoc.SelectedItem).SoTinChi.ToString();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            DB.Connection.Open();

            string sql = "SELECT LopTC.MaLopTC, LopTC.MaMH, MonHoc.TenMH, MonHoc.SoTC, LopTC.HocKy, LopTC.NamHoc " +
                "FROM LopTC " +
                "INNER JOIN MonHoc " +
                "ON LopTC.MaMH = MonHoc.MaMH WHERE MonHoc.TenMH LIKE N'" + tbSearch.Text + "%'";
            
            SqlDataAdapter adapt = new SqlDataAdapter(sql, DB.Connection);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dgvLopTC.DataSource = ds.Tables[0];

            DB.Connection.Close();
        }
    }
}
