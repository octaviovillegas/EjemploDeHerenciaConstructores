using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facultadAlumnoProfesor
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad = 66;
            Persona ObjetoPersona = new Persona("alguien", edad);
            int legajo = 333;
            Alumno objetoAlumo = new Alumno(ObjetoPersona, legajo);
            DateTime fechaEgreso = DateTime.Now;
            AlumnoEgresado objetoAlumnoEgresado = new AlumnoEgresado(objetoAlumo, fechaEgreso);




        }
    }
}
