using System;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapVeNha.Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo sẵn các node ký tự từ A đến Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                trv_DanhBa.Nodes.Add(c.ToString());
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string firstName = txt_FirstName.Text.Trim();
            string lastName = txt_LastName.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ First Name và Last Name!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ký tự đầu của First Name
            char firstChar = char.ToUpper(firstName[0]);

            if (firstChar >= 'A' && firstChar <= 'Z')
            {
                int index = firstChar - 'A';
                trv_DanhBa.Nodes[index].Nodes.Add($"{firstName}, {lastName}");
                trv_DanhBa.Nodes[index].Expand();

                txt_FirstName.Clear();
                txt_LastName.Clear();
                txt_FirstName.Focus();
            }
            else
            {
                MessageBox.Show("Chữ cái đầu tiên phải thuộc từ A đến Z!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
