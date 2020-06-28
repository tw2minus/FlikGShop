namespace BaiTapThucHanh_01
{
    partial class LopTCForm
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
            this.lblMaLopTC = new System.Windows.Forms.Label();
            this.tbMaLopTC = new System.Windows.Forms.TextBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.tbSoTinChi = new System.Windows.Forms.TextBox();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.tbHocKy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.dgvLopTC = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaLopTC
            // 
            this.lblMaLopTC.AutoSize = true;
            this.lblMaLopTC.Location = new System.Drawing.Point(66, 32);
            this.lblMaLopTC.Name = "lblMaLopTC";
            this.lblMaLopTC.Size = new System.Drawing.Size(95, 17);
            this.lblMaLopTC.TabIndex = 0;
            this.lblMaLopTC.Text = "Mã lớp tín chỉ:";
            // 
            // tbMaLopTC
            // 
            this.tbMaLopTC.Location = new System.Drawing.Point(189, 32);
            this.tbMaLopTC.Name = "tbMaLopTC";
            this.tbMaLopTC.Size = new System.Drawing.Size(255, 22);
            this.tbMaLopTC.TabIndex = 1;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(69, 76);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(66, 17);
            this.lblMonHoc.TabIndex = 2;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(189, 76);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(255, 24);
            this.cbbMonHoc.TabIndex = 3;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // tbSoTinChi
            // 
            this.tbSoTinChi.Enabled = false;
            this.tbSoTinChi.Location = new System.Drawing.Point(189, 126);
            this.tbSoTinChi.Name = "tbSoTinChi";
            this.tbSoTinChi.Size = new System.Drawing.Size(255, 22);
            this.tbSoTinChi.TabIndex = 5;
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(66, 126);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(70, 17);
            this.lblSoTinChi.TabIndex = 4;
            this.lblSoTinChi.Text = "Số tín chỉ:";
            // 
            // tbHocKy
            // 
            this.tbHocKy.Location = new System.Drawing.Point(189, 169);
            this.tbHocKy.Name = "tbHocKy";
            this.tbHocKy.Size = new System.Drawing.Size(255, 22);
            this.tbHocKy.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Học kỳ:";
            // 
            // tbNamHoc
            // 
            this.tbNamHoc.Location = new System.Drawing.Point(189, 213);
            this.tbNamHoc.Name = "tbNamHoc";
            this.tbNamHoc.Size = new System.Drawing.Size(255, 22);
            this.tbNamHoc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Năm học:";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(522, 44);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(86, 34);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(522, 96);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(86, 34);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(522, 152);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(86, 34);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(522, 270);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(86, 34);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dgvLopTC
            // 
            this.dgvLopTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopTC.Location = new System.Drawing.Point(37, 327);
            this.dgvLopTC.Name = "dgvLopTC";
            this.dgvLopTC.RowTemplate.Height = 24;
            this.dgvLopTC.Size = new System.Drawing.Size(839, 325);
            this.dgvLopTC.TabIndex = 14;
            this.dgvLopTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopTC_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(189, 276);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(255, 22);
            this.tbSearch.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tìm kiếm theo môn học:";
            // 
            // LopTCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 696);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLopTC);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbNamHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHocKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoTinChi);
            this.Controls.Add(this.lblSoTinChi);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.tbMaLopTC);
            this.Controls.Add(this.lblMaLopTC);
            this.Name = "LopTCForm";
            this.Text = "Quản lý Lớp tín chỉ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLopTC;
        private System.Windows.Forms.TextBox tbMaLopTC;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.TextBox tbSoTinChi;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.TextBox tbHocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dgvLopTC;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
    }
}