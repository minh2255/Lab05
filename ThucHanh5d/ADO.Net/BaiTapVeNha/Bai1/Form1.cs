using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace NNLTCSharpADOBaiTapVeNha.Bai1
{
    public partial class frmLop : Form
    {
        // Kết nối SQL Server LocalDB
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True";

        public frmLop()
        {
            InitializeComponent();
        }

        // THÊM LỚP
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show(
                    "Mã khoa, Mã lớp và Tên lớp không được để trống!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Lop (MaLop, TenLop, MaKhoa)
                                     VALUES (@MaLop, @TenLop, @MaKhoa)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 20)
                            .Value = txtMaLop.Text.Trim();

                        cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100)
                            .Value = txtTenLop.Text.Trim();

                        cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 20)
                            .Value = txtMaKhoa.Text.Trim();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Thêm lớp thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thêm lớp thất bại! Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // XÓA LỚP THEO MÃ LỚP
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã lớp cần xóa!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtMaLop.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa lớp này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Lop WHERE MaLop = @MaLop";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 20)
                            .Value = txtMaLop.Text.Trim();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Xóa lớp thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy mã lớp cần xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Xóa lớp thất bại! Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SỬA THÔNG TIN LỚP
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show(
                    "Mã lớp không được để trống khi sửa!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtMaLop.Focus();
                return;
            }

            bool suaMaKhoa = !string.IsNullOrWhiteSpace(txtMaKhoa.Text);
            bool suaTenLop = !string.IsNullOrWhiteSpace(txtTenLop.Text);

            if (!suaMaKhoa && !suaTenLop)
            {
                MessageBox.Show(
                    "Vui lòng nhập ít nhất một thông tin cần sửa: Mã khoa hoặc Tên lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE Lop SET ";

                    if (suaMaKhoa)
                        query += "MaKhoa = @MaKhoa";

                    if (suaTenLop)
                    {
                        if (suaMaKhoa)
                            query += ", ";

                        query += "TenLop = @TenLop";
                    }

                    query += " WHERE MaLop = @MaLop";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 20)
                            .Value = txtMaLop.Text.Trim();

                        if (suaMaKhoa)
                        {
                            cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 20)
                                .Value = txtMaKhoa.Text.Trim();
                        }

                        if (suaTenLop)
                        {
                            cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100)
                                .Value = txtTenLop.Text.Trim();
                        }

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Cập nhật thông tin lớp thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy mã lớp cần sửa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Cập nhật lớp thất bại! Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // XÓA TRẮNG CÁC Ô NHẬP
        private void ClearFields()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();

            txtMaLop.Focus();
        }
    }
}