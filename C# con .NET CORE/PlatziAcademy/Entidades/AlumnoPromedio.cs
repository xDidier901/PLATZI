using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class AlumnoPromedio
    {
        public float promedio;
        public string alumnoid;
        public string alumnoNombre;

        public override string ToString()
        {
            return $"Alumno: {alumnoNombre} - Promedio: {Math.Round(promedio, 2)}";
        }
    }
}