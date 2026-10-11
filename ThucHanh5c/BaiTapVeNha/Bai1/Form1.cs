using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapVeNha.Bai1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> dictAnhViet = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            cbo_TuAnh.TextChanged += Cbo_TuAnh_TextChanged;
            cbo_TuAnh.KeyDown += Cbo_TuAnh_KeyDown;
            lst_TuAnh.SelectedIndexChanged += Lst_TuAnh_SelectedIndexChanged;
            lst_TuAnh.DoubleClick += Lst_TuAnh_DoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictAnhViet.Add("student", "Sinh viên, học sinh");
            dictAnhViet.Add("teacher", "Giáo viên");
            dictAnhViet.Add("worker", "Công nhân");
            dictAnhViet.Add("hat", "Cái mũ");
            dictAnhViet.Add("head", "Cái đầu");
            dictAnhViet.Add("mouse", "Con chuột");
            dictAnhViet.Add("cat", "Con mèo");
            dictAnhViet.Add("dog", "Con chó");

            NapDanhSach();
        }

        private void NapDanhSach()
        {
            cbo_TuAnh.Items.Clear();
            lst_TuAnh.Items.Clear();
            foreach (var key in dictAnhViet.Keys)
            {
                cbo_TuAnh.Items.Add(key);
                lst_TuAnh.Items.Add(key);
            }
        }

        private void Cbo_TuAnh_TextChanged(object sender, EventArgs e)
        {
            string keyword = cbo_TuAnh.Text.Trim();
            if (string.IsNullOrEmpty(keyword)) return;

            int index = lst_TuAnh.FindString(keyword);
            if (index != -1)
            {
                lst_TuAnh.SelectedIndex = index;
            }
        }

        private void Cbo_TuAnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HienThiNghia(cbo_TuAnh.Text.Trim());
            }
        }

        private void Lst_TuAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_TuAnh.SelectedItem != null)
            {
                cbo_TuAnh.Text = lst_TuAnh.SelectedItem.ToString();
            }
        }

        private void Lst_TuAnh_DoubleClick(object sender, EventArgs e)
        {
            if (lst_TuAnh.SelectedItem != null)
            {
                HienThiNghia(lst_TuAnh.SelectedItem.ToString());
            }
        }

        private void HienThiNghia(string word)
        {
            if (dictAnhViet.TryGetValue(word, out string nghia))
            {
                txt_NghiaViet.Text = nghia;
            }
            else
            {
                txt_NghiaViet.Text = "Không tìm thấy từ này trong từ điển!";
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}