using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facultadAlumnoProfesor
{
   public class Alumno:Persona
    {
        protected int _legajo;

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

          public Alumno(int edad, int legajo, string nombre)
              :base(nombre,edad)           
        {
            this._legajo = legajo;
        }

          public Alumno(Persona personaQueSeAnoto, int legajo)
              : base(personaQueSeAnoto.Nombre, personaQueSeAnoto.Edad)
          {

              this._legajo = legajo;
          }
       
      
    }
}
