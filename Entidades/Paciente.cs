using Entidades.BaseEntity;
using System;

namespace Entidades
{
    public class Paciente : Persona
    {
        public string NroHistoriaClinica { get; set; }

        public Paciente(string nroHistoriaClinica, string nombre, string apellido, string email, DateTime nacimiento) : base(nombre, apellido, email, nacimiento)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        } 
    }
}
