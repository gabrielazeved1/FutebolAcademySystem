using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrabalhoFinal
{
    
    class Pessoa
    {
        
        protected string nome ;
        protected string cpf;
        protected string rg;
        protected string sexo;
        protected int idade;
        protected string telefone;
        protected int end_num;
        protected string end_cep;
        protected string mae;
        protected string pai;
        protected string entrada_clube;
        protected string modalidade;
     
        public Pessoa(string nome, string cpf, string sexo, int idade, string telefone, int ed_num, string end_cep, string mae, string pai, string entrada_clube, string modalidade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.sexo = sexo;
            this.idade = idade;
            this.telefone = telefone;
            this.end_num = ed_num;
            this.end_cep = end_cep;
            this.mae = mae;
            this.pai = pai;
            this.entrada_clube = entrada_clube;
            this.modalidade = modalidade;
        }
       
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int End_num { get => end_num; set => end_num = value; }
        public string End_cep { get => end_cep; set => end_cep = value; }
        public string Mae { get => mae; set => mae = value; }
        public string Pai { get => pai; set => pai = value; }
        public string Entrada_clube { get => entrada_clube; set => entrada_clube = value; }
        public string Modalidade { get => modalidade; set => modalidade = value; }
    }
}
