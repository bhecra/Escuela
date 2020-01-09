using System;
using System.Collections.Generic;

namespace ASP_NET.Models
{
    public class Curso : ObjetoEscuelaBase
    {

        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set;}
        public List<Alumno> Alumnos { get; set;}

        public Curso(string nombre) {
            Nombre = nombre;
        }
    }
}