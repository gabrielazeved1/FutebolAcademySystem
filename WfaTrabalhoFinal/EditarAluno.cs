using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaTrabalhoFinal
{
    public partial class EditarAluno : Form
    {
        public EditarAluno()
        {
            InitializeComponent();
            Mostrar();
        }
        
        private void Mostrar()
        {
            ConexaoString objConexaoString = new ConexaoString();
            string contemConexaoString = objConexaoString.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString);
            objConnection.Open();

            string stringSql = $"SELECT*FROM aluno";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvAlunos.DataSource = dt;
                }
            }

            objConnection.Close();
        }
       
        private void btExcluirAluno_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count > 0)
            {
                // Obtenha o nome da pessoa selecionada
                string nomePessoaSelecionada = dgvAlunos.SelectedRows[0].Cells["nome_aluno"].Value.ToString();

                // Crie uma conexão com o banco de dados
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();
                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString);

                try
                {
                    // Abra a conexão com o banco de dados
                    objConnection.Open();

                    // Construa a consulta SQL para excluir a linha com base no nome da pessoa
                    string deleteSql = $"DELETE FROM aluno WHERE nome_aluno = '{nomePessoaSelecionada}'";

                    // Crie um comando para executar a consulta SQL
                    using (NpgsqlCommand command = new NpgsqlCommand(deleteSql, objConnection))
                    {
                        // Execute o comando
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verifique se alguma linha foi excluída
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("A linha foi excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha foi excluída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao excluir a linha:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Feche a conexão com o banco de dados
                    objConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        


        
        private void btAtualizarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    foreach (DataGridViewRow row in dgvAlunos.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int idAluno = Convert.ToInt32(row.Cells["id_aluno"].Value);
                            string novoNome = row.Cells["nome_aluno"].Value.ToString();
                            string novaModalidade = row.Cells["modalidade_aluno"].Value.ToString();
                            double novaMensalidade = Convert.ToDouble(row.Cells["mensalidade"].Value);
                            int novoEndNum = Convert.ToInt32(row.Cells["end_num_aluno"].Value);
                            string novoEndCEP = row.Cells["end_cep_aluno"].Value.ToString();
                            int novaIdade = Convert.ToInt32(row.Cells["idade_aluno"].Value); // Adicionando idade_aluno

                            string updateSql = @"UPDATE aluno 
                                 SET nome_aluno = @novoNome, 
                                     modalidade_aluno = @novaModalidade, 
                                     mensalidade = @novaMensalidade,
                                     end_num_aluno = @novoEndNum,
                                     end_cep_aluno = @novoEndCEP,
                                     idade_aluno = @novaIdade
                                 WHERE id_aluno = @idAluno";

                            using (NpgsqlCommand command = new NpgsqlCommand(updateSql, objConnection))
                            {
                                command.Parameters.AddWithValue("@novoNome", novoNome);
                                command.Parameters.AddWithValue("@novaModalidade", novaModalidade);
                                command.Parameters.AddWithValue("@novaMensalidade", novaMensalidade);
                                command.Parameters.AddWithValue("@novoEndNum", novoEndNum);
                                command.Parameters.AddWithValue("@novoEndCEP", novoEndCEP);
                                command.Parameters.AddWithValue("@novaIdade", novaIdade); // Adicionando idade_aluno
                                command.Parameters.AddWithValue("@idAluno", idAluno);

                                int rowsAffected = command.ExecuteNonQuery();

                                
                            }
                        }
                    }

                    // Recarrega os dados do DataGridView após a atualização
                    CarregarDadosAlunos();

                    MessageBox.Show("Dados atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados dos alunos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para carregar os dados dos alunos no DataGridView
        private void CarregarDadosAlunos()
        {
            ConexaoString objConexaoString = new ConexaoString();
            string contemConexaoString = objConexaoString.Conectar();

            using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
            {
                objConnection.Open();

                string query = "SELECT * FROM aluno";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, objConnection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAlunos.DataSource = dt;
                }
            }
        }

      






    }
}
