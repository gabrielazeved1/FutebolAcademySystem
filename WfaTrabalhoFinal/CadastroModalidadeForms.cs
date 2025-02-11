using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaTrabalhoFinal
{
    public partial class CadastroModalidadeForms : Form
    {
        public CadastroModalidadeForms()
        {
            InitializeComponent();
        }

        
        public void limpartextbox()
        {
            
            tbINivelTecnico.Text = string.Empty;
            tbNomeModalidade.Text = string.Empty;
            tbMensalidade.Text = string.Empty;
        }

        private void btCadastrarModalidade_Click(object sender, EventArgs e)
        {
            bool continueLoop = true;
            do
            {
                try
                {
                    // Obtenha a mensalidade da entrada do usuário
                    if (!double.TryParse(tbMensalidade.Text, out double mensalidade))
                    {
                        MessageBox.Show("Preencha corretamente todos os dados pedidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        continue;
                    }

                    Modalidade objModalidade = new Modalidade(tbNomeModalidade.Text, tbINivelTecnico.Text, mensalidade);

                    if (string.IsNullOrWhiteSpace(objModalidade.Nome_modalidade) || string.IsNullOrWhiteSpace(objModalidade.Nivel_tecnico))
                    {
                        MessageBox.Show("Preencha corretamente todos os dados pedidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        continueLoop = false;
                    }
                    else
                    {
                        ConexaoString objConexaoString = new ConexaoString();
                        string contemConexaoString = objConexaoString.Conectar();

                        using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                        {
                            objConnection.Open();

                            string stringSql = $"INSERT INTO modalidade(nome_modalidade, nivel_tecnico, mensalidade_modalidade) VALUES ('{objModalidade.Nome_modalidade}','{objModalidade.Nivel_tecnico}', {objModalidade.Mensalidade_modalidade.ToString(System.Globalization.CultureInfo.InvariantCulture)})";

                            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                            {
                                npgsqlCommand.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Modalidade Cadastrada com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpartextbox();
                        continueLoop = false;
                    }
                }
                catch (Exception ex)
                {
                    continueLoop = false;
                    MessageBox.Show("Ocorreu um erro ao cadastrar a modalidade: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (continueLoop);
        }


        private void btCancelarModalidade_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
