namespace NNLTCSharpBaiTapVeNha.Bai3;

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
        trv_DanhBa = new TreeView();
        label1 = new Label();
        label2 = new Label();
        txt_FirstName = new TextBox();
        txt_LastName = new TextBox();
        btn_Add = new Button();
        btn_Exit = new Button();
        SuspendLayout();
        // 
        // trv_DanhBa
        // 
        trv_DanhBa.Location = new Point(35, 37);
        trv_DanhBa.Name = "trv_DanhBa";
        trv_DanhBa.Size = new Size(182, 199);
        trv_DanhBa.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(327, 37);
        label1.Name = "label1";
        label1.Size = new Size(97, 25);
        label1.TabIndex = 1;
        label1.Text = "First Name";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(327, 87);
        label2.Name = "label2";
        label2.Size = new Size(95, 25);
        label2.TabIndex = 2;
        label2.Text = "Last Name";
        // 
        // txt_FirstName
        // 
        txt_FirstName.Location = new Point(430, 31);
        txt_FirstName.Name = "txt_FirstName";
        txt_FirstName.Size = new Size(150, 31);
        txt_FirstName.TabIndex = 3;
        // 
        // txt_LastName
        // 
        txt_LastName.Location = new Point(430, 81);
        txt_LastName.Name = "txt_LastName";
        txt_LastName.Size = new Size(150, 31);
        txt_LastName.TabIndex = 4;
        // 
        // btn_Add
        // 
        btn_Add.Location = new Point(468, 142);
        btn_Add.Name = "btn_Add";
        btn_Add.Size = new Size(112, 34);
        btn_Add.TabIndex = 5;
        btn_Add.Text = "Add";
        btn_Add.UseVisualStyleBackColor = true;
        btn_Add.Click += btn_Add_Click;
        // 
        // btn_Exit
        // 
        btn_Exit.Location = new Point(522, 202);
        btn_Exit.Name = "btn_Exit";
        btn_Exit.Size = new Size(112, 34);
        btn_Exit.TabIndex = 6;
        btn_Exit.Text = "Exit";
        btn_Exit.UseVisualStyleBackColor = true;
        btn_Exit.Click += btn_Exit_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btn_Exit);
        Controls.Add(btn_Add);
        Controls.Add(txt_LastName);
        Controls.Add(txt_FirstName);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(trv_DanhBa);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TreeView trv_DanhBa;
    private Label label1;
    private Label label2;
    private TextBox txt_FirstName;
    private TextBox txt_LastName;
    private Button btn_Add;
    private Button btn_Exit;
}
