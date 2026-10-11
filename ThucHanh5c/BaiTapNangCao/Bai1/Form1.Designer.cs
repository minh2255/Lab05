namespace NNLTCSharpBaiTapNangCao.Bai1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lst_Ten = new ListBox();
        btnNgauNhien = new Button();
        btnXoaDangChon = new Button();
        btnXoaTenSon = new Button();
        btnXoaHoLe = new Button();
        btnHoa = new Button();
        btnThuong = new Button();
        btnHoaDauTu = new Button();
        btnXoaTatCa = new Button();
        SuspendLayout();
        // 
        // lst_Ten
        // 
        lst_Ten.FormattingEnabled = true;
        lst_Ten.Location = new Point(29, 64);
        lst_Ten.Name = "lst_Ten";
        lst_Ten.Size = new Size(216, 379);
        lst_Ten.TabIndex = 0;
        // 
        // btnNgauNhien
        // 
        btnNgauNhien.Location = new Point(29, 12);
        btnNgauNhien.Name = "btnNgauNhien";
        btnNgauNhien.Size = new Size(216, 34);
        btnNgauNhien.TabIndex = 1;
        btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
        btnNgauNhien.UseVisualStyleBackColor = true;
        btnNgauNhien.Click += btnNgauNhien_Click;
        // 
        // btnXoaDangChon
        // 
        btnXoaDangChon.Location = new Point(266, 64);
        btnXoaDangChon.Name = "btnXoaDangChon";
        btnXoaDangChon.Size = new Size(344, 34);
        btnXoaDangChon.TabIndex = 2;
        btnXoaDangChon.Text = "Xóa phần tử đang chọn";
        btnXoaDangChon.UseVisualStyleBackColor = true;
        btnXoaDangChon.Click += btnXoaDangChon_Click;
        // 
        // btnXoaTenSon
        // 
        btnXoaTenSon.Location = new Point(266, 124);
        btnXoaTenSon.Name = "btnXoaTenSon";
        btnXoaTenSon.Size = new Size(344, 34);
        btnXoaTenSon.TabIndex = 3;
        btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
        btnXoaTenSon.UseVisualStyleBackColor = true;
        btnXoaTenSon.Click += btnXoaTenSon_Click;
        // 
        // btnXoaHoLe
        // 
        btnXoaHoLe.Location = new Point(266, 183);
        btnXoaHoLe.Name = "btnXoaHoLe";
        btnXoaHoLe.Size = new Size(344, 34);
        btnXoaHoLe.TabIndex = 4;
        btnXoaHoLe.Text = "Xóa phần tử có họ là Lê";
        btnXoaHoLe.UseVisualStyleBackColor = true;
        btnXoaHoLe.Click += btnXoaHoLe_Click;
        // 
        // btnHoa
        // 
        btnHoa.Location = new Point(266, 241);
        btnHoa.Name = "btnHoa";
        btnHoa.Size = new Size(344, 34);
        btnHoa.TabIndex = 5;
        btnHoa.Text = "Chuyển PT đang chọn thành chữ Hoa";
        btnHoa.UseVisualStyleBackColor = true;
        btnHoa.Click += btnHoa_Click;
        // 
        // btnThuong
        // 
        btnThuong.Location = new Point(266, 371);
        btnThuong.Name = "btnThuong";
        btnThuong.Size = new Size(344, 34);
        btnThuong.TabIndex = 6;
        btnThuong.Text = "Chuyển PT đang chọn thành chữ thường ";
        btnThuong.UseVisualStyleBackColor = true;
        btnThuong.Click += btnThuong_Click;
        // 
        // btnHoaDauTu
        // 
        btnHoaDauTu.Location = new Point(266, 292);
        btnHoaDauTu.Name = "btnHoaDauTu";
        btnHoaDauTu.Size = new Size(344, 59);
        btnHoaDauTu.TabIndex = 7;
        btnHoaDauTu.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ ";
        btnHoaDauTu.UseVisualStyleBackColor = true;
        btnHoaDauTu.Click += btnHoaDauTu_Click;
        // 
        // btnXoaTatCa
        // 
        btnXoaTatCa.Location = new Point(266, 427);
        btnXoaTatCa.Name = "btnXoaTatCa";
        btnXoaTatCa.Size = new Size(344, 34);
        btnXoaTatCa.TabIndex = 8;
        btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
        btnXoaTatCa.UseVisualStyleBackColor = true;
        btnXoaTatCa.Click += btnXoaTatCa_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 473);
        Controls.Add(btnXoaTatCa);
        Controls.Add(btnHoaDauTu);
        Controls.Add(btnThuong);
        Controls.Add(btnHoa);
        Controls.Add(btnXoaHoLe);
        Controls.Add(btnXoaTenSon);
        Controls.Add(btnXoaDangChon);
        Controls.Add(btnNgauNhien);
        Controls.Add(lst_Ten);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private ListBox lst_Ten;
    private Button btnNgauNhien;
    private Button btnXoaDangChon;
    private Button btnXoaTenSon;
    private Button btnXoaHoLe;
    private Button btnHoa;
    private Button btnThuong;
    private Button btnHoaDauTu;
    private Button btnXoaTatCa;
}
