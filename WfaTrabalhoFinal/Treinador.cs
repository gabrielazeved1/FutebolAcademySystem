using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrabalhoFinal
{
    class Treinador : Pessoa
    {
        
        
        private double salario;
        
        public Treinador(string nome, string cpf, string sexo, int idade, string telefone, int ed_num, string mae, string pai, string end_cep, string entrada_clube, string modalidade, double salario)
            : base(nome, cpf, sexo, idade, telefone, ed_num, end_cep, entrada_clube, mae, pai, modalidade)
        {
            this.Salario = salario;
        }


        

        public double Salario { get => salario; set => salario = value; }
       


       
        public void CalcularSalario()
        {
            if (modalidade == "iniciante")
            {
                salario = 1950.00;
            }
            else if (modalidade == "intermediario")
            {
                salario = 2350.00;
            }
            else if (modalidade == "avancado")
            {
                salario = 2950.00;
            }
        }



    }
}
