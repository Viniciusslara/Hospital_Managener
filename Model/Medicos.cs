using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClinica.Model
{
    internal class Medicos
    {

        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string especialidade { get; set; }
        public string cidade { get; set; }
        public int cpf { get; set; }
        public int ambulatorio { get; set; }

        public Medicos(int id, string nome, int idade, string especialidade, string cidade, int cpf, int ambulatorio)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.especialidade = especialidade;
            this.cidade = cidade;
            this.cpf = cpf;
            this.ambulatorio = ambulatorio;
        }

    }
}
