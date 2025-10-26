using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroOcorrencias.Models
{
    public class AgenteResponsavelController
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