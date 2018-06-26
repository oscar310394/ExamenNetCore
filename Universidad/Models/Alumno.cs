using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            Matricula = new HashSet<Matricula>();
        }

        public int Idalumno { get; set; }
        [Required(ErrorMessage = "El nombre del Alumno es requerido")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El primer apellido es requerido")]
        [StringLength(50)]
        [Display(Name = "Primer Apellido")]
        public string Apellido1 { get; set; }
        [Required(ErrorMessage = "El segundo apellido es requerido")]
        [StringLength(50)]
        [Display(Name = "Segundo Apellido")]
        public string Apellido2 { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public ICollection<Matricula> Matricula { get; set; }
    }
}
