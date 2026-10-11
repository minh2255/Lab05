
using System;
using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace NNLTCSharpADOBaiTapNangCao.Bai1
{
    public partial class QLSinhVien : Form
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSINHVIEN;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True";

        public QLSinhVien()
        {
            InitializeComponent();

            // Không đăng ký trùng sự kiện đã có trong Designer.
            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            btnSua.Click -= btnSua_Click;
            btnSua.Click += btnSua_Click;

            Text = "Quản lý sinh viên";
        }

        // Kiểm tra dữ liệu ngày sinh theo định dạng dd/MM/yyyy.
        private bool KiemTraNgaySinh(out DateTime ngaySinh)
        {
            if (!DateTime.TryParseExact(
                txtNgaySinh.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngaySinh))
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ! Hãy nhập theo định dạng dd/MM/yyyy, ví dụ 25/12/2005.",
                    "Lỗi dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNgaySinh.Focus();
                return false;
            }

            return true;
        }

        // THÊM SINH VIÊN
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text))
            {
                MessageBox.Show(
                    "Mã lớp, mã sinh viên, họ tên và ngày sinh không được để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraNgaySinh(out DateTime ngaySinh))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO SinhVien
                            (MaSinhVien, HoTen, NgaySinh, MaLop)
                        VALUES
                            (@MaSV, @HoTen, @NgaySinh, @MaLop)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                            .Value = txtMaSV.Text.Trim();

                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                            .Value = txtHoTen.Text.Trim();

                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date)
                            .Value = ngaySinh.Date;

                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 20)
                            .Value = txtMaLop.Text.Trim();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Thêm sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Thêm sinh viên thất bại!\n" + ex.Message,
                    "Lỗi SQL Server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // XÓA SINH VIÊN THEO MÃ SINH VIÊN VÀ HỌ TÊN
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sinh viên và họ tên cần xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này không?",
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

                    string query = @"
                        DELETE FROM SinhVien
                        WHERE MaSinhVien = @MaSV
                          AND HoTen = @HoTen";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                            .Value = txtMaSV.Text.Trim();

                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                            .Value = txtHoTen.Text.Trim();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Xóa sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên khớp với mã và họ tên đã nhập!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thất bại!\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // SỬA THÔNG TIN SINH VIÊN
        // Chỉ cập nhật các trường có nhập dữ liệu.
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show(
                    "Mã sinh viên không được để trống khi sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSV.Focus();
                return;
            }

            bool suaMaLop = !string.IsNullOrWhiteSpace(txtMaLop.Text);
            bool suaHoTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
            bool suaNgaySinh = !string.IsNullOrWhiteSpace(txtNgaySinh.Text);

            if (!suaMaLop && !suaHoTen && !suaNgaySinh)
            {
                MessageBox.Show(
                    "Vui lòng nhập ít nhất một thông tin cần sửa: mã lớp, họ tên hoặc ngày sinh!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DateTime ngaySinh = default;

            if (suaNgaySinh && !KiemTraNgaySinh(out ngaySinh))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE SinhVien SET ";

                    if (suaMaLop)
                        query += "MaLop = @MaLop";

                    if (suaHoTen)
                    {
                        if (suaMaLop)
                            query += ", ";

                        query += "HoTen = @HoTen";
                    }

                    if (suaNgaySinh)
                    {
                        if (suaMaLop || suaHoTen)
                            query += ", ";

                        query += "NgaySinh = @NgaySinh";
                    }

                    query += " WHERE MaSinhVien = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 20)
                            .Value = txtMaSV.Text.Trim();

                        if (suaMaLop)
                        {
                            cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 20)
                                .Value = txtMaLop.Text.Trim();
                        }

                        if (suaHoTen)
                        {
                            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                                .Value = txtHoTen.Text.Trim();
                        }

                        if (suaNgaySinh)
                        {
                            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date)
                                .Value = ngaySinh.Date;
                        }

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Cập nhật thông tin sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy mã sinh viên cần sửa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cập nhật thất bại!\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // XÓA TRẮNG CÁC Ô NHẬP
        private void ClearFields()
        {
            txtMaLop.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();

            txtMaSV.Focus();
        }
    }
}