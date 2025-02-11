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
    public partial class EditaTreinador_ : Form
    {
        public EditaTreinador_()
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

            string stringSql = $"SELECT*FROM treinador";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvTreinador.DataSource = dt;
                }
            }

            objConnection.Close();
        }

        
        private void btAtualizarTreinador_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    foreach (DataGridViewRow row in dgvTreinador.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int idTreinador = Convert.ToInt32(row.Cells["id_treinador"].Value);
                            string novoNome = row.Cells["nome_treinador"].Value.ToString();
                            string novoCPF = row.Cells["cpf_treinador"].Value.ToString();
                            string novoSexo = row.Cells["sexo_treinador"].Value.ToString();
                            int novaIdade = Convert.ToInt32(row.Cells["idade_treinador"].Value);
                            string novoTelefone = row.Cells["telefone_treinador"].Value.ToString();
                            int novoEndNum = Convert.ToInt32(row.Cells["end_num_treinador"].Value);
                            string novoEndCEP = row.Cells["end_cep_treinador"].Value.ToString();
                            decimal novoSalario = Convert.ToDecimal(row.Cells["salario_treinador"].Value);

                            string updateSql = @"UPDATE treinador 
                                 SET nome_treinador = @novoNome, 
                                     cpf_treinador = @novoCPF, 
                                     sexo_treinador = @novoSexo, 
                                     idade_treinador = @novaIdade, 
                                     telefone_treinador = @novoTelefone, 
                                     end_num_treinador = @novoEndNum, 
                                     end_cep_treinador = @novoEndCEP,
                                     salario_treinador = @novoSalario
                                 WHERE id_treinador = @idTreinador";

                            using (NpgsqlCommand command = new NpgsqlCommand(updateSql, objConnection))
                            {
                                command.Parameters.AddWithValue("@novoNome", novoNome);
                                command.Parameters.AddWithValue("@novoCPF", novoCPF);
                                command.Parameters.AddWithValue("@novoSexo", novoSexo);
                                command.Parameters.AddWithValue("@novaIdade", novaIdade);
                                command.Parameters.AddWithValue("@novoTelefone", novoTelefone);
                                command.Parameters.AddWithValue("@novoEndNum", novoEndNum);
                                command.Parameters.AddWithValue("@novoEndCEP", novoEndCEP);
                                command.Parameters.AddWithValue("@novoSalario", novoSalario);
                                command.Parameters.AddWithValue("@idTreinador", idTreinador);

                                int rowsAffected = command.ExecuteNonQuery();

                                
                            }
                        }
                    }

                    // Recarrega os dados do DataGridView após a atualização
                    CarregarDadosTreinadores();

                    MessageBox.Show("Dados atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados dos treinadores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para carregar os dados dos treinadores no DataGridView
        private void CarregarDadosTreinadores()
        {
            ConexaoString objConexaoString = new ConexaoString();
            string contemConexaoString = objConexaoString.Conectar();

            using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
            {
                objConnection.Open();

                string query = "SELECT * FROM treinador";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, objConnection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTreinador.DataSource = dt;
                }
            }
        }


                private void btExcluirTreinador_Click(object sender, EventArgs e)
        {
            
                if (dgvTreinador.SelectedRows.Count > 0)
                {
                    // Obtenha o nome da pessoa selecionada
                    string nomePessoaSelecionada = dgvTreinador.SelectedRows[0].Cells["nome_treinador"].Value.ToString();

                    // Crie uma conexão com o banco de dados
                    ConexaoString objConexaoString = new ConexaoString();
                    string contemConexaoString = objConexaoString.Conectar();
                    NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString);

                    try
                    {
                        // Abra a conexão com o banco de dados
                        objConnection.Open();

                        // Construa a consulta SQL para excluir a linha com base no nome da pessoa
                        string deleteSql = $"DELETE FROM treinador WHERE nome_treinador = '{nomePessoaSelecionada}'";

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


       
    }
}
