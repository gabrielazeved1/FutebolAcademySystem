using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WfaTrabalhoFinal
{
    public partial class CadastroAlunoForm : Form
    {
        public CadastroAlunoForm()
        {
            InitializeComponent();
        }
        private void CadastroAlunoForm_Load(object sender, EventArgs e)
        {
            // Carregar os valores dos treinadores do banco de dados
            CarregarAlunos();
        }






        private void lblCpf_Click(object sender, EventArgs e)
        {

        }



        private void lblInformEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblModalidade_Click(object sender, EventArgs e)
        {

        }

        private void lblDEClube_Click(object sender, EventArgs e)
        {

        }

        private void lblNCasa_Click(object sender, EventArgs e)
        {

        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void lblTreinador_Click(object sender, EventArgs e)
        {

        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void lblInformEscolinha_Click(object sender, EventArgs e)
        {

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void limpartextbox()
        {
            tbA_Nome.Text = string.Empty;
            tbA_Mae.Text = string.Empty;
            tbA_NCasa.Text = string.Empty;
            tbA_Idade.Text = string.Empty;

            tbA_Pai.Text = string.Empty;
            cbA_Modalidade.Text = string.Empty;
            cbA_Sexo.Text = string.Empty;
            cbA_Treinador.Text = string.Empty;
            mtbA_Cpf.Text = string.Empty;
            mtbA_Telefone.Text = string.Empty;
            mtbCep.Text = string.Empty;
            mtbDataEntrada.Text = string.Empty;

        }
       
        private void btCadastrarAlunos_Click(object sender, EventArgs e)
        {
            //Aluno ObjAluno = new Aluno(mtbA_Cpf.Text,tbA_Idade,tbA_Mae);
            /*
            ConexaoString stringConexao = new ConexaoString();
            string strconexao = stringConexao.StrConexao;
            NpgsqlConnection con = new NpgsqlConnection(strconexao);
            con.Open();
            */
            bool continueLoop = true;
            do
            {
                try
                {
                    Aluno objAluno = new Aluno(tbA_Nome.Text,
             mtbA_Cpf.Text,
             cbA_Sexo.Text,
             int.Parse(tbA_Idade.Text),
             mtbA_Telefone.Text,
             int.Parse(tbA_NCasa.Text),
             mtbCep.Text,
             tbA_Mae.Text,
             tbA_Pai.Text,
             mtbDataEntrada.Text, // Converter para string
             cbA_Modalidade.Text,
             double.Parse(cbMensalidade.Text));

                    // Estabelecer conexão com o banco de dados
                    ConexaoString objConexaoString = new ConexaoString();
                    string contemConexaoString = objConexaoString.Conectar();

                    using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                    {
                        objConnection.Open();

                        // Comando SQL para inserir os dados do aluno
                        string stringSql = "INSERT INTO aluno(nome_aluno, cpf_aluno, sexo_aluno, idade_aluno, telefone_aluno, " +
                            "end_num_aluno, end_cep_aluno, mae_aluno, pai_aluno, entrada_clube, modalidade_aluno, " +
                            "mensalidade) VALUES (@nome, @cpf, @sexo, @idade, @telefone, @endNum, " +
                            "@endCep, @mae, @pai, @entradaClube, @modalidade, @mensalidade)";

                        using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                        {
                            npgsqlCommand.Parameters.AddWithValue("@nome", objAluno.Nome);
                            npgsqlCommand.Parameters.AddWithValue("@cpf", objAluno.Cpf);
                            npgsqlCommand.Parameters.AddWithValue("@sexo", objAluno.Sexo);
                            npgsqlCommand.Parameters.AddWithValue("@idade", objAluno.Idade);
                            npgsqlCommand.Parameters.AddWithValue("@telefone", objAluno.Telefone);
                            npgsqlCommand.Parameters.AddWithValue("@endNum", objAluno.End_num);
                            npgsqlCommand.Parameters.AddWithValue("@endCep", objAluno.End_cep);
                            npgsqlCommand.Parameters.AddWithValue("@mae", objAluno.Mae);
                            npgsqlCommand.Parameters.AddWithValue("@pai", objAluno.Pai);
                            npgsqlCommand.Parameters.AddWithValue("@entradaClube", objAluno.Entrada_clube); // Valor do tipo string
                            npgsqlCommand.Parameters.AddWithValue("@modalidade", objAluno.Modalidade);
                            npgsqlCommand.Parameters.AddWithValue("@mensalidade", objAluno.Mensalidade);

                            npgsqlCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Aluno Cadastrado com Sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpartextbox();
                        continueLoop = false;
                    }

                }
                catch (FormatException formatException)
                {
                    continueLoop = false;
                    MessageBox.Show("Preencha corretamente todos os dados pedidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (NpgsqlException npgsqlException)
                {
                    continueLoop = false;
                    MessageBox.Show("Erro ao cadastrar aluno: " + npgsqlException.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (continueLoop);


        }
       
        private void btCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação Cancelada!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpartextbox();
        }



       
        private void CarregarAlunos()
        {
            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    // Consulta SQL para buscar os treinadores
                    string stringsql = "SELECT id_treinador, nome_treinador FROM treinador";

                    // Comando para executar a consulta
                    NpgsqlCommand salvartreinador = new NpgsqlCommand(stringsql, objConnection);

                    // DataSet para armazenar os resultados da consulta
                    DataSet dt = new DataSet();

                    // Adaptador de dados para preencher o DataSet
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(salvartreinador);
                    da.Fill(dt);

                    // Limpar itens existentes no ComboBox
                    cbA_Treinador.Items.Clear();

                    // Configurar o ComboBox para exibir os nomes dos treinadores
                    cbA_Treinador.DisplayMember = "nome_treinador";
                    cbA_Treinador.ValueMember = "id_treinador";
                    cbA_Treinador.DataSource = dt.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os treinadores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    string stringSql = "SELECT MIN(id_modalidade) AS id_modalidade, nome_modalidade FROM modalidade GROUP BY nome_modalidade";
                    NpgsqlCommand comandoModalidades = new NpgsqlCommand(stringSql, objConnection);
                    DataSet dataSetModalidades = new DataSet();
                    NpgsqlDataAdapter dataAdapterModalidades = new NpgsqlDataAdapter(comandoModalidades);
                    dataAdapterModalidades.Fill(dataSetModalidades);
                    cbA_Modalidade.DisplayMember = "nome_modalidade";
                    cbA_Modalidade.ValueMember = "id_modalidade";
                    cbA_Modalidade.DataSource = dataSetModalidades.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as modalidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    string stringSql = "SELECT MIN(id_modalidade) AS id_modalidade, mensalidade_modalidade FROM modalidade GROUP BY mensalidade_modalidade";
                    NpgsqlCommand comandoMensalidade = new NpgsqlCommand(stringSql, objConnection);
                    DataSet dataSetMensalidade = new DataSet();
                    NpgsqlDataAdapter dataAdapterMensalidade = new NpgsqlDataAdapter(comandoMensalidade);
                    dataAdapterMensalidade.Fill(dataSetMensalidade);
                    cbMensalidade.DisplayMember = "mensalidade_modalidade";
                    cbMensalidade.ValueMember = "id_modalidade";
                    cbMensalidade.DataSource = dataSetMensalidade.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as modalidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}