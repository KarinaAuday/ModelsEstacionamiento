using System.ComponentModel.DataAnnotations;

namespace ClasesEstacionamiento
{
    public class Direccion
    {
        public int Id { get; set; }
        public  string Calle { get; set; }

        public int Numero { get; set; }

        public int CodPostal { get; set; }

        [Required]
        public int PersonaId { get; set; }


    }
}