using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace WfaTrabalhoFinal
{
    public partial class CadastroTreinadorForms : Form
    {
        public CadastroTreinadorForms()
        {
            InitializeComponent();
            CarregarTreinador();

        }
        

        
        private void btCancelarTreinador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação Cancelada!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpartextbox();
        }
        

        public void limpartextbox()
        {
            tbT_Nome.Text = string.Empty;
            tbT_NCasa.Text = string.Empty;
            cbT_Salario.Text = string.Empty;
            cbT_Sexo.Text = string.Empty;
            cbT_Modalidade.Text = string.Empty;
            mtbT_CPF.Text = string.Empty;
            mtbT_Telefone.Text = string.Empty;
            mtbT_Ceep.Text = string.Empty;
            mtbEntradaTreinador.Text = string.Empty;
        }
        
        private void btCadastrarTreinador_Click(object sender, EventArgs e)
        {
            bool continueLoop = true;
            do
            {
                try
                {
                    Treinador objTreinador = new Treinador(
                        tbT_Nome.Text,
                        mtbT_CPF.Text,
                        cbT_Sexo.Text,
                        int.Parse(mtbTIdade.Text),
                        mtbT_Telefone.Text,
                        int.Parse(tbT_NCasa.Text),
                        tbnomemaeT.Text,
                        tbnomePaiT
                        .Text,
                        mtbT_Ceep.Text,
                        mtbEntradaTreinador.Text, // Data de entrada como string
                        cbT_Modalidade.Text,
                        double.Parse(cbT_Salario.Text) // Salário convertido para double
                    );

                    ConexaoString objConexaoString = new ConexaoString();
                    string contemConexaoString = objConexaoString.Conectar();

                    using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                    {
                        objConnection.Open();

                        string stringSql = "INSERT INTO treinador(nome_treinador, cpf_treinador, sexo_treinador, idade_treinador, telefone_treinador, " +
                                           "end_num_treinador, end_cep_treinador, entrada_clube, mae_treinador, pai_treinador, modalidade_treinador, salario_treinador) " +
                                           "VALUES (@nome, @cpf, @sexo, @idade, @telefone, @endNum, @endCep, @entradaClube, @mae, @pai, @modalidade, @salario)";

                        using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                        {
                            npgsqlCommand.Parameters.AddWithValue("@nome", objTreinador.Nome);
                            npgsqlCommand.Parameters.AddWithValue("@cpf", objTreinador.Cpf);
                            npgsqlCommand.Parameters.AddWithValue("@sexo", objTreinador.Sexo);
                            npgsqlCommand.Parameters.AddWithValue("@idade", objTreinador.Idade);
                            npgsqlCommand.Parameters.AddWithValue("@telefone", objTreinador.Telefone);
                            npgsqlCommand.Parameters.AddWithValue("@endNum", objTreinador.End_num);
                            npgsqlCommand.Parameters.AddWithValue("@endCep", objTreinador.End_cep);
                            npgsqlCommand.Parameters.AddWithValue("@entradaClube", objTreinador.Entrada_clube); // Data de entrada
                            npgsqlCommand.Parameters.AddWithValue("@mae", objTreinador.Mae); // Mãe do treinador
                            npgsqlCommand.Parameters.AddWithValue("@pai", objTreinador.Pai); // Pai do treinador
                            npgsqlCommand.Parameters.AddWithValue("@modalidade", objTreinador.Modalidade);
                            npgsqlCommand.Parameters.AddWithValue("@salario", objTreinador.Salario);

                            npgsqlCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Treinador cadastrado com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpartextbox();
                        continueLoop = false;
                    }
                }
                catch (FormatException)
                {
                    continueLoop = false;
                    MessageBox.Show("Preencha corretamente todos os dados pedidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (NpgsqlException ex)
                {
                    continueLoop = false;
                    MessageBox.Show("Erro ao cadastrar treinador: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (continueLoop);
        }
        



        private void CarregarTreinador()
        {
            try
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                using (NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString))
                {
                    objConnection.Open();

                    // Exibir mensagem de sucesso se a conexão for bem-sucedida
                   

                    string stringSql = "SELECT MIN(id_modalidade) AS id_modalidade, nome_modalidade FROM modalidade GROUP BY nome_modalidade";
                    NpgsqlCommand comandoModalidades = new NpgsqlCommand(stringSql, objConnection);
                    DataSet dataSetModalidades = new DataSet();
                    NpgsqlDataAdapter dataAdapterModalidades = new NpgsqlDataAdapter(comandoModalidades);
                    dataAdapterModalidades.Fill(dataSetModalidades);
                    cbT_Modalidade.DisplayMember = "nome_modalidade";
                    cbT_Modalidade.ValueMember = "id_modalidade";
                    cbT_Modalidade.DataSource = dataSetModalidades.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as modalidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
