using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClinica.Model
{
    internal class Paciente
    {

        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public int cpf { get; set; }
        public string cidade { get; set; }
        public string doenca { get; set; }

        public Paciente(int id, string nome, int idade, string cidade,int cpf, string doenca)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.doenca = doenca;
            this.cidade = cidade;
        }

    }
}
