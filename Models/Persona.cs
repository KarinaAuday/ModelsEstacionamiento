using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesEstacionamiento
{
    public class Persona
       {
        public Persona()
        {

        }

        public Persona (string nombre, string apellido)
        {
            Apellido = apellido;
            Nombre = nombre;

        }

       
        public int Id { get; set; }

        public Guid Id2 { get; set; }


        public int Dni { get => dni; set => dni = value; }

        private int dni;


        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string NombreCompleto
        {
              get
            {
                return $"{Apellido}, {Nombre}";
            }
        }

        #region Dirytelefono
        public Direccion Direccion { get; set; }

        public List<Telefono> Telefonos { get; set; }

        #endregion
    }
}
