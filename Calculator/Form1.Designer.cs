namespace Calculator
{
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
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            label3 = new Label();
            txtKetQua = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 111);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 157);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(300, 104);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(210, 27);
            txtSo1.TabIndex = 2;
            txtSo1.KeyPress += txtSo1_KeyPress;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(300, 150);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(210, 27);
            txtSo2.TabIndex = 3;
            txtSo2.KeyPress += txtSo2_KeyPress;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(281, 208);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(39, 29);
            btnCong.TabIndex = 4;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(326, 208);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(39, 29);
            btnTru.TabIndex = 5;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(371, 208);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(39, 29);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(416, 208);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(39, 29);
            btnChia.TabIndex = 7;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(461, 208);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(63, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Del";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 266);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(300, 259);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(210, 27);
            txtKetQua.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(371, 310);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(55, 29);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(txtKetQua);
            Controls.Add(label3);
            Controls.Add(btnXoa);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Label label3;
        private TextBox txtKetQua;
        private Button btnExit;
    }
}