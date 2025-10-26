using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroOcorrencias.Models
{
    [Table("OCORRENCIA_DOTNET")]
    public class Ocorrencia
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Display(Name = "Título da Ocorrência")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Data de Registro")]
        public DateTime DataRegistro { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Número da Ocorrência")]
        public int NumeroOcorrencia { get; set; }

        [Required]
        [Display(Name = "Código da Ocorrência")]
        public int CodigoOcorrencia { get; set; }

        [Required]
        [Display(Name = "Local da Ocorrência")]
        public string LocalOcorrencia { get; set; }

        [Display(Name = "Status Concluído")]
        public bool StatusConcluido { get; set; }

        [Required]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }
    }
}