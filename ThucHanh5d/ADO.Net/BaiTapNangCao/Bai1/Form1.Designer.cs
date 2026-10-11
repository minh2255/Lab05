namespace NNLTCSharpADOBaiTapNangCao.Bai1;

partial class QLSinhVien
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        txtMaLop = new TextBox();
        txtMaSV = new TextBox();
        txtHoTen = new TextBox();
        txtNgaySinh = new TextBox();
        btnThem = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 19);
        label1.Name = "label1";
        label1.Size = new Size(68, 25);
        label1.TabIndex = 0;
        label1.Text = "Mã lớp";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(21, 75);
        label2.Name = "label2";
        label2.Size = new Size(59, 25);
        label2.TabIndex = 1;
        label2.Text = "Mã sv";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(21, 135);
        label3.Name = "label3";
        label3.Size = new Size(66, 25);
        label3.TabIndex = 2;
        label3.Text = "Họ tên";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(21, 195);
        label4.Name = "label4";
        label4.Size = new Size(91, 25);
        label4.TabIndex = 3;
        label4.Text = "Ngày sinh";
        // 
        // txtMaLop
        // 
        txtMaLop.Location = new Point(123, 12);
        txtMaLop.Name = "txtMaLop";
        txtMaLop.Size = new Size(150, 31);
        txtMaLop.TabIndex = 4;
        // 
        // txtMaSV
        // 
        txtMaSV.Location = new Point(123, 69);
        txtMaSV.Name = "txtMaSV";
        txtMaSV.Size = new Size(150, 31);
        txtMaSV.TabIndex = 5;
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(123, 126);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(150, 31);
        txtHoTen.TabIndex = 6;
        // 
        // txtNgaySinh
        // 
        txtNgaySinh.Location = new Point(123, 189);
        txtNgaySinh.Name = "txtNgaySinh";
        txtNgaySinh.Size = new Size(150, 31);
        txtNgaySinh.TabIndex = 7;
        // 
        // btnThem
        // 
        btnThem.Location = new Point(21, 251);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(112, 34);
        btnThem.TabIndex = 8;
        btnThem.Text = "Thêm ";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(187, 251);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(112, 34);
        btnXoa.TabIndex = 9;
        btnXoa.Text = "Xóa ";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnSua
        // 
        btnSua.Location = new Point(361, 251);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(112, 34);
        btnSua.TabIndex = 10;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        // 
        // sqlConnection1
        // 
        sqlConnection1.AccessTokenCallback = null;
        sqlConnection1.FireInfoMessageEventOnUserErrors = false;
        sqlConnection1.RegisteredApplication = Microsoft.Data.SqlClient.RegisteredApplication.Unknown;
        sqlConnection1.SspiContextProvider = null;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnThem);
        Controls.Add(txtNgaySinh);
        Controls.Add(txtHoTen);
        Controls.Add(txtMaSV);
        Controls.Add(txtMaLop);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtMaLop;
    private TextBox txtMaSV;
    private TextBox txtHoTen;
    private TextBox txtNgaySinh;
    private Button btnThem;
    private Button btnXoa;
    private Button btnSua;
    private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
}
