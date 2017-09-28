using Entidades.BaseEntity;
using System;

namespace Entidades
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }

        public Medico(string especialidad, string nombre, string apellido, string email, DateTime nacimiento) : base(nombre, apellido, email, nacimiento)
        {
            Especialidad = especialidad;
        }
    }
}
