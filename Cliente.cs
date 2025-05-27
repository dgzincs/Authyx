namespace Projeto_PROGVIII
{
    internal class Cliente
    {
        public string nome;
        public string email;
        public string password;
        public string confirmpassword;
        public string cpf;

        public bool validarCPF()
        {
            if (this.cpf.Length != 11 || !this.cpf.All(char.IsDigit))
            {
                return false;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (this.cpf[i] - '0') * (10 - i);
            int digito1 = soma % 11;
            digito1 = digito1 < 2 ? 0 : 11 - digito1;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (this.cpf[i] - '0') * (11 - i);
            int digito2 = soma % 11;
            digito2 = digito2 < 2 ? 0 : 11 - digito2;

            return cpf[9] - '0' == digito1 && this.cpf[10] - '0' == digito2;
        }

        public bool validarSenha()
        {
            if (!(this.password == this.confirmpassword))
            {
                MessageBox.Show("As senhas não coincidem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((password.Length < 8))
            {
                MessageBox.Show("A senha precisa ter no mínimo 8 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void RegistrarCliente()
        {

            if (!this.validarCPF())
            {
                MessageBox.Show("CPF Inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.validarSenha())
            {
                return;
            }

            ConSQL newConSQLInstance = new ConSQL();
            newConSQLInstance.RegistrarCliente(this.nome, this.cpf, this.email, this.password);

        }

        public void AcessarCliente()
        {
            if (this.email == "" || this.password == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ConSQL newConSQLInstance = new ConSQL();
            newConSQLInstance.AcessarCliente(this.email, this.password);

        }
    }
}
