namespace QuanLyNhaSach_DoAn
{
    partial class FormQuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyHoaDon));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.lbltenuser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.lblhdchon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.datadshd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltonghd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datachitiet = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadshd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datachitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthoat,
            this.lbltenuser,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1088, 33);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthoat
            // 
            this.btnthoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnthoat.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(105, 30);
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbltenuser
            // 
            this.lbltenuser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbltenuser.ForeColor = System.Drawing.Color.Maroon;
            this.lbltenuser.Name = "lbltenuser";
            this.lbltenuser.Size = new System.Drawing.Size(30, 30);
            this.lbltenuser.Text = "tên";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(66, 30);
            this.toolStripLabel2.Text = "Xin chào";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.lblhdchon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.datadshd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(17, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(583, 418);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // btnxoa
            // 
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(383, 48);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 46);
            this.btnxoa.TabIndex = 29;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // lblhdchon
            // 
            this.lblhdchon.AutoSize = true;
            this.lblhdchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhdchon.ForeColor = System.Drawing.Color.Crimson;
            this.lblhdchon.Location = new System.Drawing.Point(157, 62);
            this.lblhdchon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhdchon.Name = "lblhdchon";
            this.lblhdchon.Size = new System.Drawing.Size(85, 29);
            this.lblhdchon.TabIndex = 28;
            this.lblhdchon.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "HD đang chọn";
            // 
            // btnsearch
            // 
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(255, 26);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(45, 28);
            this.btnsearch.TabIndex = 26;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(8, 26);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(224, 26);
            this.txtsearch.TabIndex = 25;
            // 
            // datadshd
            // 
            this.datadshd.AllowUserToAddRows = false;
            this.datadshd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datadshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadshd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.datadshd.Location = new System.Drawing.Point(0, 97);
            this.datadshd.Margin = new System.Windows.Forms.Padding(4);
            this.datadshd.Name = "datadshd";
            this.datadshd.Size = new System.Drawing.Size(560, 314);
            this.datadshd.TabIndex = 0;
            this.datadshd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadshd_CellContentClick);
            this.datadshd.SelectionChanged += new System.EventHandler(this.datadshd_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahd";
            this.Column1.HeaderText = "Số HD";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nguoiban";
            this.Column2.HeaderText = "Người Bán";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "khachmua";
            this.Column3.HeaderText = "Sđt khách mua";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaymua";
            this.Column4.HeaderText = "Ngày Bán";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tongtien";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbldoanhthu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbltonghd);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBox2.Location = new System.Drawing.Point(608, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(464, 417);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng kết";
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.AutoSize = true;
            this.lbldoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoanhthu.ForeColor = System.Drawing.Color.Crimson;
            this.lbldoanhthu.Location = new System.Drawing.Point(163, 148);
            this.lbldoanhthu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(145, 52);
            this.lbldoanhthu.TabIndex = 4;
            this.lbldoanhthu.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doanh thu";
            // 
            // lbltonghd
            // 
            this.lbltonghd.AutoSize = true;
            this.lbltonghd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltonghd.ForeColor = System.Drawing.Color.Crimson;
            this.lbltonghd.Location = new System.Drawing.Point(193, 63);
            this.lbltonghd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltonghd.Name = "lbltonghd";
            this.lbltonghd.Size = new System.Drawing.Size(115, 39);
            this.lbltonghd.TabIndex = 2;
            this.lbltonghd.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 247);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số HD";
            // 
            // datachitiet
            // 
            this.datachitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datachitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.datachitiet.Location = new System.Drawing.Point(337, 512);
            this.datachitiet.Name = "datachitiet";
            this.datachitiet.RowTemplate.Height = 24;
            this.datachitiet.Size = new System.Drawing.Size(240, 150);
            this.datachitiet.TabIndex = 7;
            this.datachitiet.SelectionChanged += new System.EventHandler(this.datachitiet_SelectionChanged);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mahd";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "masach";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "soluong";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "thanhtien";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datachitiet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanLyHoaDon";
            this.Text = "Quản Lý Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuanLyHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadshd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datachitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.ToolStripLabel lbltenuser;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datadshd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbldoanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltonghd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label lblhdchon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView datachitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label4;
    }
}