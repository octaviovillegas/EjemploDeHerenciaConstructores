using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facultadAlumnoProfesor
{
    public   class Persona
    {
        private string _nombre;
        protected int _edad;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public Int32 Edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                this._edad = value;
            }
        }


        public Persona(string nombre, Int32 edad)
        {
            this._nombre = nombre;
            this._edad = edad;
        }
        public override string ToString()
        {
            return " nombre:"+ this.Nombre + " edad:"+this._edad;
        }
       
      
    }
}
