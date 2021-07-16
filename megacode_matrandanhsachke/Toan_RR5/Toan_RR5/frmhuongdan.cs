using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Toan_RR5
{
    public partial class frmhuongdan : Form
    {
        public frmhuongdan()
        {
            InitializeComponent();
        }
        [DllImport("dwmapi.dll", PreserveSig = false)]
        private static extern void Nhap(IntPtr a, TienPro b);
        

        public class TienPro
        {
            public int cxTrai, cxPhai, cyTren,cyduoi;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDuyetMaTran_Click(object sender, EventArgs e)
        {
            Flash.Movie = Application.StartupPath + "\\MaTran2.swf";
            string s = "Video Hướng Dẫn" +" "+ btnDuyetMaTran.Text;
            label1.Text = s;
        }

        private void btndung_Click(object sender, EventArgs e)
        {
            if (btndung.Text == "Tiếp Tục")
            {
                btndung.Text = "Dừng";
                Flash.Playing = true;
            }
            else
            {
                btndung.Text = "Tiếp Tục";
                Flash.Playing = false;
            }

        }

        private void dừngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flash.Playing = false;
        }

        private void tiếpTụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flash.Playing = true;
        }

        private void btnnhapmatran_Click(object sender, EventArgs e)
        {
            Flash.Movie = Application.StartupPath + "\\MaTran1.swf";
            string s = "Video Hướng Dẫn" + " " + btnnhapmatran.Text;
            
            label1.Text = s;
        }

        private void frmhuongdan_Load(object sender, EventArgs e)
        {
            Flash.Movie = Application.StartupPath + "\\TienAnPhuong.swf";
            //this.BackColor = Color.Transparent;
        }
    }
}
