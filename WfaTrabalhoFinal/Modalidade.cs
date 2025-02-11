using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrabalhoFinal
{
    class Modalidade 
    {
        private string nome_modalidade;
        private string nivel_tecnico;
        private double mensalidade_modalidade;
        

        public Modalidade(string nome_modalidade, string nivel_tecnico,double mensalidade_modalidade)
        {
            this.nome_modalidade = nome_modalidade;
            this.nivel_tecnico = nivel_tecnico;
            this.mensalidade_modalidade = mensalidade_modalidade;
        }

        public string Nome_modalidade { get => nome_modalidade; set => nome_modalidade = value; }
        public string Nivel_tecnico { get => nivel_tecnico; set => nivel_tecnico = value; }
        public double Mensalidade_modalidade { get => mensalidade_modalidade; set => mensalidade_modalidade = value; }
    }
}
