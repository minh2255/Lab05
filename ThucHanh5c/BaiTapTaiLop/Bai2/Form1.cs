using System;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapTaiLop.Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            chk_ThemLop.CheckedChanged += Chk_ThemLop_CheckedChanged;
            trv_LopSV.AfterSelect += Trv_LopSV_AfterSelect;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grp_ThongTinLop.Visible = false;
            string[] macDinhLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };
            foreach (string lop in macDinhLop)
            {
                trv_LopSV.Nodes.Add(lop);
                cbo_ChonLop.Items.Add(lop);
            }
            if (cbo_ChonLop.Items.Count > 0) cbo_ChonLop.SelectedIndex = 0;
        }

        private void Chk_ThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grp_ThongTinLop.Visible = chk_ThemLop.Checked;
        }
        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txt_TenLop.Text.Trim();
            if (string.IsNullOrEmpty(tenLop)) return;

            foreach (TreeNode node in trv_LopSV.Nodes)
            {
                if (string.Compare(node.Text, tenLop, true) == 0)
                {
                    MessageBox.Show("Tên lớp đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            trv_LopSV.Nodes.Add(tenLop);
            cbo_ChonLop.Items.Add(tenLop);
            txt_TenLop.Clear();
        }

        private bool KiemTraTrungMaSV(string maSV)
        {
            foreach (TreeNode lopNode in trv_LopSV.Nodes)
            {
                foreach (TreeNode svNode in lopNode.Nodes)
                {
                    if (svNode.Tag != null && svNode.Tag.ToString() == maSV)
                        return true;
                }
            }
            return false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSV.Text) || string.IsNullOrWhiteSpace(txt_HoTen.Text) || string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KiemTraTrungMaSV(txt_MaSV.Text.Trim()))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lopChon = cbo_ChonLop.Text;
            TreeNode lopNodeChon = null;
            foreach (TreeNode node in trv_LopSV.Nodes)
            {
                if (node.Text == lopChon)
                {
                    lopNodeChon = node;
                    break;
                }
            }

            if (lopNodeChon != null)
            {
                TreeNode svNode = new TreeNode($"{txt_MaSV.Text.Trim()}, {txt_HoTen.Text.Trim()}");
                svNode.Tag = txt_MaSV.Text.Trim();
                TreeNode dcNode = new TreeNode(txt_DiaChi.Text.Trim());

                svNode.Nodes.Add(dcNode);
                lopNodeChon.Nodes.Add(svNode);
                trv_LopSV.ExpandAll();

                txt_MaSV.Clear();
                txt_HoTen.Clear();
                txt_DiaChi.Clear();
            }
        }

        private void Trv_LopSV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node != null && node.Parent != null && node.Parent.Parent == null) // Là node Sinh Viên
            {
                string[] parts = node.Text.Split(',');
                if (parts.Length >= 2)
                {
                    txt_MaSV.Text = parts[0].Trim();
                    txt_HoTen.Text = parts[1].Trim();
                }
                if (node.Nodes.Count > 0)
                {
                    txt_DiaChi.Text = node.Nodes[0].Text;
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            TreeNode selected = trv_LopSV.SelectedNode;
            if (selected != null && selected.Parent != null && selected.Parent.Parent == null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    trv_LopSV.Nodes.Remove(selected);
                    txt_MaSV.Clear();
                    txt_HoTen.Clear();
                    txt_DiaChi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng Node sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}