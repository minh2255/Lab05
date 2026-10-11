namespace NNLTCSharpBaiTapNangCao.Bai1;

partial class frmMain
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
        menuStrip1 = new MenuStrip();
        cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
        kếtThúcToolStripMenuItem = new ToolStripMenuItem();
        mnuNhapHocVien = new ToolStripMenuItem();
        mnuChuyenSangLopB = new ToolStripMenuItem();
        mnuChuyenSangLopA = new ToolStripMenuItem();
        mnuXoaHocVien = new ToolStripMenuItem();
        lstLopA = new ListBox();
        lstLopB = new ListBox();
        label1 = new Label();
        label2 = new Label();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(24, 24);
        menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, kếtThúcToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 33);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // cậpNhậtToolStripMenuItem
        // 
        cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNhapHocVien, mnuChuyenSangLopB, mnuChuyenSangLopA, mnuXoaHocVien });
        cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
        cậpNhậtToolStripMenuItem.Size = new Size(99, 29);
        cậpNhậtToolStripMenuItem.Text = "Cập nhật";
        // 
        // kếtThúcToolStripMenuItem
        // 
        kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
        kếtThúcToolStripMenuItem.Size = new Size(92, 29);
        kếtThúcToolStripMenuItem.Text = "Kết thúc";
        // 
        // mnuNhapHocVien
        // 
        mnuNhapHocVien.Name = "mnuNhapHocVien";
        mnuNhapHocVien.Size = new Size(270, 34);
        mnuNhapHocVien.Text = "Nhập học viên mới";
        mnuNhapHocVien.Click += mnuNhapHocVien_Click;
        // 
        // mnuChuyenSangLopB
        // 
        mnuChuyenSangLopB.Name = "mnuChuyenSangLopB";
        mnuChuyenSangLopB.Size = new Size(270, 34);
        mnuChuyenSangLopB.Text = "Chuyển sang lớp B";
        // 
        // mnuChuyenSangLopA
        // 
        mnuChuyenSangLopA.Name = "mnuChuyenSangLopA";
        mnuChuyenSangLopA.Size = new Size(270, 34);
        mnuChuyenSangLopA.Text = "Chuyển sang lớp A";
        // 
        // mnuXoaHocVien
        // 
        mnuXoaHocVien.Name = "mnuXoaHocVien";
        mnuXoaHocVien.Size = new Size(270, 34);
        mnuXoaHocVien.Text = "Xóa học viên";
        // 
        // lstLopA
        // 
        lstLopA.FormattingEnabled = true;
        lstLopA.Location = new Point(27, 96);
        lstLopA.Name = "lstLopA";
        lstLopA.SelectionMode = SelectionMode.MultiExtended;
        lstLopA.Size = new Size(180, 129);
        lstLopA.TabIndex = 1;
        // 
        // lstLopB
        // 
        lstLopB.FormattingEnabled = true;
        lstLopB.Location = new Point(260, 97);
        lstLopB.Name = "lstLopB";
        lstLopB.SelectionMode = SelectionMode.MultiExtended;
        lstLopB.Size = new Size(180, 129);
        lstLopB.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(27, 57);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 3;
        label1.Text = "Lớp A";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(260, 57);
        label2.Name = "label2";
        label2.Size = new Size(57, 25);
        label2.TabIndex = 4;
        label2.Text = "Lớp B";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(lstLopB);
        Controls.Add(lstLopA);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem cậpNhậtToolStripMenuItem;
    private ToolStripMenuItem mnuNhapHocVien;
    private ToolStripMenuItem mnuChuyenSangLopB;
    private ToolStripMenuItem mnuChuyenSangLopA;
    private ToolStripMenuItem mnuXoaHocVien;
    private ToolStripMenuItem kếtThúcToolStripMenuItem;
    private ListBox lstLopA;
    private ListBox lstLopB;
    private Label label1;
    private Label label2;
}
