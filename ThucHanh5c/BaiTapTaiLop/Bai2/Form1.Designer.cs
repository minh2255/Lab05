namespace NNLTCSharpBaiTapTaiLop.Bai2;

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
        trv_LopSV = new TreeView();
        label1 = new Label();
        cbo_ChonLop = new ComboBox();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        txt_MaSV = new TextBox();
        txt_HoTen = new TextBox();
        txt_DiaChi = new TextBox();
        txt_TenLop = new TextBox();
        chk_ThemLop = new CheckBox();
        btn_CapNhat = new Button();
        btn_Xoa = new Button();
        btn_ThemLop = new Button();
        label7 = new Label();
        grp_ThongTinLop = new GroupBox();
        label2 = new Label();
        grp_ThongTinLop.SuspendLayout();
        SuspendLayout();
        // 
        // trv_LopSV
        // 
        trv_LopSV.Location = new Point(12, 37);
        trv_LopSV.Name = "trv_LopSV";
        trv_LopSV.Size = new Size(182, 146);
        trv_LopSV.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(270, 49);
        label1.Name = "label1";
        label1.Size = new Size(85, 25);
        label1.TabIndex = 1;
        label1.Text = "Chọn lớp";
        // 
        // cbo_ChonLop
        // 
        cbo_ChonLop.FormattingEnabled = true;
        cbo_ChonLop.Location = new Point(377, 46);
        cbo_ChonLop.Name = "cbo_ChonLop";
        cbo_ChonLop.Size = new Size(182, 33);
        cbo_ChonLop.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(296, 149);
        label3.Name = "label3";
        label3.Size = new Size(67, 25);
        label3.TabIndex = 4;
        label3.Text = "Mã SV:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(296, 195);
        label4.Name = "label4";
        label4.Size = new Size(70, 25);
        label4.TabIndex = 5;
        label4.Text = "Họ tên:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(296, 245);
        label5.Name = "label5";
        label5.Size = new Size(69, 25);
        label5.TabIndex = 6;
        label5.Text = "Địa chỉ:";
        // 
        // txt_MaSV
        // 
        txt_MaSV.Location = new Point(395, 146);
        txt_MaSV.Name = "txt_MaSV";
        txt_MaSV.Size = new Size(150, 31);
        txt_MaSV.TabIndex = 8;
        // 
        // txt_HoTen
        // 
        txt_HoTen.Location = new Point(395, 189);
        txt_HoTen.Name = "txt_HoTen";
        txt_HoTen.Size = new Size(150, 31);
        txt_HoTen.TabIndex = 9;
        // 
        // txt_DiaChi
        // 
        txt_DiaChi.Location = new Point(395, 239);
        txt_DiaChi.Name = "txt_DiaChi";
        txt_DiaChi.Size = new Size(150, 31);
        txt_DiaChi.TabIndex = 10;
        // 
        // txt_TenLop
        // 
        txt_TenLop.Location = new Point(125, 39);
        txt_TenLop.Name = "txt_TenLop";
        txt_TenLop.Size = new Size(150, 31);
        txt_TenLop.TabIndex = 11;
        // 
        // chk_ThemLop
        // 
        chk_ThemLop.AutoSize = true;
        chk_ThemLop.Location = new Point(270, 365);
        chk_ThemLop.Name = "chk_ThemLop";
        chk_ThemLop.Size = new Size(113, 29);
        chk_ThemLop.TabIndex = 12;
        chk_ThemLop.Text = "Thêm lớp";
        chk_ThemLop.UseVisualStyleBackColor = true;
        // 
        // btn_CapNhat
        // 
        btn_CapNhat.Location = new Point(296, 309);
        btn_CapNhat.Name = "btn_CapNhat";
        btn_CapNhat.Size = new Size(112, 34);
        btn_CapNhat.TabIndex = 13;
        btn_CapNhat.Text = "Cập nhật";
        btn_CapNhat.UseVisualStyleBackColor = true;
        btn_CapNhat.Click += btn_CapNhat_Click;
        // 
        // btn_Xoa
        // 
        btn_Xoa.Location = new Point(433, 309);
        btn_Xoa.Name = "btn_Xoa";
        btn_Xoa.Size = new Size(112, 34);
        btn_Xoa.TabIndex = 14;
        btn_Xoa.Text = "Xóa";
        btn_Xoa.UseVisualStyleBackColor = true;
        btn_Xoa.Click += btn_Xoa_Click;
        // 
        // btn_ThemLop
        // 
        btn_ThemLop.Location = new Point(301, 36);
        btn_ThemLop.Name = "btn_ThemLop";
        btn_ThemLop.Size = new Size(112, 34);
        btn_ThemLop.TabIndex = 15;
        btn_ThemLop.Text = "Thêm lớp";
        btn_ThemLop.UseVisualStyleBackColor = true;
        btn_ThemLop.Click += btn_ThemLop_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(26, 45);
        label7.Name = "label7";
        label7.Size = new Size(78, 25);
        label7.TabIndex = 16;
        label7.Text = "Tên lớp: ";
        // 
        // grp_ThongTinLop
        // 
        grp_ThongTinLop.Controls.Add(label7);
        grp_ThongTinLop.Controls.Add(btn_ThemLop);
        grp_ThongTinLop.Controls.Add(txt_TenLop);
        grp_ThongTinLop.Location = new Point(270, 410);
        grp_ThongTinLop.Name = "grp_ThongTinLop";
        grp_ThongTinLop.Size = new Size(475, 118);
        grp_ThongTinLop.TabIndex = 17;
        grp_ThongTinLop.TabStop = false;
        grp_ThongTinLop.Text = "Thông tin lớp";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(270, 106);
        label2.Name = "label2";
        label2.Size = new Size(162, 25);
        label2.TabIndex = 3;
        label2.Text = "Thông tin sinh viên";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 535);
        Controls.Add(grp_ThongTinLop);
        Controls.Add(btn_Xoa);
        Controls.Add(btn_CapNhat);
        Controls.Add(chk_ThemLop);
        Controls.Add(txt_DiaChi);
        Controls.Add(txt_HoTen);
        Controls.Add(txt_MaSV);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(cbo_ChonLop);
        Controls.Add(label1);
        Controls.Add(trv_LopSV);
        Name = "Form1";
        Text = "Form1";
        grp_ThongTinLop.ResumeLayout(false);
        grp_ThongTinLop.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TreeView trv_LopSV;
    private Label label1;
    private ComboBox cbo_ChonLop;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txt_MaSV;
    private TextBox txt_HoTen;
    private TextBox txt_DiaChi;
    private TextBox txt_TenLop;
    private CheckBox chk_ThemLop;
    private Button btn_CapNhat;
    private Button btn_Xoa;
    private Button btn_ThemLop;
    private Label label7;
    private GroupBox grp_ThongTinLop;
    private Label label2;
}
