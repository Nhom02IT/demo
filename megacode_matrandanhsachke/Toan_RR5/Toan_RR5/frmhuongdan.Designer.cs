namespace Toan_RR5
{
    partial class frmhuongdan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhuongdan));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dừngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiếpTụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnnhapmatran = new System.Windows.Forms.Button();
            this.btnDuyetMaTran = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Flash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.btndung = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dừngToolStripMenuItem,
            this.tiếpTụcToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // dừngToolStripMenuItem
            // 
            this.dừngToolStripMenuItem.Name = "dừngToolStripMenuItem";
            this.dừngToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dừngToolStripMenuItem.Text = "Dừng";
            this.dừngToolStripMenuItem.Click += new System.EventHandler(this.dừngToolStripMenuItem_Click);
            // 
            // tiếpTụcToolStripMenuItem
            // 
            this.tiếpTụcToolStripMenuItem.Name = "tiếpTụcToolStripMenuItem";
            this.tiếpTụcToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.tiếpTụcToolStripMenuItem.Text = "Tiếp tục";
            this.tiếpTụcToolStripMenuItem.Click += new System.EventHandler(this.tiếpTụcToolStripMenuItem_Click);
            // 
            // btnnhapmatran
            // 
            this.btnnhapmatran.BackColor = System.Drawing.Color.Transparent;
            this.btnnhapmatran.Location = new System.Drawing.Point(144, 511);
            this.btnnhapmatran.Name = "btnnhapmatran";
            this.btnnhapmatran.Size = new System.Drawing.Size(84, 37);
            this.btnnhapmatran.TabIndex = 0;
            this.btnnhapmatran.Text = "Nhập Ma Trận";
            this.btnnhapmatran.UseVisualStyleBackColor = false;
            this.btnnhapmatran.Click += new System.EventHandler(this.btnnhapmatran_Click);
            // 
            // btnDuyetMaTran
            // 
            this.btnDuyetMaTran.BackColor = System.Drawing.Color.Transparent;
            this.btnDuyetMaTran.Location = new System.Drawing.Point(234, 511);
            this.btnDuyetMaTran.Name = "btnDuyetMaTran";
            this.btnDuyetMaTran.Size = new System.Drawing.Size(84, 37);
            this.btnDuyetMaTran.TabIndex = 0;
            this.btnDuyetMaTran.Text = "Duyệt Ma Trận";
            this.btnDuyetMaTran.UseVisualStyleBackColor = false;
            this.btnDuyetMaTran.Click += new System.EventHandler(this.btnDuyetMaTran_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Video Hướng Dẫn";
            // 
            // Flash
            // 
            this.Flash.ContextMenuStrip = this.contextMenuStrip1;
            this.Flash.Enabled = true;
            this.Flash.Location = new System.Drawing.Point(37, 47);
            this.Flash.Name = "Flash";
            this.Flash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Flash.OcxState")));
            this.Flash.Size = new System.Drawing.Size(735, 386);
            this.Flash.TabIndex = 0;
            // 
            // btndung
            // 
            this.btndung.BackColor = System.Drawing.Color.Transparent;
            this.btndung.Location = new System.Drawing.Point(468, 511);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(84, 37);
            this.btndung.TabIndex = 0;
            this.btndung.Text = "Dừng";
            this.btndung.UseVisualStyleBackColor = false;
            this.btndung.Click += new System.EventHandler(this.btndung_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(558, 511);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 37);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Toan_RR5.Properties.Resources.TIVI1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmhuongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 551);
            this.Controls.Add(this.Flash);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDuyetMaTran);
            this.Controls.Add(this.btnnhapmatran);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhuongdan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmhuongdan_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDuyetMaTran;
        private System.Windows.Forms.Button btnnhapmatran;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dừngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiếpTụcToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private AxShockwaveFlashObjects.AxShockwaveFlash Flash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}