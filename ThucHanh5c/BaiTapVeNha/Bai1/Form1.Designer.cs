namespace NNLTCSharpBaiTapVeNha.Bai1;

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
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        lst_TuAnh = new ListBox();
        label1 = new Label();
        label2 = new Label();
        txt_NghiaViet = new TextBox();
        btn_Thoat = new Button();
        cbo_TuAnh = new ComboBox();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new Point(27, 24);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(725, 347);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(cbo_TuAnh);
        tabPage1.Controls.Add(txt_NghiaViet);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(lst_TuAnh);
        tabPage1.Location = new Point(4, 34);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(717, 309);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "ANH-VIỆT";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 34);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(717, 309);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "VIỆT-ANH";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // lst_TuAnh
        // 
        lst_TuAnh.FormattingEnabled = true;
        lst_TuAnh.Location = new Point(25, 98);
        lst_TuAnh.Name = "lst_TuAnh";
        lst_TuAnh.Size = new Size(182, 204);
        lst_TuAnh.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(25, 15);
        label1.Name = "label1";
        label1.Size = new Size(92, 25);
        label1.TabIndex = 1;
        label1.Text = "Tiếng Anh";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(391, 15);
        label2.Name = "label2";
        label2.Size = new Size(88, 25);
        label2.TabIndex = 2;
        label2.Text = "Tiếng việt";
        // 
        // txt_NghiaViet
        // 
        txt_NghiaViet.Location = new Point(391, 52);
        txt_NghiaViet.Name = "txt_NghiaViet";
        txt_NghiaViet.Size = new Size(265, 31);
        txt_NghiaViet.TabIndex = 3;
        // 
        // btn_Thoat
        // 
        btn_Thoat.Location = new Point(636, 389);
        btn_Thoat.Name = "btn_Thoat";
        btn_Thoat.Size = new Size(112, 34);
        btn_Thoat.TabIndex = 4;
        btn_Thoat.Text = "Thoát";
        btn_Thoat.UseVisualStyleBackColor = true;
        btn_Thoat.Click += btn_Thoat_Click;
        // 
        // cbo_TuAnh
        // 
        cbo_TuAnh.FormattingEnabled = true;
        cbo_TuAnh.Location = new Point(25, 50);
        cbo_TuAnh.Name = "cbo_TuAnh";
        cbo_TuAnh.Size = new Size(182, 33);
        cbo_TuAnh.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btn_Thoat);
        Controls.Add(tabControl1);
        Name = "Form1";
        Text = "Form1";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private Button btn_Thoat;
    private TextBox txt_NghiaViet;
    private Label label2;
    private Label label1;
    private ListBox lst_TuAnh;
    private TabPage tabPage2;
    private ComboBox cbo_TuAnh;
}
