using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facultadAlumnoProfesor
{
    class Profesor:Persona
    {
        private int _legajoDocente;

        public Profesor(Persona PersonaParametro, int legajo):base(PersonaParametro.Nombre,PersonaParametro.Edad)
        {
            this._legajoDocente = legajo;
            
        }
    }
}
