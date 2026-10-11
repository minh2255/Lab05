using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapTaiLop.Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbo_So.SelectedIndexChanged += Cbo_So_SelectedIndexChanged;
        }

        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_NhapSo.Text, out int num) && num > 0)
            {
                if (!cbo_So.Items.Contains(num))
                {
                    cbo_So.Items.Add(num);
                    cbo_So.SelectedItem = num;
                }
                else
                {
                    MessageBox.Show("Số này đã tồn tại trong ComboBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txt_NhapSo.Clear();
                txt_NhapSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_So_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_UocSo.Items.Clear();
            if (cbo_So.SelectedItem != null && int.TryParse(cbo_So.SelectedItem.ToString(), out int num))
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        lst_UocSo.Items.Add(i);
                    }
                }
            }
        }

        private void btnTongUocSo_Click(object sender, EventArgs e)
        {
            int tong = lst_UocSo.Items.Cast<int>().Sum();
            MessageBox.Show($"Tổng các ước số: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDemUocSoChan_Click(object sender, EventArgs e)
        {
            int count = lst_UocSo.Items.Cast<int>().Count(x => x % 2 == 0);
            MessageBox.Show($"Số lượng các ước số chẵn: {count}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDemUocSoNguyenTo_Click(object sender, EventArgs e)
        {
            int count = lst_UocSo.Items.Cast<int>().Count(KiemTraNguyenTo);
            MessageBox.Show($"Số lượng các ước số nguyên tố: {count}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}