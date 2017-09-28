using Entidades;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ServiceMedicos
    {
        private List<Medico> listaMedicos;
        private List<string> especialidades;
        private List<string> nombres;

        public ServiceMedicos()
        {
            listaMedicos = new List<Medico>();
            especialidades = new List<string>();
            especialidades.Add("Todos");
            nombres = new List<string>();
        }
        public List<Medico> Listar()
        {
            return listaMedicos;
        }

        public List<Medico> Listar(string criterio)
        {
            List<Medico> filtredList = new List<Medico>();

            listaMedicos.ForEach(m => {
                if (m.Especialidad == criterio)
                {
                    filtredList.Add(m);
                }
            });
            return filtredList;
        }

        public List<string> Especialidades()
        {
            return especialidades;
        }
        public List<string> Nombres()
        {
            return nombres;
        }

        public void Agregar(string especialidad, string nombre, string apellido, string email, DateTime nacimiento)
        {
            listaMedicos.Add(new Medico(especialidad, nombre, apellido, email, nacimiento));
            especialidades.Add(especialidad);
            nombres.Add(nombre + " " + apellido);
        }

        public void Clear()
        {
            listaMedicos.Clear();
            especialidades.Clear();
            nombres.Clear();
        }
    }
}
