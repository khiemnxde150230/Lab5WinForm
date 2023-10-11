namespace FormInput
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this program?", "Ask the user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Dispose();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Your name: " + txtName.Text);
            }
            else
            {
                MessageBox.Show("Input required");
            }
        }

        private void FormInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                txtName.Text = "Hello FPT University";
            }
        }

        private void FormInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("You just click the left mouse");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("You just click the right mouse");
            }
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