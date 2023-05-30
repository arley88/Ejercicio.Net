using System.ComponentModel.DataAnnotations;

namespace EjercicioNet.DataAnnotationsPersonalizados
{
    public class Enumerado
    {
        public enum NivelEnum
        {
            [Display(Name = "Básico")]
            Basico,

            [Display(Name = "Intermedio")]
            Intermedio,

            [Display(Name = "Avanzado")]
            Avanzado,
        }
    }
}
