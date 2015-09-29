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
            Persona objetoPersona = new Persona("Persona", edad);
            int legajo = 333;
            //Alumno objetoAlumo = new Alumno(objetoPersona, legajo);
            Alumno objetoAlumo = new Alumno(new Persona("alumno",77), legajo);
            DateTime fechaEgreso = DateTime.Now;
            //AlumnoEgresado objetoAlumnoEgresado = new AlumnoEgresado(objetoAlumo, fechaEgreso);
            AlumnoEgresado objetoAlumnoEgresado = new AlumnoEgresado(new Alumno(22,8888," alumnoEgresado"),DateTime.Now);
            Profesor objetoProfesor = new Profesor(new Persona("profesor",55), 999);
            Persona[] conjuntoDePersonas= new Persona[4];
            conjuntoDePersonas[0] = objetoPersona;
            conjuntoDePersonas[1] = objetoAlumo;
            conjuntoDePersonas[2] = objetoAlumnoEgresado;
            conjuntoDePersonas[3] = objetoProfesor;





            foreach (Persona item in conjuntoDePersonas)
            {
                Console.WriteLine(item.ToString());
            }



        }
    }
}
