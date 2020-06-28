using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThucHanh_01
{
    public partial class HeThongForm : Form
    {
        public HeThongForm()
        {
            InitializeComponent();

            this.Hide();

            LogInForm logInForm = new LogInForm();
            DialogResult logInResult = logInForm.ShowDialog();
            if (logInResult == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Load += HeThongForm_Load;
            }
        }

        private void HeThongForm_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInForm = new LogInForm();
            DialogResult logInResult = logInForm.ShowDialog();
            if (logInResult == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienForm sinhVienForm = new SinhVienForm();
            sinhVienForm.ShowDialog();
        }

        private void lớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopTCForm lopTCForm = new LopTCForm();
            lopTCForm.ShowDialog();
        }

        private void tổngHợpHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinHocPhiForm thonTinHocPhiForm = new ThongTinHocPhiForm();
            thonTinHocPhiForm.ShowDialog();
        }
    }
}
