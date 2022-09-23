using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClinica.Model
{
    internal class Ambulatorio
    {

        public int id { get; set; }
        public int andar { get; set; }
        public int capacidade { get; set; }

        public Ambulatorio(int id, int andar, int capacidade)
        {
            this.id = id;
            this.andar = andar;
            this.capacidade = capacidade;
        }

    }
}
