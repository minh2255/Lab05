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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        txtSoTK = new TextBox();
        txtTenKH = new TextBox();
        txtDiaChi = new TextBox();
        txtSoTien = new TextBox();
        txtTongTien = new TextBox();
        btnThem = new Button();
        btnLuu = new Button();
        btnXoa = new Button();
        btnThoat = new Button();
        listView1 = new ListView();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(251, 9);
        label1.Name = "label1";
        label1.Size = new Size(280, 25);
        label1.TabIndex = 0;
        label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(27, 54);
        label2.Name = "label2";
        label2.Size = new Size(111, 25);
        label2.TabIndex = 1;
        label2.Text = "Số tài khoản";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(27, 103);
        label3.Name = "label3";
        label3.Size = new Size(134, 25);
        label3.TabIndex = 2;
        label3.Text = "Tên khách hàng";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(27, 158);
        label4.Name = "label4";
        label4.Size = new Size(161, 25);
        label4.TabIndex = 3;
        label4.Text = "Địa chỉ khách hàng";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(27, 210);
        label5.Name = "label5";
        label5.Size = new Size(194, 25);
        label5.TabIndex = 4;
        label5.Text = "Số tiền trong tài khoản";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(465, 495);
        label6.Name = "label6";
        label6.Size = new Size(87, 25);
        label6.TabIndex = 5;
        label6.Text = "Tổng tiền";
        // 
        // txtSoTK
        // 
        txtSoTK.Location = new Point(237, 48);
        txtSoTK.Name = "txtSoTK";
        txtSoTK.Size = new Size(294, 31);
        txtSoTK.TabIndex = 6;
        // 
        // txtTenKH
        // 
        txtTenKH.Location = new Point(237, 97);
        txtTenKH.Name = "txtTenKH";
        txtTenKH.Size = new Size(294, 31);
        txtTenKH.TabIndex = 7;
        // 
        // txtDiaChi
        // 
        txtDiaChi.Location = new Point(237, 155);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new Size(294, 31);
        txtDiaChi.TabIndex = 8;
        // 
        // txtSoTien
        // 
        txtSoTien.Location = new Point(237, 204);
        txtSoTien.Name = "txtSoTien";
        txtSoTien.Size = new Size(294, 31);
        txtSoTien.TabIndex = 9;
        // 
        // txtTongTien
        // 
        txtTongTien.Location = new Point(558, 486);
        txtTongTien.Name = "txtTongTien";
        txtTongTien.Size = new Size(220, 31);
        txtTongTien.TabIndex = 10;
        // 
        // btnThem
        // 
        btnThem.Location = new Point(135, 267);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(112, 34);
        btnThem.TabIndex = 11;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnLuu
        // 
        btnLuu.Location = new Point(300, 267);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(112, 34);
        btnLuu.TabIndex = 12;
        btnLuu.Text = "Lưu";
        btnLuu.UseVisualStyleBackColor = true;
        btnLuu.Click += btnLuu_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(465, 267);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(112, 34);
        btnXoa.TabIndex = 13;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnThoat
        // 
        btnThoat.Location = new Point(645, 267);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(112, 34);
        btnThoat.TabIndex = 14;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += btnThoat_Click;
        // 
        // listView1
        // 
        listView1.Location = new Point(27, 320);
        listView1.Name = "listView1";
        listView1.Size = new Size(730, 146);
        listView1.TabIndex = 15;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 529);
        Controls.Add(listView1);
        Controls.Add(btnThoat);
        Controls.Add(btnXoa);
        Controls.Add(btnLuu);
        Controls.Add(btnThem);
        Controls.Add(txtTongTien);
        Controls.Add(txtSoTien);
        Controls.Add(txtDiaChi);
        Controls.Add(txtTenKH);
        Controls.Add(txtSoTK);
        Controls.Add(label6);
        Controls.Add(label5);
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
    private Label label5;
    private Label label6;
    private TextBox txtSoTK;
    private TextBox txtTenKH;
    private TextBox txtDiaChi;
    private TextBox txtSoTien;
    private TextBox txtTongTien;
    private Button btnThem;
    private Button btnLuu;
    private Button btnXoa;
    private Button btnThoat;
    private ListView listView1;
}
