namespace NNLTCSharpBaiTapTaiLop.Bai1;

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
        label1 = new Label();
        txt_NhapSo = new TextBox();
        btnCapNhat = new Button();
        label2 = new Label();
        lst_UocSo = new ListBox();
        btnTongUocSo = new Button();
        btnDemUocSoChan = new Button();
        btnDemUocSoNguyenTo = new Button();
        btnThoat = new Button();
        cbo_So = new ComboBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(32, 40);
        label1.Name = "label1";
        label1.Size = new Size(79, 25);
        label1.TabIndex = 0;
        label1.Text = "Nhập số";
        // 
        // txt_NhapSo
        // 
        txt_NhapSo.Location = new Point(62, 68);
        txt_NhapSo.Name = "txt_NhapSo";
        txt_NhapSo.Size = new Size(150, 31);
        txt_NhapSo.TabIndex = 1;
        // 
        // btnCapNhat
        // 
        btnCapNhat.Location = new Point(248, 68);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new Size(112, 34);
        btnCapNhat.TabIndex = 3;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = true;
        btnCapNhat.Click += btnCapNhat_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(465, 40);
        label2.Name = "label2";
        label2.Size = new Size(183, 25);
        label2.TabIndex = 4;
        label2.Text = "Danh sách các ước số";
        // 
        // lst_UocSo
        // 
        lst_UocSo.FormattingEnabled = true;
        lst_UocSo.Location = new Point(468, 68);
        lst_UocSo.Name = "lst_UocSo";
        lst_UocSo.Size = new Size(274, 129);
        lst_UocSo.TabIndex = 5;
        // 
        // btnTongUocSo
        // 
        btnTongUocSo.Location = new Point(468, 230);
        btnTongUocSo.Name = "btnTongUocSo";
        btnTongUocSo.Size = new Size(274, 34);
        btnTongUocSo.TabIndex = 6;
        btnTongUocSo.Text = "Tổng các ước số";
        btnTongUocSo.UseVisualStyleBackColor = true;
        btnTongUocSo.Click += btnTongUocSo_Click;
        // 
        // btnDemUocSoChan
        // 
        btnDemUocSoChan.Location = new Point(465, 285);
        btnDemUocSoChan.Name = "btnDemUocSoChan";
        btnDemUocSoChan.Size = new Size(277, 34);
        btnDemUocSoChan.TabIndex = 7;
        btnDemUocSoChan.Text = "Số lượng các ước số chẵn";
        btnDemUocSoChan.UseVisualStyleBackColor = true;
        btnDemUocSoChan.Click += btnDemUocSoChan_Click;
        // 
        // btnDemUocSoNguyenTo
        // 
        btnDemUocSoNguyenTo.Location = new Point(465, 340);
        btnDemUocSoNguyenTo.Name = "btnDemUocSoNguyenTo";
        btnDemUocSoNguyenTo.Size = new Size(277, 34);
        btnDemUocSoNguyenTo.TabIndex = 8;
        btnDemUocSoNguyenTo.Text = "Số lượng các ước số nguyên tố";
        btnDemUocSoNguyenTo.UseVisualStyleBackColor = true;
        btnDemUocSoNguyenTo.Click += btnDemUocSoNguyenTo_Click;
        // 
        // btnThoat
        // 
        btnThoat.Location = new Point(248, 340);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(112, 34);
        btnThoat.TabIndex = 9;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += btnThoat_Click;
        // 
        // cbo_So
        // 
        cbo_So.FormattingEnabled = true;
        cbo_So.Location = new Point(62, 120);
        cbo_So.Name = "cbo_So";
        cbo_So.Size = new Size(182, 33);
        cbo_So.TabIndex = 10;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(cbo_So);
        Controls.Add(btnThoat);
        Controls.Add(btnDemUocSoNguyenTo);
        Controls.Add(btnDemUocSoChan);
        Controls.Add(btnTongUocSo);
        Controls.Add(lst_UocSo);
        Controls.Add(label2);
        Controls.Add(btnCapNhat);
        Controls.Add(txt_NhapSo);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txt_NhapSo;
    private Button btnCapNhat;
    private Label label2;
    private ListBox lst_UocSo;
    private Button btnTongUocSo;
    private Button btnDemUocSoChan;
    private Button btnDemUocSoNguyenTo;
    private Button btnThoat;
    private ComboBox cbo_So;
}
