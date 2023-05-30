using System.ComponentModel.DataAnnotations;
using EjercicioNet.DataAnnotationsPersonalizados;

namespace EjercicioNet.Models.DataModels
{
    public class Curso:BaseEntity
    {
        [Required, MaxLength]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [Required]
        public string DescripcionLarga { get; set; } = string.Empty;
        [Required]
        public string PublicoObjetivo { get; set; } = string.Empty;
        [Required]
        public string Objetivos { get; set; } = string.Empty;
        [Required]
        public string Requisitos { get; set; } = string.Empty;
        public Enumerado.NivelEnum Nivel { get; set; }


    }
}
