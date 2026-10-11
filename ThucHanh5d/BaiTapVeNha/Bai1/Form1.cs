using System;
using System.Windows.Forms;

namespace NNLTCSharpBaiTapVeNha.Bai1
{
    public partial class Form1 : Form
    {
        // Đếm ngược 30 phút (30 * 60 = 1800 giây). Nếu chỉ đếm 30 giây thì gán = 30.
        private int remainingSeconds = 30 * 60;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 giây gọi sự kiện Tick 1 lần
            timer1.Tick += Timer1_Tick;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBatDau.Enabled = false; // Vô hiệu hóa nút sau khi bấm bắt đầu
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                int minutes = remainingSeconds / 60;
                int seconds = remainingSeconds % 60;

                // Hiển thị định dạng mm:ss (ví dụ: 29:59)
                lblTime.Text = $"{minutes:D2}:{seconds:D2}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Đã hết thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBatDau.Enabled = true;
            }
        }
    }
}