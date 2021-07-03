namespace QuanLyNhaSach_DoAn
{
    partial class FormTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewqlnv = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthoat = new System.Windows.Forms.ToolStripButton();
            this.lbltenuser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthemnv = new System.Windows.Forms.Button();
            this.lbltennv = new System.Windows.Forms.Label();
            this.btnsathai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnewmkxn = new System.Windows.Forms.TextBox();
            this.txtnewmk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.btndoimk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewqlnv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewqlnv
            // 
            this.dataGridViewqlnv.AllowUserToAddRows = false;
            this.dataGridViewqlnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewqlnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewqlnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dataGridViewqlnv.Location = new System.Drawing.Point(8, 26);
            this.dataGridViewqlnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewqlnv.Name = "dataGridViewqlnv";
            this.dataGridViewqlnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewqlnv.Size = new System.Drawing.Size(560, 326);
            this.dataGridViewqlnv.TabIndex = 2;
            this.dataGridViewqlnv.SelectionChanged += new System.EventHandler(this.dataGridViewqlnv_SelectionChanged);
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
            this.toolStrip1.Size = new System.Drawing.Size(1109, 33);
            this.toolStrip1.TabIndex = 5;
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
            this.btnthoat.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnthemnv);
            this.groupBox1.Controls.Add(this.lbltennv);
            this.groupBox1.Controls.Add(this.btnsathai);
            this.groupBox1.Controls.Add(this.dataGridViewqlnv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(37, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(576, 410);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nhân Viên";
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(440, 352);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(128, 58);
            this.btnluu.TabIndex = 6;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthemnv
            // 
            this.btnthemnv.Image = ((System.Drawing.Image)(resources.GetObject("btnthemnv.Image")));
            this.btnthemnv.Location = new System.Drawing.Point(207, 359);
            this.btnthemnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(73, 43);
            this.btnthemnv.TabIndex = 5;
            this.btnthemnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthemnv.UseVisualStyleBackColor = true;
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Location = new System.Drawing.Point(24, 363);
            this.lbltennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(59, 20);
            this.lbltennv.TabIndex = 4;
            this.lbltennv.Text = "label1";
            // 
            // btnsathai
            // 
            this.btnsathai.Image = ((System.Drawing.Image)(resources.GetObject("btnsathai.Image")));
            this.btnsathai.Location = new System.Drawing.Point(304, 359);
            this.btnsathai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsathai.Name = "btnsathai";
            this.btnsathai.Size = new System.Drawing.Size(72, 43);
            this.btnsathai.TabIndex = 3;
            this.btnsathai.UseVisualStyleBackColor = true;
            this.btnsathai.Click += new System.EventHandler(this.btnsathai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnewmkxn);
            this.groupBox2.Controls.Add(this.txtnewmk);
            this.groupBox2.Controls.Add(this.txtmk);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.btndoimk);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(656, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(428, 377);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảo mật";
            // 
            // txtnewmkxn
            // 
            this.txtnewmkxn.Location = new System.Drawing.Point(197, 212);
            this.txtnewmkxn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewmkxn.Name = "txtnewmkxn";
            this.txtnewmkxn.PasswordChar = '*';
            this.txtnewmkxn.Size = new System.Drawing.Size(196, 29);
            this.txtnewmkxn.TabIndex = 8;
            // 
            // txtnewmk
            // 
            this.txtnewmk.Location = new System.Drawing.Point(197, 160);
            this.txtnewmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewmk.Name = "txtnewmk";
            this.txtnewmk.PasswordChar = '*';
            this.txtnewmk.Size = new System.Drawing.Size(196, 29);
            this.txtnewmk.TabIndex = 7;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(197, 105);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(196, 29);
            this.txtmk.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(197, 50);
            this.txtten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(196, 29);
            this.txtten.TabIndex = 5;
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(29, 311);
            this.btndoimk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(365, 58);
            this.btndoimk.TabIndex = 4;
            this.btndoimk.Text = "Đổi mật khẩu";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(25, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tentk";
            this.Column1.HeaderText = "Tên TK";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "matkhau";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hoten";
            this.Column3.HeaderText = "Họ và tên";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "chucvu";
            this.Column6.HeaderText = "Chức vụ";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gioitinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaysinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQLyNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormQLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewqlnv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewqlnv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthoat;
        private System.Windows.Forms.ToolStripLabel lbltenuser;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Button btnsathai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnewmkxn;
        private System.Windows.Forms.TextBox txtnewmk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthemnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}