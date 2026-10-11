namespace NNLTCSharpADOBaiTapTaiLop.Bai1;

partial class QLMonHoc
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
        txtMaMH = new TextBox();
        txtTenMH = new TextBox();
        btnThem = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 34);
        label1.Name = "label1";
        label1.Size = new Size(68, 25);
        label1.TabIndex = 0;
        label1.Text = "Mã mh";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(41, 84);
        label2.Name = "label2";
        label2.Size = new Size(69, 25);
        label2.TabIndex = 1;
        label2.Text = "Tên mh";
        // 
        // txtMaMH
        // 
        txtMaMH.Location = new Point(133, 28);
        txtMaMH.Name = "txtMaMH";
        txtMaMH.Size = new Size(150, 31);
        txtMaMH.TabIndex = 2;
        // 
        // txtTenMH
        // 
        txtTenMH.Location = new Point(133, 78);
        txtTenMH.Name = "txtTenMH";
        txtTenMH.Size = new Size(150, 31);
        txtTenMH.TabIndex = 3;
        // 
        // btnThem
        // 
        btnThem.Location = new Point(41, 159);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(112, 34);
        btnThem.TabIndex = 4;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(202, 159);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(112, 34);
        btnXoa.TabIndex = 5;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnSua
        // 
        btnSua.Location = new Point(373, 159);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(112, 34);
        btnSua.TabIndex = 6;
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
        Controls.Add(txtTenMH);
        Controls.Add(txtMaMH);
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
    private TextBox txtMaMH;
    private TextBox txtTenMH;
    private Button btnThem;
    private Button btnXoa;
    private Button btnSua;
}
