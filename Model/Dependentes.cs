using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClinica.Model
{
    internal class Dependentes
    {
        public Dependentes(int id, string nome, DateOnly nasc, int funcionario)
        {
            this.id = id;
            this.nome = nome;
            this.nasc = nasc;
            this.funcionario = funcionario;
        }

        public int id { get; set; }
        public string nome { get; set; }
        public DateOnly nasc { get; set; }

        public int funcionario { get; set; }

    }
}
