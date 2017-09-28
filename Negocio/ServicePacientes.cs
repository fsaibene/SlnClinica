using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicePacientes
    {
        private List<Paciente> listaPacientes;

        public ServicePacientes()
        {
            listaPacientes = new List<Paciente>();
        }
        public List<Paciente> Listar()
        {
            return listaPacientes;
        }

        public List<Paciente> Listar(string criterio)
        {
            return null;
        }

        public void Agregar(Paciente paciente)
        {
            listaPacientes.Add(paciente);
        }

    }
}
