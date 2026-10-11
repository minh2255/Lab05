namespace NNLTCSharpBaiTapVeNha.Bai2;

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
        txt_SoN = new TextBox();
        lst_So = new ListBox();
        btn_Nhap = new Button();
        btnTong = new Button();
        btnXoaDauCuoi = new Button();
        btnXoaChon = new Button();
        btnTang2 = new Button();
        btnBinhPhuong = new Button();
        btnChonChan = new Button();
        btnChonLe = new Button();
        btnKetThuc = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // txt_SoN
        // 
        txt_SoN.Location = new Point(32, 96);
        txt_SoN.Name = "txt_SoN";
        txt_SoN.Size = new Size(180, 31);
        txt_SoN.TabIndex = 0;
        // 
        // lst_So
        // 
        lst_So.FormattingEnabled = true;
        lst_So.Location = new Point(32, 198);
        lst_So.Name = "lst_So";
        lst_So.Size = new Size(180, 229);
        lst_So.TabIndex = 1;
        // 
        // btn_Nhap
        // 
        btn_Nhap.Location = new Point(32, 143);
        btn_Nhap.Name = "btn_Nhap";
        btn_Nhap.Size = new Size(180, 34);
        btn_Nhap.TabIndex = 2;
        btn_Nhap.Text = "Nhập ";
        btn_Nhap.UseVisualStyleBackColor = true;
        btn_Nhap.Click += btn_Nhap_Click;
        // 
        // btnTong
        // 
        btnTong.Location = new Point(476, 93);
        btnTong.Name = "btnTong";
        btnTong.Size = new Size(251, 34);
        btnTong.TabIndex = 3;
        btnTong.Text = "Tổng các phần tử trong List";
        btnTong.UseVisualStyleBackColor = true;
        btnTong.Click += btnTong_Click;
        // 
        // btnXoaDauCuoi
        // 
        btnXoaDauCuoi.Location = new Point(477, 143);
        btnXoaDauCuoi.Name = "btnXoaDauCuoi";
        btnXoaDauCuoi.Size = new Size(250, 34);
        btnXoaDauCuoi.TabIndex = 4;
        btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
        btnXoaDauCuoi.UseVisualStyleBackColor = true;
        btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
        // 
        // btnXoaChon
        // 
        btnXoaChon.Location = new Point(477, 198);
        btnXoaChon.Name = "btnXoaChon";
        btnXoaChon.Size = new Size(250, 34);
        btnXoaChon.TabIndex = 5;
        btnXoaChon.Text = "Xóa Phần tử đang chọn";
        btnXoaChon.UseVisualStyleBackColor = true;
        btnXoaChon.Click += btnXoaChon_Click;
        // 
        // btnTang2
        // 
        btnTang2.Location = new Point(477, 254);
        btnTang2.Name = "btnTang2";
        btnTang2.Size = new Size(250, 34);
        btnTang2.TabIndex = 6;
        btnTang2.Text = "Tăng mỗi phần tử lên 2";
        btnTang2.UseVisualStyleBackColor = true;
        btnTang2.Click += btnTang2_Click;
        // 
        // btnBinhPhuong
        // 
        btnBinhPhuong.Location = new Point(477, 305);
        btnBinhPhuong.Name = "btnBinhPhuong";
        btnBinhPhuong.Size = new Size(250, 34);
        btnBinhPhuong.TabIndex = 7;
        btnBinhPhuong.Text = "Thay bằng bình phương";
        btnBinhPhuong.UseVisualStyleBackColor = true;
        btnBinhPhuong.Click += btnBinhPhuong_Click;
        // 
        // btnChonChan
        // 
        btnChonChan.Location = new Point(477, 363);
        btnChonChan.Name = "btnChonChan";
        btnChonChan.Size = new Size(250, 34);
        btnChonChan.TabIndex = 8;
        btnChonChan.Text = "Chọn số chẵn";
        btnChonChan.UseVisualStyleBackColor = true;
        btnChonChan.Click += btnChonChan_Click;
        // 
        // btnChonLe
        // 
        btnChonLe.Location = new Point(477, 413);
        btnChonLe.Name = "btnChonLe";
        btnChonLe.Size = new Size(250, 34);
        btnChonLe.TabIndex = 9;
        btnChonLe.Text = "Chọn số lẻ";
        btnChonLe.UseVisualStyleBackColor = true;
        btnChonLe.Click += btnChonLe_Click;
        // 
        // btnKetThuc
        // 
        btnKetThuc.Location = new Point(32, 462);
        btnKetThuc.Name = "btnKetThuc";
        btnKetThuc.Size = new Size(180, 34);
        btnKetThuc.TabIndex = 10;
        btnKetThuc.Text = "KẾT THÚC";
        btnKetThuc.UseVisualStyleBackColor = true;
        btnKetThuc.Click += btnKetThuc_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(327, 9);
        label1.Name = "label1";
        label1.Size = new Size(79, 25);
        label1.TabIndex = 11;
        label1.Text = "LISTBOX";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(32, 58);
        label2.Name = "label2";
        label2.Size = new Size(68, 25);
        label2.TabIndex = 12;
        label2.Text = "Listbox";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(476, 58);
        label3.Name = "label3";
        label3.Size = new Size(113, 25);
        label3.TabIndex = 13;
        label3.Text = "Xử lý Listbox";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 499);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnKetThuc);
        Controls.Add(btnChonLe);
        Controls.Add(btnChonChan);
        Controls.Add(btnBinhPhuong);
        Controls.Add(btnTang2);
        Controls.Add(btnXoaChon);
        Controls.Add(btnXoaDauCuoi);
        Controls.Add(btnTong);
        Controls.Add(btn_Nhap);
        Controls.Add(lst_So);
        Controls.Add(txt_SoN);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txt_SoN;
    private ListBox lst_So;
    private Button btn_Nhap;
    private Button btnTong;
    private Button btnXoaDauCuoi;
    private Button btnXoaChon;
    private Button btnTang2;
    private Button btnBinhPhuong;
    private Button btnChonChan;
    private Button btnChonLe;
    private Button btnKetThuc;
    private Label label1;
    private Label label2;
    private Label label3;
}
