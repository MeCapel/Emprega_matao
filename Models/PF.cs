using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace projeto_integrador.Models
{
    public class PF
    {
        public int PFId { get; set; }
        public string Nome { get; set; }

        [Column(TypeName="Date")]
        public DateTime Nascimento { get; set; }

        public char Sexo { get; set; }
    }
}
