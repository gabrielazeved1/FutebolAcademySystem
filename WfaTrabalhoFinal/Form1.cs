using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WfaTrabalhoFinal
{
    public partial class Form1 : Form
    {
        CadastroAlunoForm c1;
        CadastroTreinadorForms c2;
        CadastroModalidadeForms c3;
        EditaTreinador_ A1;
        EditarAluno A2;
        EditaModalidade A3;
        RelatorioForms R1;
        

        public Form1()
        {
            InitializeComponent();
        }
        //cadastro
        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (c1 != null)
                return;

            if(c2 != null)
            {
                c2.Close();
                c2 = null;
            }

           c1 =  new CadastroAlunoForm();
           c1.Show();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (c2 != null)
                return;
            if (c1 != null)
            {
                c1.Close(); 
                c1 = null;
            }
            c2 = new CadastroTreinadorForms();
            c2.Show();
        }
        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c3 = new CadastroModalidadeForms();
            c3.Show();
        }

        private void relatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R1 = new RelatorioForms();
            R1.Show();
        }

       


       
//editar
        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (A1 != null)
            
                return;
            if (A2 != null)
            {
                A2.Close();
                A2 = null;
            }

            

            A1 = new EditaTreinador_();
            A1.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (A2 != null)
                return;
            if (A1!=null)
            {
                A1.Close();
                A1 = null;
            }
            A2 = new EditarAluno();
            A2.Show();

        }
        private void modalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            A3 = new EditaModalidade();
            A3.Show();
        }






        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (rbTreinador.Checked == true)
            {
                
                
                    ConexaoString objConexaoString = new ConexaoString();
                    string contemConexaoString = objConexaoString.Conectar();
                    NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString);
                    objConnection.Open();



                string stringSql = $"SELECT*FROM treinador WHERE cpf_treinador = '{mtbPesquisaCpf.Text}'";
               // string stringSql = $"SELECT cpf_treinador FROM treinador";
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridViewtabeladados.DataSource = dt;

                                if (dt.Rows.Count == 0)
                                {
                                    MessageBox.Show("Treinador não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        objConnection.Close();
                   
               
            
                
            }

            if (rbAluno.Checked == true)
            {
                ConexaoString objConexaoString = new ConexaoString();
                string contemConexaoString = objConexaoString.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexaoString);
                objConnection.Open();

                string stringSql = $"SELECT*FROM aluno WHERE cpf_aluno = '{mtbPesquisaCpf.Text}'";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(stringSql, objConnection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridViewtabeladados.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Aluno não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                objConnection.Close();
            }
        }

       
    }
}
