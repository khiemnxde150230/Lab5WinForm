namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtSo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSo1.Text) + Convert.ToInt32(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSo1.Text) - Convert.ToInt32(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtSo1.Text) * Convert.ToInt32(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtSo1.Text) / Convert.ToDouble(txtSo2.Text);
            txtKetQua.Text = result.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this program?", "Ask the user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}