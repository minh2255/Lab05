using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapNangCao.Bai1
{
    public partial class frmNhapHocVien : Form
    {
        // Dữ liệu trả về cho form chính
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string HoTenMoi { get; private set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LopChon { get; private set; }

        public frmNhapHocVien()
        {
            InitializeComponent();
        }

        private void frmNhapHocVien_Load(object sender, EventArgs e)
        {
            // Tránh thêm dữ liệu lớp nhiều lần
            cboLop.Items.Clear();

            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");

            // Chọn Lớp A mặc định
            cboLop.SelectedIndex = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lấy họ tên và bỏ khoảng trắng thừa
            string hoTen = txtHoTen.Text.Trim();

            // Kiểm tra họ tên rỗng
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show(
                    "Yêu cầu phải nhập họ tên học viên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtHoTen.Focus();
                return;
            }

            // Kiểm tra lớp được chọn
            if (cboLop.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn lớp cho học viên!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboLop.Focus();
                return;
            }

            // Lưu dữ liệu để form chính nhận
            HoTenMoi = hoTen;
            LopChon = cboLop.SelectedItem.ToString();

            // Thông báo kết quả và trả dữ liệu về form chính
            MessageBox.Show(
                "Thêm học viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            // Đóng form mà không thêm học viên
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}