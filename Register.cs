using MaterialSkin.Controls;

namespace Projeto_PROGVIII
{
    public partial class Register : MaterialForm
    {
        public Login LoginForm = new Login();
        public Register()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string nome = RegisterNameInput.Text;
            string email = RegisterEmailInput.Text;
            string cpf = RegisterCPFInput.Text;
            string password = RegisterPasswordInput.Text;
            string confirmPassword = RegisterConfirmPasswordInput.Text;
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            if (nome == "" || email == "" || password == "" || confirmPassword == "" || cpf == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Cliente newClienteInstance = new Cliente();
                newClienteInstance.nome = nome;
                newClienteInstance.email = email;
                newClienteInstance.cpf = cpf;
                newClienteInstance.password = password;
                newClienteInstance.confirmpassword = confirmPassword;
                newClienteInstance.RegistrarCliente();
                this.Hide();
                LoginForm.Show();
            }

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
