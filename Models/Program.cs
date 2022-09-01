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
    }
}
