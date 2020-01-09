using System;
using System.Collections.Generic;

namespace ASP_NET.Models
{
    public class Escuela : ObjetoEscuelaBase
    {
        string nombre;
        int añoDeCreacion;

        public int AñoDeCreacion { get => añoDeCreacion; set => añoDeCreacion = value; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set;}


        public Escuela(string nombre, int año, 
                        TiposEscuela tipo, 
                        string pais="", string ciudad="")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public List<Curso> Cursos  { get; set; }

        public string Direccion { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais: {Pais}"; 
        }

    }
}