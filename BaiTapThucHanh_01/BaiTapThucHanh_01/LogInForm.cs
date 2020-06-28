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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand(
                "SELECT * FROM Login WHERE taiKhoan=@taiKhoan AND matKhau=@matKhau", DB.Connection);
            sqlCmd.Parameters.AddWithValue("@taiKhoan", tbUserName.Text);
            sqlCmd.Parameters.AddWithValue("@matKhau", tbPassword.Text);

             DB.Connection.Open();

            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.HasRows)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc Mật khẩu không đúng!");
            }

            DB.Connection.Close();

            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        public void ClearLogInData()
        {
            tbUserName.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
    }
}
