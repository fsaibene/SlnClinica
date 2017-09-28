using System;

namespace Entidades
{
    namespace BaseEntity {
        public abstract class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public Persona(string nombre, string apellido, string email, DateTime nacimiento)
            {
                Nombre = nombre;
                Apellido = apellido;
                Email = email;
                FechaNacimiento = nacimiento;
            }
        }
    }
}
