using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace NNLTCSharpADOBaiTapTaiLop.Bai1
{
    public partial class QLMonHoc : Form
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSINHVIEN;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True";

        public QLMonHoc()
        {
            InitializeComponent();
        }

        // THÊM MÔN HỌC
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và tên môn học không được để trống!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO MonHoc (MaMonHoc, TenMonHoc)
                                     VALUES (@Ma, @Ten)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Ma", SqlDbType.VarChar, 20)
                            .Value = txtMaMH.Text.Trim();

                        cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100)
                            .Value = txtTenMH.Text.Trim();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Thêm môn học thành công!");
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }

        // XÓA MÔN HỌC
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn học cần xóa!");
                txtMaMH.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        "DELETE FROM MonHoc WHERE MaMonHoc = @Ma";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Ma", SqlDbType.VarChar, 20)
                            .Value = txtMaMH.Text.Trim();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa môn học thành công!");
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy môn học cần xóa!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message);
            }
        }

        // SỬA TÊN MÔN HỌC
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và tên môn học không được để trống!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                        @"UPDATE MonHoc
                          SET TenMonHoc = @Ten
                          WHERE MaMonHoc = @Ma";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Ma", SqlDbType.VarChar, 20)
                            .Value = txtMaMH.Text.Trim();

                        cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100)
                            .Value = txtTenMH.Text.Trim();

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật môn học thành công!");
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy môn học cần sửa!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message);
            }
        }

        // XÓA DỮ LIỆU TRÊN FORM
        private void ClearFields()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtMaMH.Focus();
        }
    }
}