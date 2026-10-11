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
        components = new System.ComponentModel.Container();
        lblTime = new Label();
        btnBatDau = new Button();
        timer1 = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // lblTime
        // 
        lblTime.AutoSize = true;
        lblTime.Location = new Point(339, 68);
        lblTime.Name = "lblTime";
        lblTime.Size = new Size(56, 25);
        lblTime.TabIndex = 0;
        lblTime.Text = "30:00";
        // 
        // btnBatDau
        // 
        btnBatDau.Location = new Point(313, 110);
        btnBatDau.Name = "btnBatDau";
        btnBatDau.Size = new Size(112, 34);
        btnBatDau.TabIndex = 1;
        btnBatDau.Text = "Bắt đầu";
        btnBatDau.UseVisualStyleBackColor = true;
        btnBatDau.Click += btnBatDau_Click;
        // 
        // timer1
        // 
        timer1.Interval = 1000;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnBatDau);
        Controls.Add(lblTime);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTime;
    private Button btnBatDau;
    private System.Windows.Forms.Timer timer1;
}
