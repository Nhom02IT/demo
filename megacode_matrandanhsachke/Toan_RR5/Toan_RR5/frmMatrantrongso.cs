using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace Toan_RR5
{
    public partial class frmMatrantrongso : Form
    {
        public frmMatrantrongso()
        {
            Thread t = new Thread(new ThreadStart(Chao));
            t.Start();
            Thread.Sleep(4000);

            InitializeComponent();
            t.Abort();
        }
        private void Chao()
        {
            Application.Run(new frmkhoidong());
        }
        
        int i, j, m, N;
        int[,] C = new int[100, 100];
        TextBox[] tb = new TextBox[100];
        int oo = 32000;
        long k = 1;
        int[] tien = new int[100000];
        int b = 0;
        TextBox[] lblcdiemdau = new TextBox[1000];
        Label[] lbl2 = new Label[1000];
        int kich_thuoc = 35;
        
        //Hàm ngủ
        #region Thời Gian
        public void SleepP(int milisecond)
        {
            int i;
            for (i = 0; i < milisecond; i++)
            {
                Application.DoEvents();
                Thread.Sleep(5);
            }
            Application.DoEvents();
        }
        //Hàm Trễ
        public void Tre(int milisecond)
        {
            //Nếu tốc độ max thì ko sleep
            if (Trb_Toc_do.Value == Trb_Toc_do.Maximum)
            {
                Application.DoEvents();
                return;
            }

            SleepP(milisecond);
        }
        #endregion
        #region Diemdau- diemcuoi- trong so
        void indiemdau(int i)
        {
            lblcdiemdau[i] = new TextBox();
            lblcdiemdau[i].Name = "diemdau" + i.ToString();
            lblcdiemdau[i].Text = i.ToString();
            lblcdiemdau[i].BackColor = Color.Red;
            lblcdiemdau[i].ForeColor = Color.White;
            lblcdiemdau[i].Cursor = Cursors.Hand;
            lblcdiemdau[i].Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            lblcdiemdau[i].ReadOnly = true;
            //lblcdiemdau[i].Location = new Point(5, 10 + b);
            //lblcdiemcuoi[i].Location = new Point(5, 10 + b);
            lblcdiemdau[i].Size = new Size(kich_thuoc, kich_thuoc);
            lblcdiemdau[i].TextAlign = HorizontalAlignment.Center;
            lblcdiemdau[i].Click += new EventHandler(SukienTienpro_Click); // truyền sự kiện cho lable
            in1.Controls.Add(lblcdiemdau[i]);
            in1.Location = new Point(5, 10);
            in1.Size = new Size(55, kichthuocpanel * kich_thuoc);
            lstdske.Controls.Add(in1);
           
        }

        TextBox[] lblcdiemcuoi = new TextBox[1000];
        void indiemcuoi(int i)
        {
            lblcdiemcuoi[i] = new TextBox();
            lblcdiemcuoi[i].Name = "diemcuoi" + i.ToString();
            lblcdiemcuoi[i].Text = i.ToString();
            lblcdiemcuoi[i].BackColor = Color.Red;
            lblcdiemcuoi[i].ForeColor = Color.White;
            lblcdiemcuoi[i].ReadOnly = true;
            lblcdiemcuoi[i].Cursor = Cursors.Hand;
            lblcdiemcuoi[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            //lblcdiemcuoi[i].Location = new Point(60, 10 + b);
            //lblcdiemcuoi[i].Location = new Point(5, 10 + b);
            lblcdiemcuoi[i].Size = new Size(kich_thuoc, kich_thuoc);
            lblcdiemcuoi[i].TextAlign = HorizontalAlignment.Center;
            lblcdiemcuoi[i].Click += new EventHandler(SukienTienpro_Click); // truyền sự kiện cho lable
            in2.Controls.Add(lblcdiemcuoi[i]);
            in2.Location = new Point(60, 10);
            in2.Size = new Size(kich_thuoc + 3, kichthuocpanel * kich_thuoc);
            lstdske.Controls.Add(in2);
           
        }

        TextBox[] lbltrongso = new TextBox[1000];
        void introngso(long i)
        {
            lbltrongso[i] = new TextBox();
            lbltrongso[i].Name = "trongso" + i.ToString();
            lbltrongso[i].Text = i.ToString();
            lbltrongso[i].BackColor = Color.Red;
            lbltrongso[i].ForeColor = Color.White;
            lbltrongso[i].ReadOnly = true;
            lbltrongso[i].Cursor = Cursors.Hand;
            lbltrongso[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            //lbltrongso[i].Location = new Point(115, 10 + b);
            //lblcdiemcuoi[i].Location = new Point(5, 10 + b);
            lbltrongso[i].Size = new Size(kich_thuoc, kich_thuoc);
            lbltrongso[i].TextAlign = HorizontalAlignment.Center;
            lbltrongso[i].Click += new EventHandler(SukienTienpro_Click); // truyền sự kiện cho lable
            in3.Controls.Add(lbltrongso[i]);
            in3.Location = new Point(115, 10);
            in3.Size = new Size(kich_thuoc + 3, kichthuocpanel*kich_thuoc);
            lstdske.Controls.Add(in3);
        }
        #endregion
        #region MATRAN
        void Matran(int n)
        {
            long t=1;
            pnmatranduocxuli.Controls.Clear();
            panelinmatran.Controls.Add(pnmatranduocxuli);
            pnmatranduocxuli.Location = new Point(25, 25);
            pnmatranduocxuli.Size = new Size(5 + N * 45, 5 + N * 45);
            pnmatranduocxuli.BackColor = Color.Transparent;//chiều dài mới, rộng mới của panel3 
            for (i = 0; i <= N; i++)
                for (j = 0; j <= N; j++)
                {
                    if (i == 0 || j == 0)   //nếu là dòng hay cột đầu tiên thì dùng nó để đánh số thứ tự
                    {
                        Label lb1 = new Label();
                        panelinmatran.Controls.Add(lb1);
                        lb1.Location = new Point(5 + j * 44, 2 + i * 44);
                        lb1.Size = new Size(25, 25);
                        lb1.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
                        if (i == 0 && j == 0) lb1.Text = "";
                        else if (i == 0)
                        {
                            lb1.Text = j.ToString();
                        }
                        else lb1.Text = i.ToString();
                    }
                }
            //Tạo ra các textbox Ma Tran
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                {
                    //if (i == j)
                    //{
                    //    tb[t] = new TextBox();
                    //    tb[t].Location = new Point(5 + (j - 1) * 25, 5 + (i - 1) * 25);
                    //    tb[t].Size = new Size(23, 25);
                    //    tb[t].Text = "0";
                    //    //tb[t].ReadOnly = true;
                    //    tb[t].TextAlign = HorizontalAlignment.Center;
                    //    tb[t].KeyPress += new KeyPressEventHandler(txtkichthuocmatran_KeyPress);
                    //    pnmatranduocxuli.Controls.Add(tb[t]);
                    //    t++;
                    //}
                     tb[t] = new TextBox();
                    tb[t].Location = new Point(10 + (j - 1) * 46, 5 + (i - 1) * 45);
                    tb[t].Multiline = true;
                    tb[t].Size = new Size(35, 35);
                    tb[t].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    tb[t].TextAlign = HorizontalAlignment.Center;
                    tb[t].KeyPress += new KeyPressEventHandler(txtkichthuocmatran_KeyPress);
                    pnmatranduocxuli.Controls.Add(tb[t]);
                    //tb.Text = c[i, j].ToString();
                    t++;
                }
        }

        void frmMatrantrongso_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        //ngau nhien
        void MaTranTrongSoNgauNhien()
        {
            Random ran = new Random();

            for (i = 1; i <= N; i++)
                for (j = i; j <= N; j++)
                {
                    C[i, j] = ran.Next(1,99);
                    if ((i != j) && (C[i, j] == 0)) //khong co duong di thi la vo cung
                        C[i, j] = oo;
                    //chu y:oo ta khai bao va khoi tao la ten bien nen muon viet ra oo thi phai cho vao trong xau

                    if (i == j)  //neu tren duong cheo chinh thi trong so la o
                        C[i, j] = 0;
                    //gán cho bên đối xứng
                    C[j, i] = C[i, j];
                }
        }
        //Kiem Tra Ma Tran
        void KiemTraMaTran()
        {
            int t = 1;
            for (i = 1; i <= N; i++)
                for (j = i; j <= N; j++)
                {
                    C[i, j] = tien[t];
                    t++;
                }
        }
        //hien thi
        Panel pnmatranduocxuli = new Panel();
        FlowLayoutPanel in1 = new FlowLayoutPanel();
        FlowLayoutPanel in2 = new FlowLayoutPanel();
        FlowLayoutPanel in3 = new FlowLayoutPanel();
        public void hienthi()
        {
            int tchu = 1;
            pnmatranduocxuli.Controls.Clear();
            panelinmatran.Controls.Add(pnmatranduocxuli);
            pnmatranduocxuli.Location = new Point(25, 25);
            pnmatranduocxuli.Size = new Size(5 + N * 45, 5 + N * 45);
            pnmatranduocxuli.BackColor = Color.Transparent;//chiều dài mới, rộng mới của panel3 
            int i, j;
            for (i = 0; i <= N; i++)
                for (j = 0; j <= N; j++)
                {
                    if (i == 0 || j == 0)   //nếu là dòng hay cột đầu tiên thì dùng nó để đánh số thứ tự
                    {
                        lbl2[tchu] = new Label();
                        panelinmatran.Controls.Add(lbl2[tchu]);
                        lbl2[tchu].Location = new Point(5 + j * 44, 2 + i * 44);
                        lbl2[tchu].Size = new Size(25, 25);
                        lbl2[tchu].Font = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
                        if (i == 0 && j == 0) 
                            lbl2[tchu].Text = "";
                        else if (i == 0)
                        {
                            lbl2[tchu].Text = j.ToString();
                        }
                        else lbl2[tchu].Text = i.ToString();
                    }
                    tchu++;
                }
            long t = 1;
            //Tạo ra các textbox và hiển thị A[i,j] lên đó
            for (i = 1; i <= N; i++)
                for (j = 1; j <= N; j++)
                {
                    tb[t] = new TextBox();
                    pnmatranduocxuli.Controls.Add(tb[t]);
                    tb[t].Location = new Point(5 + (j - 1) * 45, 5 + (i - 1) * 45);
                    tb[t].Multiline = true;
                    tb[t].Size = new Size(35, 35);
                    tb[t].Font =new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    tb[t].ReadOnly = true;
                    tb[t].TextAlign = HorizontalAlignment.Center;
                    tb[t].Text = C[i, j].ToString();
                    t++;
                }
            //Duyet va in vao mang
        }
        int kichthuocpanel = 1;

        
        void MT_DSK()
        {
            int u = 1;
            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    if(i>=j)
                        u++;
                    else
                    {
                        kichthuocpanel++;
                        indiemdau(i);
                        indiemcuoi(j);
                        introngso(tien[u]);
                        b += 25;
                        u++;
                        
                    }
                   
                }
            }
           
        }
        #endregion
        #region Các nút BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            kichthuocpanel = 0;
            N = Convert.ToInt32(txtkichthuocmatran.Text);
            panelinmatran.Controls.Clear();
            Matran(Convert.ToInt32(txtkichthuocmatran.Text));
            btnnhapxong.Enabled = true;
            //btnthoat.Enabled = true;
            btnngaunhien.Enabled = true;
            timer1.Stop();
            in1.Controls.Clear();
            in2.Controls.Clear();
            in3.Controls.Clear();
            in1.Size = new Size(0, 0);
            in2.Size = new Size(0, 0);
            in3.Size = new Size(0, 0);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            panelinmatran.Controls.Clear();
            in1.Controls.Clear();
            in2.Controls.Clear();
            in3.Controls.Clear();
            in1.Size = new Size(0, 0);
            in2.Size = new Size(0, 0);
            in3.Size = new Size(0, 0);
        }

        private void btnngaunhien_Click(object sender, EventArgs e)
        {
            //tien = new int [1000];
            
            N = Convert.ToInt32(txtkichthuocmatran.Text);
            panelinmatran.Controls.Clear();
            MaTranTrongSoNgauNhien();
            hienthi();
            btnmt_dske.Enabled = true;
            chktungbuoc.Enabled = true;
            btnnhapxong.Enabled = false;
            btnngaunhien.Enabled = false;
            
        }
        int uu = 1;
        void Chaytungbuoc()
        {
            uu = 1;
            for (i = 1; i <= N; i++)
                for (j = 1; j <= N; j++)
                {
                   
                    if (i >= j)
                    {
                        if (i == j)
                        {
                            tb[uu].BackColor = Color.Black;
                            tb[uu].ForeColor = Color.White;
                        }
                        //else
                        //    tb[uu].BackColor = Color.Red;
                        uu++;
                    }
                    else
                    {

                        tb[uu].BackColor = Color.Blue;
                        Tre(100);
                        kichthuocpanel++;
                        vitridacbiet = uu;
                        timer2.Enabled = true;
                        Tre(100);
                        indiemdau(i);
                        Tre(30);
                        indiemcuoi(j);
                        Tre(30);
                        introngso(tien[uu]);
                        Tre(30);
                        timer2.Stop();
                        tb[vitridacbiet].BackColor = Color.DeepSkyBlue;
                        b += 25;
                        uu++;
                        //kichthuocpanel++;
                    }
                    
                }
        }
        private void btnmt_dske_Click(object sender, EventArgs e)
        {
           // Flashxuatquan.Playing = true;
            
            b = 0;
            k = 1;
            btnDuyetim.Enabled = false;
            btnxoa.Enabled = false;
            //btnthoat.Enabled = false;
            in1.Controls.Clear();
            in2.Controls.Clear();
            in3.Controls.Clear();
            in1.Size = new Size(0, 0);
            in2.Size = new Size(0, 0);
            in3.Size = new Size(0, 0);
            foreach (TextBox item in pnmatranduocxuli.Controls)//Duyệt từ đầu đến cuối các ô textbox
            {
                tien[k] = Convert.ToInt32(item.Text);//Số nguyên o dấu chuyển sang "chữ" số nguyên ko dấu, lưu vào mảng a[k]
                k++;
            }

            if (chktungbuoc.Checked)
            {
                
                Chaytungbuoc();
                btnmt_dske.Enabled = false;
                
            }
            else
            {
                lstdske.Controls.Clear();
                MT_DSK();
                btnmt_dske.Enabled = false;
            }
            btnDuyetim.Enabled = true;
            btnxoa.Enabled = true;
            MessageBox.Show("Đã chuyển xong!");
           // Flashxuatquan.Playing = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TextBox item in pnmatranduocxuli.Controls)
                {
                    tien[k] = Convert.ToInt32(item.Text);//Số nguyên o dấu chuyển sang "chữ" số nguyên ko dấu, lưu vào mảng a[k]
                    k++;
                    item.ReadOnly = true;

                }
                KiemTraMaTran();
                btnmt_dske.Enabled = true;
                btnngaunhien.Enabled = false;
                //btnthoat.Enabled = true;
                btnxoa.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn nhập đầy đủ vào ma trận mới được chứ");
            }
           
        }

        private void txtkichthuocmatran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        // chóp màu bên ma trận
        
        int ai, bi, ci;
        //int[] Ai, Bi, Ci = new int[10000];
        int dem = 0;
        void chopchop()
        {
           // int tut1=1,tut2=1,tut3=1;
            ai = 0; bi = 0; ci = 0;
            //diemdau
           
            foreach (TextBox item in in1.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    ai = Convert.ToInt32(item.Text);
                    //Ai[tut1] = ai;
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Black;
                    
                }
            }
            //diemcuoi
            foreach (TextBox item in in2.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    bi = Convert.ToInt32(item.Text);
                    //Bi[tut2] = bi;
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Black;
                    
                }
            }
            //trongso
            foreach (TextBox item in in3.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    ci = Convert.ToInt32(item.Text);
                    item.BackColor = Color.Yellow;
                    item.ForeColor = Color.Black;
                    
                }
            }
            if (dem > 2)
                btnDuyetim.Enabled = true;
            
            // txtgiatri.Text = ai.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                chopchop();
                timer1.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn chọn phần tử bên Danh Sách Cạnh kìa!", "Amen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           

        }
        #endregion
        private void SukienTienpro_Click(object sender, EventArgs e)
        {
            
            TextBox lbl = (TextBox)sender;
            if (lbl.BackColor == Color.Red)
                lbl.BackColor = Color.Blue;
            else if (lbl.BackColor == Color.Blue)
                lbl.BackColor = Color.Red;
            else
                MessageBox.Show("Điểm " + lbl.Text + " này đã có trên ma trận", "Chú ý");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int vitri, vitri2;
            if (ai == 0 || ci == 0 || bi == 0)
            {
                timer1.Stop();
                MessageBox.Show("Bạn chọn phần tử bên Danh Sách Cạnh kìa!", "Amen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                foreach (TextBox item in in1.Controls)
                {
                    if (item.BackColor == Color.Yellow)
                    {
                        //ai = Convert.ToInt32(item.Text);
                        //Ai[tut1] = ai;
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;

                    }
                }
                //diemcuoi
                foreach (TextBox item in in2.Controls)
                {
                    if (item.BackColor == Color.Yellow)
                    {
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;

                    }
                }
                //trongso
                foreach (TextBox item in in3.Controls)
                {
                    if (item.BackColor == Color.Yellow)
                    {
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;

                    }

                }
            }
            else
            {
                if (ai > 1)
                {
                    vitri = (ai - 1) * N + bi;
                    vitri2 = (bi - 1) * N + ai;
                    Random ra = new Random();
                    //tb[vitri].ReadOnly = false;
                    tb[vitri].BackColor = Color.FromArgb(ra.Next(256), ra.Next(256), ra.Next(256));
                    //tb[vitri2].ReadOnly = false;
                    tb[vitri2].BackColor = Color.FromArgb(ra.Next(256), ra.Next(256), ra.Next(256));
                    vitri = 0;
                    vitri2 = 0;
                }
                else
                {
                    vitri = ai * bi;
                    vitri2 = (bi - 1) * N + ai;
                    Random ra = new Random();
                    //tb[vitri].ReadOnly = false;
                    tb[vitri].BackColor = Color.FromArgb(ra.Next(256), ra.Next(256), ra.Next(256));
                    //tb[vitri2].ReadOnly = false;
                    tb[vitri2].BackColor = Color.FromArgb(ra.Next(256), ra.Next(256), ra.Next(256));
                    vitri = 0;
                    vitri2 = 0;
                }
            }


        }
        int vitridacbiet = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
            //tb[vitri].ReadOnly = false;
            tb[vitridacbiet].BackColor = Color.FromArgb(ra.Next(256), ra.Next(256), ra.Next(256));
            Tre(5);
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Application.Exit();
        }

        private void frmMatrantrongso_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát chương trình chứ?", "Thông Báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            frmhuongdan frm = new frmhuongdan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
 
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmthongtin frm = new frmthongtin();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
        private void frmMatrantrongso_Load(object sender, EventArgs e)
        {
            Flashxuatquan.Movie = Application.StartupPath + "\\DongHo.swf";
            Flashchinh.Movie = Application.StartupPath + "\\Banner11.swf";
            Flasnoi.Movie = Application.StartupPath + "\\Vui.swf";
        }

        private void txtkichthuocmatran_TextChanged(object sender, EventArgs e)
        {
            if (txtkichthuocmatran.Text.Trim().Length > 1)
            {
                MessageBox.Show("Ma trận giới hạn là <9, Vui lòng nhập lại!", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtkichthuocmatran.Text = "";
            }
        }

        private void panelinmatran_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chktungbuoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void chktatam_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chktatam.Checked == true)
        //        Flasnoi.Playing = false;
        //    else
        //        Flasnoi.Playing = true;
        //}

        //private void timer3_Tick(object sender, EventArgs e)
        //{
        //    Point pos;
        //    pos = new Point(label7.Location.X - 3, label7.Location.Y);
        //    if(label7.Location.X< 19)
        //    {
        //        pos = new Point(207, label7.Location.Y);
        //    }
        //    label7.Location = pos;

        //}

        //private void timer3_Tick(object sender, EventArgs e)
        //{
        //    Point pos;
        //    pos = new Point(this.Location.X - 3, this.Location.Y);
        //    if (this.Location.X < -this.Size.Width)
        //        //pos = new Point(this.Size.Width, label2.Location.Y);
        //        pos = new Point(500, this.Location.Y);

        //    this.Location = pos;
        //}
       
        
        
        #region Vẽ

        #endregion

    }
}
