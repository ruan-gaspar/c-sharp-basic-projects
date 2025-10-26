using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroOcorrencias.Models
{
    [Table("AGENTE_RESPONSAVEL_DOTNET")]
    public class AgenteResponsavel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O cargo é obrigatório.")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }
    }
}