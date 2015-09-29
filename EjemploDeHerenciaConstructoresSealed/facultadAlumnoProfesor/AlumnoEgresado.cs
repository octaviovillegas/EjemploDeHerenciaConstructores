using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facultadAlumnoProfesor
{
   public sealed class AlumnoEgresado:Alumno
    {
        private DateTime _fechaDeEgreso;

        public DateTime FechaDeEgreso
        {
            get { return  this._fechaDeEgreso;  }
            set { this._fechaDeEgreso = value; }
        
        }


        public void mostrar()
        {
            Console.WriteLine(base._legajo);
        }
        public AlumnoEgresado( DateTime fechaparam,int edad, int legajo, string nombre)
            : base(edad,legajo,nombre)
           
        {
            this._fechaDeEgreso = fechaparam;
        }

        //public AlumnoEgresado(Alumno alguienquellego, DateTime fechaquellego):base(alguienquellego.Edad,alguienquellego.Legajo,alguienquellego.Nombre)
        //{
        //    this._fechaDeEgreso = fechaquellego;
        //}
        public AlumnoEgresado(Alumno alumnoQueEgreso, DateTime fechaQueEgreso)
            : base(alumnoQueEgreso,alumnoQueEgreso.Legajo)
        {
            this._fechaDeEgreso = fechaQueEgreso;
        }

        public override string ToString()
        {
            return base.ToString()+" fecha de egreso:"+ this._fechaDeEgreso;
        }

    }
}
