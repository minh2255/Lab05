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
        components = new System.ComponentModel.Container();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        txtHoTen = new TextBox();
        txtMaSV = new TextBox();
        rdoNam = new RadioButton();
        rdoNu = new RadioButton();
        chkAnh = new CheckBox();
        chkPhap = new CheckBox();
        chkHoa = new CheckBox();
        contextMenuStrip1 = new ContextMenuStrip(components);
        cboDanToc = new ComboBox();
        btnThem = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        listView1 = new ListView();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(39, 29);
        label1.Name = "label1";
        label1.Size = new Size(90, 25);
        label1.TabIndex = 0;
        label1.Text = "Họ và Tên";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(39, 81);
        label2.Name = "label2";
        label2.Size = new Size(111, 25);
        label2.TabIndex = 1;
        label2.Text = "Mã sinh viên";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(39, 135);
        label3.Name = "label3";
        label3.Size = new Size(78, 25);
        label3.TabIndex = 2;
        label3.Text = "Giới tính";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(39, 193);
        label4.Name = "label4";
        label4.Size = new Size(97, 25);
        label4.TabIndex = 3;
        label4.Text = "Ngoại ngữ";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(39, 257);
        label5.Name = "label5";
        label5.Size = new Size(74, 25);
        label5.TabIndex = 4;
        label5.Text = "Dân tộc";
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(165, 23);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(150, 31);
        txtHoTen.TabIndex = 5;
        // 
        // txtMaSV
        // 
        txtMaSV.Location = new Point(165, 75);
        txtMaSV.Name = "txtMaSV";
        txtMaSV.Size = new Size(150, 31);
        txtMaSV.TabIndex = 6;
        // 
        // rdoNam
        // 
        rdoNam.AutoSize = true;
        rdoNam.Location = new Point(165, 131);
        rdoNam.Name = "rdoNam";
        rdoNam.Size = new Size(75, 29);
        rdoNam.TabIndex = 7;
        rdoNam.TabStop = true;
        rdoNam.Text = "Nam";
        rdoNam.UseVisualStyleBackColor = true;
        // 
        // rdoNu
        // 
        rdoNu.AutoSize = true;
        rdoNu.Location = new Point(289, 133);
        rdoNu.Name = "rdoNu";
        rdoNu.Size = new Size(61, 29);
        rdoNu.TabIndex = 8;
        rdoNu.TabStop = true;
        rdoNu.Text = "Nữ";
        rdoNu.UseVisualStyleBackColor = true;
        // 
        // chkAnh
        // 
        chkAnh.AutoSize = true;
        chkAnh.Location = new Point(165, 192);
        chkAnh.Name = "chkAnh";
        chkAnh.Size = new Size(70, 29);
        chkAnh.TabIndex = 9;
        chkAnh.Text = "Anh";
        chkAnh.UseVisualStyleBackColor = true;
        // 
        // chkPhap
        // 
        chkPhap.AutoSize = true;
        chkPhap.Location = new Point(289, 192);
        chkPhap.Name = "chkPhap";
        chkPhap.Size = new Size(78, 29);
        chkPhap.TabIndex = 10;
        chkPhap.Text = "Pháp";
        chkPhap.UseVisualStyleBackColor = true;
        // 
        // chkHoa
        // 
        chkHoa.AutoSize = true;
        chkHoa.Location = new Point(411, 192);
        chkHoa.Name = "chkHoa";
        chkHoa.Size = new Size(71, 29);
        chkHoa.TabIndex = 11;
        chkHoa.Text = "Hoa";
        chkHoa.UseVisualStyleBackColor = true;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(24, 24);
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // cboDanToc
        // 
        cboDanToc.FormattingEnabled = true;
        cboDanToc.Location = new Point(121, 249);
        cboDanToc.Name = "cboDanToc";
        cboDanToc.Size = new Size(182, 33);
        cboDanToc.TabIndex = 13;
        // 
        // btnThem
        // 
        btnThem.Location = new Point(39, 460);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(112, 34);
        btnThem.TabIndex = 14;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        // 
        // btnXoa
        // 
        btnXoa.Location = new Point(203, 460);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(112, 34);
        btnXoa.TabIndex = 15;
        btnXoa.Text = "Xóa ";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnSua
        // 
        btnSua.Location = new Point(370, 460);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(112, 34);
        btnSua.TabIndex = 16;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        // 
        // listView1
        // 
        listView1.Location = new Point(39, 301);
        listView1.Name = "listView1";
        listView1.Size = new Size(443, 146);
        listView1.TabIndex = 17;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 504);
        Controls.Add(listView1);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnThem);
        Controls.Add(cboDanToc);
        Controls.Add(chkHoa);
        Controls.Add(chkPhap);
        Controls.Add(chkAnh);
        Controls.Add(rdoNu);
        Controls.Add(rdoNam);
        Controls.Add(txtMaSV);
        Controls.Add(txtHoTen);
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
    private TextBox txtHoTen;
    private TextBox txtMaSV;
    private RadioButton rdoNam;
    private RadioButton rdoNu;
    private CheckBox chkAnh;
    private CheckBox chkPhap;
    private CheckBox chkHoa;
    private ContextMenuStrip contextMenuStrip1;
    private ComboBox cboDanToc;
    private Button btnThem;
    private Button btnXoa;
    private Button btnSua;
    private ListView listView1;
}
