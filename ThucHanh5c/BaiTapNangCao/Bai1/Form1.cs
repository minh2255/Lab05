using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapNangCao.Bai1
{
    public partial class Form1 : Form
    {
        private string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        private string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
        private string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

        public Form1 ()
        {
            InitializeComponent();
            lst_Ten.DoubleClick += Lst_Ten_DoubleClick;
        }

        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            lst_Ten.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rand.Next(HO.Length)];
                string lot = TENLOT[rand.Next(TENLOT.Length)];
                string ten = TEN[rand.Next(TEN.Length)];
                lst_Ten.Items.Add($"{ho} {lot} {ten}");
            }
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            while (lst_Ten.SelectedItems.Count > 0)
            {
                lst_Ten.Items.Remove(lst_Ten.SelectedItems[0]);
            }
        }

        private void btnXoaTenSon_Click(object sender, EventArgs e)
        {
            for (int i = lst_Ten.Items.Count - 1; i >= 0; i--)
            {
                string item = lst_Ten.Items[i].ToString();
                if (item.EndsWith(" Sơn", StringComparison.OrdinalIgnoreCase))
                {
                    lst_Ten.Items.RemoveAt(i);
                }
            }
        }

        private void btnXoaHoLe_Click(object sender, EventArgs e)
        {
            for (int i = lst_Ten.Items.Count - 1; i >= 0; i--)
            {
                string item = lst_Ten.Items[i].ToString();
                if (item.StartsWith("Lê ", StringComparison.OrdinalIgnoreCase))
                {
                    lst_Ten.Items.RemoveAt(i);
                }
            }
        }

        private void btnHoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_Ten.SelectedIndices.Count; i++)
            {
                int idx = lst_Ten.SelectedIndices[i];
                lst_Ten.Items[idx] = lst_Ten.Items[idx].ToString().ToUpper();
            }
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_Ten.SelectedIndices.Count; i++)
            {
                int idx = lst_Ten.SelectedIndices[i];
                lst_Ten.Items[idx] = lst_Ten.Items[idx].ToString().ToLower();
            }
        }

        private void btnHoaDauTu_Click(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("vi-VN", false).TextInfo;
            for (int i = 0; i < lst_Ten.SelectedIndices.Count; i++)
            {
                int idx = lst_Ten.SelectedIndices[i];
                lst_Ten.Items[idx] = textInfo.ToTitleCase(lst_Ten.Items[idx].ToString().ToLower());
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lst_Ten.Items.Clear();
        }

        // Nhấp đôi vào item để chỉnh sửa bằng Form phụ (hoặc Microsoft.VisualBasic.Interaction.InputBox)
        private void Lst_Ten_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Ten.SelectedIndex != -1)
            {
                string currentVal = lst_Ten.SelectedItem.ToString();
                // Giả định nhập tên mới qua InputBox hoặc Prompt
                string newVal = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên mới:", "Sửa tên", currentVal);
                if (!string.IsNullOrWhiteSpace(newVal))
                {
                    lst_Ten.Items[lst_Ten.SelectedIndex] = newVal;
                }
            }
        }
    }
}