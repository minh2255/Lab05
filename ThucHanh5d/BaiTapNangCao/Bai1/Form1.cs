using System;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapNangCao.Bai1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Hiển thị danh sách học viên khi mở chương trình
        private void frmMain_Load(object sender, EventArgs e)
        {
            lstLopA.Items.Clear();
            lstLopB.Items.Clear();

            lstLopA.Items.Add("Trần Hùng");
            lstLopA.Items.Add("Nguyên Hưng");
            lstLopA.Items.Add("Lâm Tứ");

            lstLopB.Items.Add("Tuấn Hưng");
            lstLopB.Items.Add("Hồng Ngọc");
            lstLopB.Items.Add("Anh Minh");
            lstLopB.Items.Add("Bảo Lâm");
        }

        // Mở form nhập học viên mới
        private void mnuNhapHocVien_Click(object sender, EventArgs e)
        {
            using (frmNhapHocVien frm = new frmNhapHocVien())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    if (frm.LopChon == "Lớp A")
                        lstLopA.Items.Add(frm.HoTenMoi);
                    else if (frm.LopChon == "Lớp B")
                        lstLopB.Items.Add(frm.HoTenMoi);
                }
            }
        }
    }
}
