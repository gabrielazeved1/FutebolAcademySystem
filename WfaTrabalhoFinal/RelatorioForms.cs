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
    public partial class RelatorioForms : Form
    {
        public RelatorioForms()
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

            string stringSql = $"SELECT nome_aluno, modalidade_aluno FROM aluno";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dgvRelatorio.DataSource = dt;
                }
            }

            objConnection.Close();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            MessageBox.Show("Dados atualizados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CarregarDados()
        {
            ConexaoString objConexaoString = new ConexaoString();
            string contemConexaoString = objConexaoString.Conectar();

            using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
            {
                objConnection.Open();

                string query = $"SELECT nome_aluno, modalidade_aluno FROM aluno";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, objConnection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRelatorio.DataSource = dt;
                }
            }
        }
    }
}
