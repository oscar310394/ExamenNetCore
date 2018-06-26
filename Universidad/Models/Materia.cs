using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Universidad.Models
{
    public partial class Materia
    {
        public Materia()
        {
            Matricula = new HashSet<Matricula>();
        }

        public int Idmateria { get; set; }
        [Required(ErrorMessage = "El nombre de la materia es requerido")]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        public int? Estado { get; set; }
        public double Precio { get; set; }



        public ICollection<Matricula> Matricula { get; set; }
    }
}
