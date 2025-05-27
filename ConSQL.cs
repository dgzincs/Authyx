using System.Data.SQLite;
using System.Data.SqlClient;

namespace Projeto_PROGVIII
{
    internal class ConSQL
    {
        private string caminhoArquivo = Path.Combine(Application.StartupPath, "DB", "Clientes.db");
        private string caminhoBanco => $"Data Source={caminhoArquivo};Version=3;";

        public void TestarConexao()
        {
            using (SQLiteConnection conn = new SQLiteConnection(caminhoBanco))
            {
                try
                {
                    if (!File.Exists(caminhoArquivo))
                    {
                        Directory.CreateDirectory(Path.Combine(Application.StartupPath, "DB"));
                        SQLiteConnection.CreateFile(caminhoArquivo);
                    }
                    conn.Open();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }

        public void RegistrarCliente(string nome, string cpf, string email, string password)
        {
            this.TestarConexao();

            using (SQLiteConnection conn = new SQLiteConnection(this.caminhoBanco))
            {
                try
                {
                    conn.Open();

                    string checkTbQuery = @"
                        CREATE TABLE IF NOT EXISTS TB_Clientes (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            nome TEXT NOT NULL,
                            email TEXT NOT NULL,
                            password TEXT NOT NULL,
                            cpf TEXT NOT NULL
                        );";

                    using (SQLiteCommand checkTb = new SQLiteCommand(checkTbQuery, conn))
                    {
                        checkTb.ExecuteNonQuery();
                    }

                    string checkQuery = "SELECT 1 FROM TB_Clientes WHERE email = @Email OR cpf = @Cpf LIMIT 1";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        checkCmd.Parameters.AddWithValue("@Cpf", cpf);

                        var existe = checkCmd.ExecuteScalar();

                        if (existe != null)
                        {
                            MessageBox.Show("Já existe um usuário com esse email ou CPF.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO TB_Clientes (nome, email, password, cpf) VALUES (@nome, @email, @password, @cpf)";
                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@nome", nome);
                        insertCmd.Parameters.AddWithValue("@email", email);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@cpf", cpf);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ou executar operação: " + ex.Message);
                }
            }
        }

        public void AcessarCliente(string email, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(caminhoBanco))
            {
                this.TestarConexao();
                try
                {
                    conn.Open();

                    string query = "SELECT EXISTS (SELECT 1 FROM TB_Clientes WHERE Email = @email LIMIT 1)";
                    using (var checkCmd = new SQLiteCommand(query, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", email);
                        long existe = (long)checkCmd.ExecuteScalar();

                        if (existe == 1)
                        {
                            checkCmd.Parameters.Clear();
                            checkCmd.CommandText = "SELECT EXISTS (SELECT 1 FROM TB_Clientes WHERE Email = @email AND Password = @password LIMIT 1)";
                            checkCmd.Parameters.AddWithValue("@email", email);
                            checkCmd.Parameters.AddWithValue("@password", password);
                            existe = (long)checkCmd.ExecuteScalar();

                            if (existe == 1)
                            {
                                MessageBox.Show("Login bem sucedido.", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
