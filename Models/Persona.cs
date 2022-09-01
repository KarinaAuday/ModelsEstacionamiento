using ClasesEstacionamiento.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        [Range (1,99999999,ErrorMessage ="Dni Invalido")]
        public int Dni { get => dni; set => dni = value; }

        private int dni;

        [StringLength (50, MinimumLength = 2 ,ErrorMessage = MsjeError.MinMaxString)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = MsjeError.Requerido)]

        public string Nombre { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


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
        public Direccion direccion { get; set; }

        public List<Telefono> telefonos { get; set; } 
    }
   
}
