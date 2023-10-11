namespace WinFormWithCheckboxRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoThich_Click(object sender, EventArgs e)
        {
            string str = "";
            if (checkBox1.Checked == true)
            {
                str = checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text + "\n";
            }
            if (checkBox5.Checked == true)
            {
                str = str + checkBox5.Text + "\n";
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Sở thích của bạn là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có sở thích nào bạn chọn!");
            }
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            string str = "";
            if (radioButton1.Checked == true)
            {
                str = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                str = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                str = radioButton3.Text;
            }
            if (radioButton4.Checked == true)
            {
                str = radioButton4.Text;
            }
            if (radioButton5.Checked == true)
            {
                str = radioButton5.Text;
            }
            if (str.Length >0)
            {
                MessageBox.Show("Màu bạn thích là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có màu nào được bạn chọn!");
            }
        }
    }
}