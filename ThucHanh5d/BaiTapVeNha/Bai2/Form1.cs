using System;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using NNLTCSharpBaiTapTaiLop.Bai1;
using NNLTCSharpBaiTapTaiLop.Bai2;

namespace NNLTCSharpBaiTapVeNha.Bai2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Form chính chứa các Form con
            this.IsMdiContainer = true;

            // Gắn sự kiện cho MenuStrip
            mnuBai1.Click += mnuBai1_Click;
            mnuBai2.Click += mnuBai2_Click;
        }

        private void mnuBai1_Click(object sender, EventArgs e)
        {
            NNLTCSharpBaiTapTaiLop.Bai1.Form1 f = new NNLTCSharpBaiTapTaiLop.Bai1.Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuBai2_Click(object sender, EventArgs e)
        {
            NNLTCSharpBaiTapTaiLop.Bai2.Form1 f = new NNLTCSharpBaiTapTaiLop.Bai2.Form1();
            f.MdiParent = this;
            f.Show();
        }
    }
}