using ClasesEstacionamiento.Models;
using System;


namespace ClasesEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona persona = new Persona("Jose","gonzalez");
            persona.Id = 1;
            Persona persona1 = new Persona() { Apellido = "P", Nombre = "Juan", Dni = 123456 };
            Cliente cliente = new Cliente("Juan", "Perez", 12345677);
            Console.WriteLine(String.Format("{0},{1},{2}", persona1.Nombre , persona1.Apellido , persona1.Dni));
            Console.WriteLine(String.Format("{0},{1},{2}", persona.Nombre, persona.Apellido, persona.Dni));
            Console.ReadKey();


        }
        //Aqui explicamos como usar las variables navegacionales
        public void Test ()
        {
            Direccion direccion = new Direccion();
            int personaId = direccion.PersonaId;
            Persona persona = getPersonaId(personaId);
            String nombre = direccion.Persona.Nombre;

        }
        private Persona getPersonaId(int personaId)
        {
            Persona persona2 = new Persona();
            return (persona2);  // Le pido a alguien o a la base de datos o a quien sea
        }
    }
}
