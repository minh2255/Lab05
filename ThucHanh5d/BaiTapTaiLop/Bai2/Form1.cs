using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NNLTCSharpBaiTapTaiLop.Bai2
{
    public partial class Form1 : Form
    {
        private bool isThem = false;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

            listView1.Columns.Clear();

            // Tạo các cột cho ListView
            listView1.Columns.Add("STT", 50);
            listView1.Columns.Add("Số tài khoản", 130);
            listView1.Columns.Add("Tên khách hàng", 180);
            listView1.Columns.Add("Địa chỉ", 180);
            listView1.Columns.Add("Số tiền", 150);

            btnXoa.Enabled = false;
            SetControlState(false);
        }

        private void SetControlState(bool editing)
        {
            txtSoTK.Enabled = editing;
            txtTenKH.Enabled = editing;
            txtDiaChi.Enabled = editing;
            txtSoTien.Enabled = editing;
            btnLuu.Enabled = editing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isThem)
            {
                // Chuyển sang trạng thái thêm mới / hủy
                isThem = true;
                btnThem.Text = "Hủy";
                SetControlState(true);
                ClearText();
                txtSoTK.Focus();
            }
            else
            {
                // Hủy thao tác thêm
                isThem = false;
                btnThem.Text = "Thêm";
                SetControlState(false);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTK.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và số tiền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSoTien.Text, out double soTien))
            {
                MessageBox.Show("Số tiền phải là định dạng số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stt = listView1.Items.Count + 1;
            ListViewItem lvi = new ListViewItem(stt.ToString()); 
            lvi.SubItems.Add(txtSoTK.Text.Trim());
            lvi.SubItems.Add(txtTenKH.Text.Trim());
            lvi.SubItems.Add(txtDiaChi.Text.Trim());
            lvi.SubItems.Add(soTien.ToString("N0")); // Định dạng số tiền có dấu phẩy hàng nghìn

            listView1.Items.Add(lvi);
            TinhTongTien();

            // Reset trạng thái sau khi lưu thành công
            isThem = false;
            btnThem.Text = "Thêm";
            SetControlState(false);
            ClearText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                CapNhatSTT();
                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtSoTK.Text = item.SubItems[1].Text;
                txtTenKH.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoTien.Text = item.SubItems[4].Text.Replace(",", "");
                btnXoa.Enabled = true; // Bật nút Xóa khi có mẫu tin được chọn
            }
        }

        private void TinhTongTien()
        {
            double tong = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (double.TryParse(item.SubItems[4].Text.Replace(",", ""), out double val))
                {
                    tong += val;
                }
            }
            txtTongTien.Text = tong.ToString("N0") + " VNĐ";
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Text = (i + 1).ToString();
            }
        }

        private void ClearText()
        {
            txtSoTK.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}