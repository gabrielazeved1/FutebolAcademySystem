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
    public partial class EditaModalidade : Form
    {
        public EditaModalidade()
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

            string stringSql = $"SELECT*FROM modalidade";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvModalidade.DataSource = dt;
                }
            }

            objConnection.Close();
        }
        
        private void btExcluirModalidade_Click(object sender, EventArgs e)
        {
            if (dgvModalidade.SelectedRows.Count > 0)
            {
                // Obtenha o nome da pessoa selecionada
                string nomePessoaSelecionada = dgvModalidade.SelectedRows[0].Cells["nome_modalidade"].Value.ToString();

                // Crie uma conexão com o banco de dados
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();
                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString);

                try
                {
                    // Abra a conexão com o banco de dados
                    objConnection.Open();

                    // Construa a consulta SQL para excluir a linha com base no nome da pessoa
                    string deleteSql = $"DELETE FROM modalidade WHERE nome_modalidade = '{nomePessoaSelecionada}'";

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
        
        private void btAtualizarModalidade_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    foreach (DataGridViewRow row in dgvModalidade.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int idModalidade = Convert.ToInt32(row.Cells["id_modalidade"].Value);
                            string novoNome = row.Cells["nome_modalidade"].Value.ToString();
                            string novoNivelTecnico = row.Cells["nivel_tecnico"].Value.ToString();

                            string updateSql = @"UPDATE modalidade 
                                         SET nome_modalidade = @novoNome, 
                                             nivel_tecnico = @novoNivelTecnico
                                         WHERE id_modalidade = @idModalidade";

                            using (NpgsqlCommand command = new NpgsqlCommand(updateSql, objConnection))
                            {
                                command.Parameters.AddWithValue("@novoNome", novoNome);
                                command.Parameters.AddWithValue("@novoNivelTecnico", novoNivelTecnico);
                                command.Parameters.AddWithValue("@idModalidade", idModalidade);

                                int rowsAffected = command.ExecuteNonQuery();

                                
                            }
                        }
                    }

                    // Recarrega os dados do DataGridView após a atualização
                    CarregarDadosModalidade();

                    MessageBox.Show("Dados atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados das modalidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDadosModalidade()
        {
            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    string query = "SELECT * FROM modalidade";

                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, objConnection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvModalidade.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados das modalidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
