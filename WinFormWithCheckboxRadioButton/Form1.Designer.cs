namespace WinFormWithCheckboxRadioButton
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
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnSoThich = new Button();
            btnMau = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(80, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sở thích của bạn";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 157);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(94, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Đi du lịch";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 127);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(110, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Đi mua sắm";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 97);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(120, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Chơi thể thao";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 67);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Xem phim";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Nghe nhạc";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(459, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 250);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Màu bạn thích";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(16, 157);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(55, 24);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Tím";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(16, 127);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Hồng";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 97);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Vàng";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Trắng";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Đỏ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSoThich
            // 
            btnSoThich.Location = new Point(116, 359);
            btnSoThich.Name = "btnSoThich";
            btnSoThich.Size = new Size(234, 29);
            btnSoThich.TabIndex = 2;
            btnSoThich.Text = "Sở thích của bạn";
            btnSoThich.UseVisualStyleBackColor = true;
            btnSoThich.Click += btnSoThich_Click;
            // 
            // btnMau
            // 
            btnMau.Location = new Point(506, 359);
            btnMau.Name = "btnMau";
            btnMau.Size = new Size(234, 29);
            btnMau.TabIndex = 3;
            btnMau.Text = "Màu bạn thích";
            btnMau.UseVisualStyleBackColor = true;
            btnMau.Click += btnMau_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 513);
            Controls.Add(btnMau);
            Controls.Add(btnSoThich);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnSoThich;
        private Button btnMau;
    }
}