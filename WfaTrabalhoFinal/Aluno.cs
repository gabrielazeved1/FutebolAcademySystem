using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrabalhoFinal
{
    class Aluno : Pessoa
    {
       
       
       private double mensalidade;

        
        public Aluno (string nome, string cpf, string sexo, int idade, string telefone, int ed_num, string end_cep, string mae, string pai, string entrada_clube, string modalidade,double mensalidade): base(nome,cpf,sexo,idade,telefone,ed_num,end_cep,mae,pai,entrada_clube,modalidade)
        {
           //ta faltando tecnico.
            this.entrada_clube = entrada_clube;
            this.modalidade = modalidade;
        }
       
       
        public double Mensalidade { get => mensalidade; set => mensalidade = value; }
        
        public void CalcularMensalidade()
        {
            if (modalidade == "iniciante")
            {
                mensalidade = 100.00;
            }
            else if (modalidade == "intermediario")
            {
                mensalidade = 150.00;
            }
            else if (modalidade == "avancado")
            {
                mensalidade = 200.00;
            }
        }


    }

    

}
