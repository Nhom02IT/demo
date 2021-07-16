using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Toan_RR5
{
    public partial class frmkhoidong : Form
    {
        public frmkhoidong()
        {
            InitializeComponent();
        }

        private void frmkhoidong_Load(object sender, EventArgs e)
        {
            //Flash.Movie = Application.StartupPath + "\\12.swf";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if (progressBar1.Value == progressBar1.Maximum)
                timer1.Stop();
        }
    }
}
