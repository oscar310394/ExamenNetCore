using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            Matricula = new HashSet<Matricula>();
        }

        public int Idprofesor { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
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
        public int? Estado { get; set; }

        public ICollection<Matricula> Matricula { get; set; }
    }
}
