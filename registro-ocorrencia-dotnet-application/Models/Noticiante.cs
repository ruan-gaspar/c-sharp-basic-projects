using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroOcorrencias.Models
{
    [Table("NOTICIANTE_DOTNET")]
    public class Noticiante
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Range(18, 120)]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }
    }
}