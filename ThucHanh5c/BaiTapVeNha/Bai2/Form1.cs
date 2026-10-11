using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapVeNha.Bai2
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
            lst_So.SelectionMode = SelectionMode.MultiExtended; // Cho phép chọn nhiều
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_SoN.Text, out int n))
            {
                lst_So.Items.Add(n);
                txt_SoN.Clear();
                txt_SoN.Focus();
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = lst_So.Items.Cast<int>().Sum();
            MessageBox.Show($"Tổng các phần tử trong List: {tong}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lst_So.Items.Count > 0)
            {
                lst_So.Items.RemoveAt(lst_So.Items.Count - 1); // Xóa cuối
                if (lst_So.Items.Count > 0)
                {
                    lst_So.Items.RemoveAt(0); // Xóa đầu
                }
            }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            while (lst_So.SelectedItems.Count > 0)
            {
                lst_So.Items.Remove(lst_So.SelectedItems[0]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_So.Items.Count; i++)
            {
                int val = (int)lst_So.Items[i];
                lst_So.Items[i] = val + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_So.Items.Count; i++)
            {
                int val = (int)lst_So.Items[i];
                lst_So.Items[i] = val * val;
            }
        }

        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lst_So.ClearSelected();
            for (int i = 0; i < lst_So.Items.Count; i++)
            {
                if ((int)lst_So.Items[i] % 2 == 0)
                {
                    lst_So.SetSelected(i, true);
                }
            }
        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lst_So.ClearSelected();
            for (int i = 0; i < lst_So.Items.Count; i++)
            {
                if ((int)lst_So.Items[i] % 2 != 0)
                {
                    lst_So.SetSelected(i, true);
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}