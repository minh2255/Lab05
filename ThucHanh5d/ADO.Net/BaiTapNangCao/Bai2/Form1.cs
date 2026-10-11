using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace NNLTCSharpADOBaiTapNangCao.Bai2
{
    public partial class QLDiem : Form
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True";

        public QLDiem()
        {
            InitializeComponent();
        }

        // Chức năng THÊM: Mã SV, Mã MH và Điểm không được để trống
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show(
                    "Mã sinh viên, Mã môn học và Điểm không được để trống!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(
                    txtDiem.Text.Trim(),
                    System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.CurrentCulture,
                    out decimal diem))
            {
                MessageBox.Show("Điểm phải là kiểu số hợp lệ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Diem
                                     (MaSinhVien, MaMonHoc, Diem)
                                     VALUES (@MaSV, @MaMH, @Diem)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                            .Value = txtMaSV.Text.Trim();

                        cmd.Parameters.Add("@MaMH", SqlDbType.VarChar, 20)
                            .Value = txtMaMH.Text.Trim();

                        cmd.Parameters.Add("@Diem", SqlDbType.Decimal).Value = diem;

                        cmd.Parameters["@Diem"].Precision = 5;
                        cmd.Parameters["@Diem"].Scale = 2;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Thêm điểm thành công!",
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
                    "Thêm thất bại! Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Chức năng XÓA: Mã SV và Mã MH không được để trống
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã sinh viên và Mã môn học cần xóa!",
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

                    string query = @"DELETE FROM Diem
                                     WHERE MaSinhVien = @MaSV
                                     AND MaMonHoc = @MaMH";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                            .Value = txtMaSV.Text.Trim();

                        cmd.Parameters.Add("@MaMH", SqlDbType.VarChar, 20)
                            .Value = txtMaMH.Text.Trim();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Xóa điểm thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy dữ liệu điểm tương ứng!",
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
                    "Xóa thất bại! Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Chức năng SỬA: Cập nhật điểm theo Mã SV và Mã MH
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show(
                    "Mã sinh viên, Mã môn học và Điểm không được để trống khi sửa!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(
                    txtDiem.Text.Trim(),
                    System.Globalization.NumberStyles.Number,
                    System.Globalization.CultureInfo.CurrentCulture,
                    out decimal diemMoi))
            {
                MessageBox.Show(
                    "Điểm phải là kiểu số hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDiem.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Diem
                                     SET Diem = @Diem
                                     WHERE MaSinhVien = @MaSV
                                     AND MaMonHoc = @MaMH";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                            .Value = txtMaSV.Text.Trim();

                        cmd.Parameters.Add("@MaMH", SqlDbType.VarChar, 20)
                            .Value = txtMaMH.Text.Trim();

                        cmd.Parameters.Add("@Diem", SqlDbType.Decimal).Value = diemMoi;

                        cmd.Parameters["@Diem"].Precision = 5;
                        cmd.Parameters["@Diem"].Scale = 2;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Cập nhật điểm thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy dữ liệu điểm cần sửa!",
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
                    "Cập nhật thất bại! Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Xóa dữ liệu trên Form
        private void ClearFields()
        {
            txtMaSV.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }
    }
}