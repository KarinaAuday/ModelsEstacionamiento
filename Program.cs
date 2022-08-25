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
            Persona persona1 = new Persona() { Apellido = "Perez", Nombre = "Juan", Dni = 123456 };

        }
    }
}
