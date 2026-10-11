namespace NNLTCSharpADOBaiTapNangCao.Bai2;

partial class QLDiem
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
        txtMaSV = new TextBox();
        txtMaMH = new TextBox();
        txtDiem = new TextBox();
        btnThem = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(27, 36);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 0;
        label1.Text = "Mã sv";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(27, 89);
        label2.Name = "label2";
        label2.Size = new Size(68, 25);
        label2.TabIndex = 1;
        label2.Text = "Mã mh";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(27, 142);
        label3.Name = "label3";
        label3.Size = new Size(54, 25);
        label3.TabIndex = 2;
        label3.Text = "Điểm";
        // 
        // txtMaSV
        // 
        txtMaSV.Location = new Point(128, 30);
        txtMaSV.Name = "txtMaSV";
        txtMaSV.Size = new Size(150, 31);
        txtMaSV.TabIndex = 3;
        // 
        // txtMaMH
        // 
        txtMaMH.Location = new Point(128, 83);
        txtMaMH.Name = "txtMaMH";
        txtMaMH.Size = new Size(150, 31);
        txtMaMH.TabIndex = 4;
        // 
        // txtDiem
        // 
        txtDiem.Location = new Point(128, 136);
        txtDiem.Name = "txtDiem";
        txtDiem.Size = new Size(150, 31);
        txtDiem.TabIndex = 5;
        // 
        // btnThem
        // 
        btnThem.Location = new Point(27, 214);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(112, 34);
        btnThem.TabIndex = 6;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(193, 214);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(112, 34);
        btnXoa.TabIndex = 7;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnSua
        // 
        btnSua.Location = new Point(370, 214);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(112, 34);
        btnSua.TabIndex = 8;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnThem);
        Controls.Add(txtDiem);
        Controls.Add(txtMaMH);
        Controls.Add(txtMaSV);
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
    private TextBox txtMaSV;
    private TextBox txtMaMH;
    private TextBox txtDiem;
    private Button btnThem;
    private Button btnXoa;
    private Button btnSua;
}
