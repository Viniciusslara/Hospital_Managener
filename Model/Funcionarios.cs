using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClinica.Model
{
    internal class Funcionarios
    {

        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public int cpf { get; set; }
        public string cidade { get; set; }
        public int salario { get; set; }
        public string cargo { get; set; }

        public Funcionarios(int id, string nome, int idade, int cpf, string cidade, int salario, string cargo)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.cidade = cidade;
            this.salario = salario;
            this.cargo = cargo;
        }

    }
}
