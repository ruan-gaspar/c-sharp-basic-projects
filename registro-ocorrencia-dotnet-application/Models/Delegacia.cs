using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroOcorrencias.Models
{
    [Table("DELEGACIA_DOTNET")]
    public class Delegacia
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Display(Name = "Título da Delegacia")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Delegado Responsável")]
        public string DelegadoResponsavel { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}