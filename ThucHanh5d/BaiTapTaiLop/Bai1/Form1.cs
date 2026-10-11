using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NNLTCSharpBaiTapTaiLop.Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDanToc.Items.AddRange(new string[] { "Kinh", "Hoa", "K'Me", "H'Mong", "Khác" });
            if (cboDanToc.Items.Count > 0) cboDanToc.SelectedIndex = 0;


            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

            listView1.Columns.Clear();

            listView1.Columns.Add("Họ và tên", 120);
            listView1.Columns.Add("Mã sinh viên", 100);
            listView1.Columns.Add("Giới tính", 80);
            listView1.Columns.Add("Ngoại ngữ", 100);
            listView1.Columns.Add("Dân tộc", 100);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Họ tên và Mã sinh viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == maSV)
                {
                    MessageBox.Show("Mã sinh viên bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = "";
            if (chkAnh.Checked) ngoaiNgu += "Anh ";
            if (chkPhap.Checked) ngoaiNgu += "Pháp ";
            if (chkHoa.Checked) ngoaiNgu += "Hoa ";

            ListViewItem lvi = new ListViewItem(hoTen);
            lvi.SubItems.Add(maSV);
            lvi.SubItems.Add(gioiTinh);
            lvi.SubItems.Add(ngoaiNgu.Trim());
            lvi.SubItems.Add(cboDanToc.Text);

            listView1.Items.Add(lvi);
            ClearFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                item.Text = txtHoTen.Text.Trim();
                item.SubItems[2].Text = rdoNam.Checked ? "Nam" : "Nữ";

                string ngoaiNgu = "";
                if (chkAnh.Checked) ngoaiNgu += "Anh ";
                if (chkPhap.Checked) ngoaiNgu += "Pháp ";
                if (chkHoa.Checked) ngoaiNgu += "Hoa ";
                item.SubItems[3].Text = ngoaiNgu.Trim();
                item.SubItems[4].Text = cboDanToc.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtHoTen.Text = item.Text;
                txtMaSV.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text == "Nam") rdoNam.Checked = true; else rdoNu.Checked = true;

                string nn = item.SubItems[3].Text;
                chkAnh.Checked = nn.Contains("Anh");
                chkPhap.Checked = nn.Contains("Pháp");
                chkHoa.Checked = nn.Contains("Hoa");
                cboDanToc.Text = item.SubItems[4].Text;
            }
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ClearFields()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            rdoNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            if (cboDanToc.Items.Count > 0) cboDanToc.SelectedIndex = 0;
            txtHoTen.Focus();
        }
    }
}