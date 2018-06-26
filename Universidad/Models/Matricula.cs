using System;
using System.Collections.Generic;

namespace Universidad.Models
{
    public partial class Matricula
    {
        public int Idmatricula { get; set; }
        public int? Idalumno { get; set; }
        public int? Idprofesor { get; set; }
        public int? Idmateria { get; set; }
        public double? Nota { get; set; }

        public Alumno IdalumnoNavigation { get; set; }
        public Materia IdmateriaNavigation { get; set; }
        public Profesor IdprofesorNavigation { get; set; }
    }
}
