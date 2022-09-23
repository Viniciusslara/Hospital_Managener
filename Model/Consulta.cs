using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClinica.Model
{
    internal class Consulta
    {

        public DateOnly data { get; set; }
        public TimeOnly hora { get; set; }

        public Paciente paciente { get; set; }
        public Medicos medico { get; set; }

        public Consulta(DateOnly data, TimeOnly hora,int idPaciente, int idMedico)
        {
            this.data = data;
            this. hora = hora;
            paciente.id = idPaciente;
            medico.id = idMedico;
        }
    }
}