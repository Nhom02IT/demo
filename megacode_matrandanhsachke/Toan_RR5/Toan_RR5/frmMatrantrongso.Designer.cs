namespace Toan_RR5
{
    partial class frmMatrantrongso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatrantrongso));
            this.panelinmatran = new System.Windows.Forms.Panel();
            this.btnkhoitao = new System.Windows.Forms.Button();
            this.txtkichthuocmatran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstdske = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chktungbuoc = new System.Windows.Forms.CheckBox();
            this.Trb_Toc_do = new System.Windows.Forms.TrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnDuyetim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnmt_dske = new System.Windows.Forms.Button();
            this.btnnhapxong = new System.Windows.Forms.Button();
            this.btnngaunhien = new System.Windows.Forms.Button();
            this.Flashxuatquan = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.Flashchinh = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.Flasnoi = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Toc_do)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flashxuatquan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flashchinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flasnoi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelinmatran
            // 
            this.panelinmatran.AllowDrop = true;
            this.panelinmatran.AutoScroll = true;
            this.panelinmatran.BackColor = System.Drawing.Color.Transparent;
            this.panelinmatran.Location = new System.Drawing.Point(351, 108);
            this.panelinmatran.Name = "panelinmatran";
            this.panelinmatran.Size = new System.Drawing.Size(414, 308);
            this.panelinmatran.TabIndex = 0;
            this.panelinmatran.Paint += new System.Windows.Forms.PaintEventHandler(this.panelinmatran_Paint);
            // 
            // btnkhoitao
            // 
            this.btnkhoitao.Location = new System.Drawing.Point(676, 433);
            this.btnkhoitao.Name = "btnkhoitao";
            this.btnkhoitao.Size = new System.Drawing.Size(86, 30);
            this.btnkhoitao.TabIndex = 1;
            this.btnkhoitao.Text = "Khởi tạo";
            this.btnkhoitao.UseVisualStyleBackColor = true;
            this.btnkhoitao.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkichthuocmatran
            // 
            this.txtkichthuocmatran.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkichthuocmatran.Location = new System.Drawing.Point(590, 440);
            this.txtkichthuocmatran.Multiline = true;
            this.txtkichthuocmatran.Name = "txtkichthuocmatran";
            this.txtkichthuocmatran.Size = new System.Drawing.Size(75, 20);
            this.txtkichthuocmatran.TabIndex = 3;
            this.txtkichthuocmatran.Text = "6";
            this.txtkichthuocmatran.TextChanged += new System.EventHandler(this.txtkichthuocmatran_TextChanged);
            this.txtkichthuocmatran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkichthuocmatran_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(434, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kích thước ma trận (vuông):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(85, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điểm cuối";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(149, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trọng số";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstdske
            // 
            this.lstdske.AllowDrop = true;
            this.lstdske.AutoScroll = true;
            this.lstdske.BackColor = System.Drawing.Color.Transparent;
            this.lstdske.Location = new System.Drawing.Point(25, 109);
            this.lstdske.Name = "lstdske";
            this.lstdske.Size = new System.Drawing.Size(187, 308);
            this.lstdske.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chktungbuoc
            // 
            this.chktungbuoc.AutoSize = true;
            this.chktungbuoc.BackColor = System.Drawing.Color.Transparent;
            this.chktungbuoc.Enabled = false;
            this.chktungbuoc.Location = new System.Drawing.Point(235, 231);
            this.chktungbuoc.Name = "chktungbuoc";
            this.chktungbuoc.Size = new System.Drawing.Size(78, 17);
            this.chktungbuoc.TabIndex = 10;
            this.chktungbuoc.Text = "Từng bước";
            this.chktungbuoc.UseVisualStyleBackColor = false;
            this.chktungbuoc.CheckedChanged += new System.EventHandler(this.chktungbuoc_CheckedChanged);
            // 
            // Trb_Toc_do
            // 
            this.Trb_Toc_do.AutoSize = false;
            this.Trb_Toc_do.BackColor = System.Drawing.Color.White;
            this.Trb_Toc_do.Location = new System.Drawing.Point(467, 473);
            this.Trb_Toc_do.Maximum = 9;
            this.Trb_Toc_do.Name = "Trb_Toc_do";
            this.Trb_Toc_do.Size = new System.Drawing.Size(133, 25);
            this.Trb_Toc_do.TabIndex = 46;
            this.Trb_Toc_do.TickFrequency = 2;
            this.Trb_Toc_do.Value = 5;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = global::Toan_RR5.Properties.Resources.boot1;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 467);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.Image = global::Toan_RR5.Properties.Resources.login;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(150, 22);
            this.toolStripButton1.Text = "Thông tin tác giả";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(150, 22);
            this.toolStripButton2.Text = "Hướng dẫn";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton3.Image = global::Toan_RR5.Properties.Resources.Deleket_Sleek_Xp_Basic_Close_2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(150, 22);
            this.toolStripButton3.Text = "Thoát";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 50;
            // 
            // btnDuyetim
            // 
            this.btnDuyetim.Enabled = false;
            this.btnDuyetim.Image = global::Toan_RR5.Properties.Resources.Gakuseisean_Aire_Search;
            this.btnDuyetim.Location = new System.Drawing.Point(236, 313);
            this.btnDuyetim.Name = "btnDuyetim";
            this.btnDuyetim.Size = new System.Drawing.Size(90, 45);
            this.btnDuyetim.TabIndex = 7;
            this.btnDuyetim.Text = "Duyệt tìm";
            this.btnDuyetim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuyetim.UseVisualStyleBackColor = true;
            this.btnDuyetim.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Image = global::Toan_RR5.Properties.Resources.Deleket_Button_Button_Delete;
            this.btnxoa.Location = new System.Drawing.Point(236, 367);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 45);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnmt_dske
            // 
            this.btnmt_dske.Enabled = false;
            this.btnmt_dske.Image = global::Toan_RR5.Properties.Resources.Dapino_Summer_Blue_Holiday_Diary_Book;
            this.btnmt_dske.Location = new System.Drawing.Point(236, 257);
            this.btnmt_dske.Name = "btnmt_dske";
            this.btnmt_dske.Size = new System.Drawing.Size(90, 45);
            this.btnmt_dske.TabIndex = 1;
            this.btnmt_dske.Text = "DS Kề";
            this.btnmt_dske.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmt_dske.UseVisualStyleBackColor = true;
            this.btnmt_dske.Click += new System.EventHandler(this.btnmt_dske_Click);
            // 
            // btnnhapxong
            // 
            this.btnnhapxong.Enabled = false;
            this.btnnhapxong.Image = global::Toan_RR5.Properties.Resources.Deleket_Sleek_Xp_Basic_Ok;
            this.btnnhapxong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhapxong.Location = new System.Drawing.Point(236, 121);
            this.btnnhapxong.Name = "btnnhapxong";
            this.btnnhapxong.Size = new System.Drawing.Size(90, 45);
            this.btnnhapxong.TabIndex = 1;
            this.btnnhapxong.Text = "Nhập xong";
            this.btnnhapxong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnhapxong.UseVisualStyleBackColor = true;
            this.btnnhapxong.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnngaunhien
            // 
            this.btnngaunhien.Enabled = false;
            this.btnngaunhien.Image = global::Toan_RR5.Properties.Resources.Visualpharm_Ios7v2_Media_Controls_Shuffle;
            this.btnngaunhien.Location = new System.Drawing.Point(236, 176);
            this.btnngaunhien.Name = "btnngaunhien";
            this.btnngaunhien.Size = new System.Drawing.Size(90, 45);
            this.btnngaunhien.TabIndex = 1;
            this.btnngaunhien.Text = "Ngẫu nhiên";
            this.btnngaunhien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnngaunhien.UseVisualStyleBackColor = true;
            this.btnngaunhien.Click += new System.EventHandler(this.btnngaunhien_Click);
            // 
            // Flashxuatquan
            // 
            this.Flashxuatquan.Enabled = true;
            this.Flashxuatquan.Location = new System.Drawing.Point(806, 143);
            this.Flashxuatquan.Name = "Flashxuatquan";
            this.Flashxuatquan.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Flashxuatquan.OcxState")));
            this.Flashxuatquan.Size = new System.Drawing.Size(225, 255);
            this.Flashxuatquan.TabIndex = 48;
            // 
            // Flashchinh
            // 
            this.Flashchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flashchinh.Enabled = true;
            this.Flashchinh.Location = new System.Drawing.Point(0, 0);
            this.Flashchinh.Name = "Flashchinh";
            this.Flashchinh.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Flashchinh.OcxState")));
            this.Flashchinh.Size = new System.Drawing.Size(1063, 492);
            this.Flashchinh.TabIndex = 49;
            // 
            // Flasnoi
            // 
            this.Flasnoi.Enabled = true;
            this.Flasnoi.Location = new System.Drawing.Point(1021, 454);
            this.Flasnoi.Name = "Flasnoi";
            this.Flasnoi.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Flasnoi.OcxState")));
            this.Flasnoi.Size = new System.Drawing.Size(192, 192);
            this.Flasnoi.TabIndex = 50;
            // 
            // frmMatrantrongso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Toan_RR5.Properties.Resources.Giaodien_chinh1;
            this.ClientSize = new System.Drawing.Size(1063, 492);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnkhoitao);
            this.Controls.Add(this.txtkichthuocmatran);
            this.Controls.Add(this.Trb_Toc_do);
            this.Controls.Add(this.chktungbuoc);
            this.Controls.Add(this.btnDuyetim);
            this.Controls.Add(this.lstdske);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnmt_dske);
            this.Controls.Add(this.btnnhapxong);
            this.Controls.Add(this.btnngaunhien);
            this.Controls.Add(this.panelinmatran);
            this.Controls.Add(this.Flashxuatquan);
            this.Controls.Add(this.Flashchinh);
            this.Controls.Add(this.Flasnoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMatrantrongso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma Trận Trọng Số - Danh sách kề";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMatrantrongso_FormClosing);
            this.Load += new System.EventHandler(this.frmMatrantrongso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Toc_do)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flashxuatquan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flashchinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flasnoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelinmatran;
        private System.Windows.Forms.Button btnngaunhien;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnkhoitao;
        private System.Windows.Forms.TextBox txtkichthuocmatran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmt_dske;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnnhapxong;
        private System.Windows.Forms.Button btnDuyetim;
        private System.Windows.Forms.Panel lstdske;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chktungbuoc;
        private System.Windows.Forms.TrackBar Trb_Toc_do;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer timer3;
        private AxShockwaveFlashObjects.AxShockwaveFlash Flashxuatquan;
        private AxShockwaveFlashObjects.AxShockwaveFlash Flashchinh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private AxShockwaveFlashObjects.AxShockwaveFlash Flasnoi;
    }
}

