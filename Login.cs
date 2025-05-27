using MaterialSkin.Controls;

namespace Projeto_PROGVIII
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            Register NewRegisterInstance = new Register();
            NewRegisterInstance.Show();
            this.Hide();
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPasswordInput_Click(object sender, EventArgs e)
        {

        }
    }
}
